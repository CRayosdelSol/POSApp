using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseOperations;
using DGVPrinterHelper;
using static System.String;


namespace _POS
{
    public partial class FrmMain : Form
    {
        private string _dir;
        private string _tableName;
        protected string Filepath;
        protected string ConnString;
        private int _transactionCounter;

        private DataTable _dt;
        private DataSet _ds;
        private SqlDataAdapter _da;
        private DatabaseOps _db;
        private SqlDataReader _reader;
        private SqlConnection _sqlConnection;
        private SqlCommand _sqlComm;

        internal int TotalQuantity;
        internal decimal TotalPrice, TaxMultiplier, SpecificQuantity;
        internal string IpAddressHolder;
        internal int PortNumber;
        internal bool SpecifiedQuantity, HaveSpecificTaxMultiplier, ScannerSettingsAreSet, IsScanning;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataGrid();
            dtgrd_Inventory.AutoGenerateColumns = false;
            dtgrd_transactions.AutoGenerateColumns = false;
            var tmr = new Timer { Interval = 1000 };
            // ticks every 1 second
            tmr.Tick += UpdateTime;
            tmr.Start();
            cmbbx_searchMode.SelectedIndex = 0;
            ScaleComponents(dtgrd_Inventory);
            ListPreviousTransactions();
            txtbx_total.ReadOnly = true;
            MaximizeBox = false;


            btn_startScan.Enabled = false;
            ststrplbl_Port.Text = $@"Port: {"Not Set"}";
            ststrplbl_IP.Text = $@"I.P. Address: {"Not Set"}";
            lbl_CurrentTaxMult.Text = $@"Current Tax Multiplier: {"None"}";
            lbl_totalItems.Text = $@"Current Total No. of Items: {0}";
        }

        public void ScaleComponents(DataGridView grid)
        {
            MinimumSize = new Size(Width, Height);
            MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        #region Inventory Bits

        public void InitializeDataGrid()
        {
            _dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ProjectFiles\";
            Filepath = _dir + "Inventory.mdf";

            // Create the database within the specified directory
            var dirInf = Directory.CreateDirectory(_dir);
            dirInf.Attributes = FileAttributes.Directory;

            // DB Connection Setup
            ConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Filepath +
                         "; Integrated Security=True;Connect Timeout=30";
            _db = new DatabaseOps(ConnString);

            //Create the database if and only if it doesn't exist
            if (!File.Exists(Filepath))
                _db.CreateDatabase(Filepath);

            _tableName = $"[TRANSACTION-{DateTime.Now:MM-dd-yyyy-hh-mm}({_transactionCounter})]";


            _db.CreateTable("Items", "ID", "int Identity(1,1) PRIMARY KEY", "Barcode", "varchar(255)", "Item",
                "varchar(255)", "Price", "varchar(255)", "Quantity", "varchar(255)");

            BindDatasource(dtgrd_Inventory, "Items");
            ScaleComponents(dtgrd_Inventory);
        }

        public void BindDatasource(DataGridView grid, string tableName)
        {
            try
            {
                _sqlConnection = new SqlConnection(ConnString);
                var command = "SELECT * FROM [" + tableName + "]";
                _sqlComm = new SqlCommand(command, _sqlConnection);
                _da = new SqlDataAdapter(_sqlComm);
                _ds = new DataSet();
                _da.Fill(_ds, tableName);
                grid.DataMember = tableName;
                grid.DataSource = _ds;

                _sqlComm.Dispose();
                _da.Dispose();
                _ds.Dispose();
                SqlConnection.ClearAllPools();
            }
            catch
            {
                //The error happened. Don't let the user know becuase he doesn't need to.
            }
        }

        #endregion

        private void UpdateTime(object sender, EventArgs e)
        {
            ststrplbl_Datetime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
        }

        private void cmbbx_searchMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbx_searchBox.Select();
            txtbx_searchBox.Clear();
        }

        #region searching

        private void txtbx_searchBox_TextChanged(object sender, EventArgs e)
        {
            var searchMode = cmbbx_searchMode.GetItemText(cmbbx_searchMode.SelectedItem).Replace(" ", "").ToLower();
            if (searchMode == "name")
                _ds.Tables["Items"].DefaultView.RowFilter = $"Item LIKE '{txtbx_searchBox.Text}%'";
            else if (searchMode == "barcode")
                _ds.Tables["Items"].DefaultView.RowFilter = $"Barcode LIKE '{txtbx_searchBox.Text}%'";
            else if (searchMode == "price")
                if (txtbx_searchBox.Text.Length >= 3 && txtbx_searchBox.Text.Contains("-"))
                {
                    var values = txtbx_searchBox.Text.Split('-');
                    _ds.Tables["Items"].DefaultView.RowFilter =
                        $"Price >= {values[0]} and Price <= {values[1]}";
                }

            dtgrd_Inventory.DataSource = _ds.Tables["Items"].DefaultView;
        }

        #endregion

        private void btn_Del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgrd_Inventory.SelectedRows)
                dtgrd_Inventory.Rows.Remove(row);
        }

        private void dtrgd_POS_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TotalPrice = 0;
            TotalQuantity = 0;

            btnG_DeleteItems.Enabled = true;
            btnG_Finalize.Enabled = true;
            btnG_CancelTransaction.Enabled = true;

            foreach (DataGridViewRow row in dtrgd_POS.Rows)
                if (row.Cells[0].Value.ToString() != "TOTAL")
                {
                    TotalQuantity += Convert.ToInt32(row.Cells[2].Value);
                    TotalPrice += Convert.ToDecimal(row.Cells[3].Value);

                    if (HaveSpecificTaxMultiplier)
                        TotalPrice += TotalPrice * TaxMultiplier;
                }

            //Display the total cost in terms of Philippine Peso
            txtbx_total.Text = @"TOTAL:   " + TotalPrice.ToString("C2", CultureInfo.CreateSpecificCulture("en-PH"));
            lbl_totalItems.Text = $@"Total Number of Items: {TotalQuantity}";
        }

        public void Scan()
        {
            TcpListener server = null;
            var bytes = new byte[512];

            try
            {
                var ipAdd = IPAddress.Parse(IpAddressHolder);
                server = new TcpListener(ipAdd, PortNumber);
                server.Start();

                var client = server.AcceptTcpClient();

                var stream = client.GetStream();

                int i;

                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    var serialNumberHolder = Encoding.ASCII.GetString(bytes, 0, i);
                    SearchForItem(serialNumberHolder);
                }

                client.Close();
            }
            catch (SocketException)
            {
            }
            finally
            {
                Debug.Assert(server != null, nameof(server) + " != null");
                server.Stop();
                IsScanning = false;
                btn_startScan.Invoke(new MethodInvoker(delegate { btnG_StartScanning.Enabled = true; }));
                btn_startScan.Invoke(new MethodInvoker(delegate { btnG_StartScanning.Label = "START\nSCANNING"; }));
            }
            //bring me back
        }

        private void lstbx_transactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbx_transactions.SelectedIndex > -1)
                BindDatasource(dtgrd_transactions, lstbx_transactions.SelectedItem.ToString());
        }

        public void PrintReceipt(DataGridView grid)
        {
            DGVPrinter receiptPrinter = new DGVPrinter
            {
                Title = "Donkey Horse Mini Grocery",
                SubTitle = string.Format("{0} {1}, {2}, {3}\n{4}, {5}, {6}", "MMMM St.", "YEFF OF YEX CITY", "1331",
                    "(02)131-13-33", "1234567", "yehaawNeigh@gmail.com", "WWW.DONKEYHORSEMINI.com"),
                SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip,
                PageNumbers = false,
                PageNumberInHeader = false,
                PorportionalColumns = true,
                HeaderCellAlignment = StringAlignment.Near,
                Footer = Format("THIS SERVES AS YOUR OFFICIAL RECEIPT " + $"\n{DateTime.Now.ToString("MMMM dd, yyyy")}"),
                FooterSpacing = 15
            };
            receiptPrinter.PrintDataGridView(grid);
        }

        private void btnG_Finalize_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Are you sure you wish to finalize this transaction?",
                @"Finalize Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    _transactionCounter++;
                    _tableName = $"[TRANSACTION-{DateTime.Now:MM-dd-yyyy-hh-mm}({_transactionCounter})]";
                    dtrgd_POS.Rows.Add("TOTAL", Empty, TotalQuantity.ToString(), TotalPrice.ToString("0.00##"));
                    BuildDataTable(dtrgd_POS, _dt, _tableName);

                    //Produce the simulated receipt.
                    PrintReceipt(dtrgd_POS);


                    //Reset everything that is involved in the transaction process.
                    TotalQuantity = 0;
                    dtrgd_POS.Rows.Clear();
                    dtrgd_POS.Refresh();
                    lbl_totalItems.Text = $@"Total Number of Items: {TotalQuantity}";
                    txtbx_total.Text = @"TOTAL     ₱0.00";

                    //Update the list of previous transactions
                    ListPreviousTransactions();

                    //Disable controls that are related to the transaction process as the grid is empty.
                    btnG_DeleteItems.Enabled = false;
                    btnG_Finalize.Enabled = false;
                    btnG_CancelTransaction.Enabled = false;
                    break;
            }
        }

        private void btnG_CancelTransaction_Load(object sender, EventArgs e)
        {
            btnG_CancelTransaction.Label = "CANCEL\nTRANSACTION";
        }

        private void btnG_CancelTransaction_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Are you sure you wish to finalize this transaction?",
                @"Finalize Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                TotalQuantity = 0;
                dtrgd_POS.Rows.Clear();
                dtrgd_POS.Refresh();
                lbl_totalItems.Text = $@"Total Number of Items: {TotalQuantity}";
                txtbx_total.Text = @"TOTAL     ₱0.00";

                btnG_DeleteItems.Enabled = false;
                btnG_Finalize.Enabled = false;
                btnG_CancelTransaction.Enabled = false;
            }
        }

        private void btnG_Finalize_Load(object sender, EventArgs e)
        {
            btnG_Finalize.Label = "FINALIZE\nTRANSACTION";
        }

        private void btnG_DeleteItems_Load(object sender, EventArgs e)
        {
            btnG_DeleteItems.Label = "DELETE\nITEM(S)";
        }

        private void btnG_TaxMultiplier_Load(object sender, EventArgs e)
        {
            btnG_TaxMultiplier.Label = "TAX\nMULTIPLIER";
        }

        private void btnG_TaxMultiplier_Click(object sender, EventArgs e)
        {
            HaveSpecificTaxMultiplier = false;
            var taxSetFrm = new FrmTaxSettings(this);
            taxSetFrm.ShowDialog();
            lbl_CurrentTaxMult.Text = HaveSpecificTaxMultiplier
                ? $"Current Tax Multiplier: {TaxMultiplier * 100}%"
                : "Current Tax Multiplier: None";
        }

        private void btnG_Quantity_Click(object sender, EventArgs e)    
        {
            var quantityFrm = new FrmQuantity(this);
            quantityFrm.ShowDialog();
        }

        private void btnG_ScannerSettings_Load(object sender, EventArgs e)
        {
            btnG_ScannerSettings.Label = "SCANNER\nSETTINGS";
        }

        private void btnG_ScannerSettings_Click(object sender, EventArgs e)
        {
            if (ScannerSettingsAreSet)
            {
                var dialogResult = MessageBox.Show(@"The settings for the external barcode reader have already been configured. Do you wish to reconfigure them?",
                    @"Reconfigure Scanner", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    var frmIpAddSettings = new FrmIpAddSettings(this);
                    frmIpAddSettings.ShowDialog();
                    if (ScannerSettingsAreSet)
                    {
                        btnG_StartScanning.Enabled = true;
                        ststrplbl_Port.Text = $@"Port: {PortNumber}";
                        ststrplbl_IP.Text = $@"I.P. Address: {IpAddressHolder}";
                    }
                    else
                    {
                        btnG_StartScanning.Enabled = false;
                        ststrplbl_Port.Text = $@"Port: {"Not Set"}";
                        ststrplbl_IP.Text = $@"I.P. Address: {"Not Set"}";
                    }
                }
            }
            else
            {
                var frmIpAddSettings = new FrmIpAddSettings(this);
                frmIpAddSettings.ShowDialog();

                if (ScannerSettingsAreSet)
                {
                    btnG_StartScanning.Enabled = true;
                    ststrplbl_Port.Text = $@"Port: {PortNumber}";
                    ststrplbl_IP.Text = $@"I.P. Address: {IpAddressHolder}";
                }
                else
                {
                    btnG_StartScanning.Enabled = false;
                    ststrplbl_Port.Text = $@"Port: {"Not Set"}";
                    ststrplbl_IP.Text = $@"I.P. Address: {"Not Set"}";
                }
            }
        }

        private void btnG_StartScanning_Load(object sender, EventArgs e)
        {
            btnG_StartScanning.Label = "START\nSCANNING";
        }

        private async void btnG_StartScanning_Click(object sender, EventArgs e)
        {
            /*Return control to the caller until the scanning process is completed.
            This will keep the UI functional while any received data is being pro-
            cessed.*/
            await Task.Run(() =>
            {
                IsScanning = true;
                while (IsScanning)
                {
                    btn_startScan.Invoke(new MethodInvoker(delegate { btnG_StartScanning.Enabled = false; }));
                    btn_startScan.Invoke(new MethodInvoker(delegate { btnG_StartScanning.Label = "SCANNING"; }));
                    Scan();
                }
            });
        }

        private void dtrgd_POS_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtrgd_POS.RowCount >= 1)
            {
                btnG_DeleteItems.Enabled = true;
                btnG_Finalize.Enabled = true;
                btnG_CancelTransaction.Enabled = true;
            }
            else
            {
                btnG_DeleteItems.Enabled = false;
                btnG_Finalize.Enabled = false;
                btnG_CancelTransaction.Enabled = false;
            }
        }

        private void btnG_DeleteItems_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Are you sure you wish to finalize this transaction?",
                @"Finalize Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                foreach (DataGridViewRow selectedRow in dtrgd_POS.SelectedRows)
                    dtrgd_POS.Rows.Remove(selectedRow);
        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            _db.UpdateDataset(_ds, "Items");
            BindDatasource(dtgrd_Inventory, "Items");
            ScaleComponents(dtgrd_Inventory);
        }

        /// <summary>
        /// Search the database using the specified serial number.
        /// </summary>
        /// <param name="serialNumber">The item's serial number.</param>
        public void SearchForItem(string serialNumber)
        {
            object[] items;

            var command = "SELECT * FROM Items WHERE Barcode=@code";

            string barcode = Empty, itemName = Empty;
            double itemPrice = 0;

            using (_sqlConnection = new SqlConnection(ConnString))
            {
                _sqlConnection.Open();
                _sqlComm = new SqlCommand(command, _sqlConnection);
                _sqlComm.Parameters.AddWithValue("@code", serialNumber);
                _reader = _sqlComm.ExecuteReader();
                while (_reader.Read())
                {
                    barcode = _reader["Barcode"].ToString();
                    itemName = _reader["Item"].ToString();
                    itemPrice = Convert.ToDouble(_reader["Price"].ToString());
                }

                if (SpecifiedQuantity)
                {
                    var computedPrice = Convert.ToDouble(SpecificQuantity) * itemPrice;
                    items = new object[] { barcode, itemName, SpecificQuantity.ToString(), computedPrice.ToString("0.00##") };
                    SpecifiedQuantity = false;
                }
                else
                {
                    items = new object[] { barcode, itemName, "1", itemPrice.ToString("0.00##") };
                }

                dtrgd_POS.Invoke(new MethodInvoker(delegate { dtrgd_POS.Rows.Add(items); }));

                //dtrgd_POS.Invoke(new MethodInvoker(delegate { dtrgd_POS.DataSource = dt; }));
                //dtrgd_POS.Rows.Add(items);
            }
        }

        public void BuildDataTable(DataGridView grid, DataTable table, string tableName)
        {
            _db.CreateTable(tableName, "ID", "int Identity(1,1) PRIMARY KEY", "Barcode", "varchar(255)", "Item",
                "varchar(255)", "Quantity", "varchar(255)", "Price", "varchar(255)");

            _dt = new DataTable(tableName);
            _dt.Columns.Add("Barcode", Type.GetType("System.String") ?? throw new InvalidOperationException());
            _dt.Columns.Add("Item", Type.GetType("System.String") ?? throw new InvalidOperationException());
            _dt.Columns.Add("Quantity", Type.GetType("System.String") ?? throw new InvalidOperationException());
            _dt.Columns.Add("Price", Type.GetType("System.String") ?? throw new InvalidOperationException());

            foreach (DataGridViewRow row in grid.Rows)
            {
                var brcd = row.Cells[0].Value.ToString();
                var itm = row.Cells[1].Value.ToString();
                var qnty = row.Cells[2].Value.ToString();
                var prc = row.Cells[3].Value.ToString();
                var items = new object[] { brcd, itm, qnty, prc };
                _dt.Rows.Add(items);
            }

            _ds.Tables.Add(_dt);
            _db.UpdateDataset(_ds, tableName);
        }

        public void ListPreviousTransactions()
        {
            lstbx_transactions.Items.Clear();
            const string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
            using (_sqlConnection = new SqlConnection(ConnString))
            {
                _sqlConnection.Open();

                using (_sqlComm = new SqlCommand(query, _sqlConnection))
                {
                    using (_reader = _sqlComm.ExecuteReader())
                    {
                        while (_reader.Read())
                        {
                            var filter = _reader["TABLE_NAME"].ToString();
                            if (filter.Contains("TRANSACTION"))
                                lstbx_transactions.Items.Add(filter);
                        }
                    }
                }
            }
        }
    }
}