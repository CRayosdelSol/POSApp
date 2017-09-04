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
using static System.String;
using System.Collections.Generic;
using System.Collections;
using System.Drawing.Printing;


namespace _POS
{
    public partial class FrmMain : Form
    {
        private string _dir;
        private string _tableName;
        private string _filepath;
        private string _connString;
        private int _transactionCounter;

        private DataTable _dt;
        private DataSet _ds;
        private SqlDataAdapter _da;
        private DatabaseOps _db;
        private SqlDataReader _reader;
        private SqlConnection _sqlConnection;
        private SqlCommand _sqlComm;

        private int _totalQuantity;
        private decimal _totalPrice;
        internal decimal TaxMultiplier, SpecificQuantity;
        internal string IpAddressHolder;
        internal int PortNumber;
        internal bool SpecifiedQuantity, HaveSpecificTaxMultiplier, ScannerSettingsAreSet;
        private bool _isScanning;
        internal List<string> transactionList;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void ScaleComponents()
        {
            MinimumSize = new Size(Width, Height);
            MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            ScaleComponents();
            ListPreviousTransactions();
            txtbx_total.ReadOnly = true;
            MaximizeBox = false;


            btn_startScan.Enabled = false;
            ststrplbl_Port.Text = $@"Port: {"Not Set"}";
            ststrplbl_IP.Text = $@"I.P. Address: {"Not Set"}";
            lbl_CurrentTaxMult.Text = $@"Current Tax Multiplier: {"None"}";
            lbl_totalItems.Text = $@"Current Total No. of Items: {0}";

            btn_PrintTransaction.Label = "Print Transaction";
        }

        #region Inventory Bits

        private void InitializeDataGrid()
        {
            _dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ProjectFiles\";
            _filepath = _dir + "Inventory.mdf";

            // Create the database within the specified directory
            var dirInf = Directory.CreateDirectory(_dir);
            dirInf.Attributes = FileAttributes.Directory;

            // DB Connection Setup
            _connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + _filepath +
                          "; Integrated Security=True;Connect Timeout=30";
            _db = new DatabaseOps(_connString);

            //Create the database if and only if it doesn't exist
            if (!File.Exists(_filepath))
                _db.CreateDatabase(_filepath);

            _tableName = $"[TRANSACTION-{DateTime.Now:MM-dd-yyyy-hh-mm}({_transactionCounter})]";


            _db.CreateTable("Items", "ID", "int Identity(1,1) PRIMARY KEY", "Barcode", "varchar(255)", "Item",
                "varchar(255)", "Price", "varchar(255)", "Quantity", "varchar(255)");

            BindDatasource(dtgrd_Inventory, "Items");
            ScaleComponents();
        }

        private void BindDatasource(DataGridView grid, string tableName)
        {
            try
            {
                _sqlConnection = new SqlConnection(_connString);
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
            _totalPrice = 0;
            _totalQuantity = 0;

            btnG_DeleteItems.Enabled = true;
            btnG_Finalize.Enabled = true;
            btnG_CancelTransaction.Enabled = true;

            foreach (DataGridViewRow row in dtrgd_POS.Rows)
                if (row.Cells[0].Value.ToString() != "TOTAL")
                {
                    _totalQuantity += Convert.ToInt32(row.Cells[2].Value);
                    _totalPrice += Convert.ToDecimal(row.Cells[3].Value);

                    if (HaveSpecificTaxMultiplier)
                        _totalPrice += _totalPrice * TaxMultiplier;
                }

            //Display the total cost in terms of Philippine Peso
            txtbx_total.Text = @"TOTAL:   " + _totalPrice.ToString("C2", CultureInfo.CreateSpecificCulture("en-PH"));
            lbl_totalItems.Text = $@"Total Number of Items: {_totalQuantity}";
        }

        private void Scan()
        {
            TcpListener server = null;
            var bytes = new byte[256];

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
                _isScanning = false;
                btn_startScan.Invoke(new MethodInvoker(delegate { btn_startScan.Enabled = true; }));
                btn_startScan.Invoke(new MethodInvoker(delegate { btn_startScan.Label = "START\nSCANNING"; }));
            }
            //bring me back
        }

        private void lstbx_transactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbx_transactions.SelectedIndex > -1)
                BindDatasource(dtgrd_transactions, lstbx_transactions.SelectedItem.ToString());
        }

        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("Donkey Horse Mini Grocery".PadLeft(39), new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            string top = "Nice St. JEFF OF VEX CITY, 1331, (02)131-13-33";
            string subTop = "1234567, yehaawNeigh@gmail.com, WWW.DONKEYHORSEMINI.com";

            graphic.DrawString(top.PadLeft(71), new Font("Courier New",10), new SolidBrush(Color.Black), startX, startY + offset-15);
            offset = offset + (int)fontHeight; //spacing
            graphic.DrawString(subTop, new Font("Courier New",8), new SolidBrush(Color.Black), startX + 224,
                startY + offset-15);

            offset = offset + (int)fontHeight; //spacing
            graphic.DrawString(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ".PadLeft(30), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            foreach (string v in transactionList)
            {
                graphic.DrawString(v.PadLeft(60), font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            } //kinuha from input ng user yung form1.productnamelist.
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ".PadLeft(30), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;
            graphic.DrawString("Total:    ".PadLeft(32) + " ".PadLeft(20) + _totalPrice.ToString("0.00##"), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;
            graphic.DrawString(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ".PadLeft(30), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            offset = offset + 20;
            //graphic.DrawString("Money:  ".PadLeft(33) + " ".PadLeft(23) + mon, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;
            offset = offset + 5;
            //graphic.DrawString("Change:".PadLeft(32) + " ".PadLeft(23) + total, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;
            offset = offset + 20;
            offset = offset + 20;
            graphic.DrawString(Format("THIS SERVES AS YOUR OFFICIAL RECEIPT".PadLeft(58)), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset - 5;
            graphic.DrawString(Format($"\n{DateTime.Now:MMMM dd, yyyy}"), font, new SolidBrush(Color.Black), startX+322, startY + offset);
            offset = offset + 60;
            graphic.DrawString("Thank you for buying!".PadLeft(51), font, new SolidBrush(Color.Black), startX, startY + offset);

        }


        public void collateItems(DataGridView grid)
        {
            transactionList = new List<string>();
            string temp = string.Empty;

            if (grid.Name == "dtrgd_POS")
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    temp = string.Format("{0}".PadRight(25).PadLeft(15) + "{1}".PadLeft(5),
                        row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString());

                    transactionList.Add(temp);
                }
            }
            else
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.Cells[1].Value.ToString() != "TOTAL")
                    {
                        temp = string.Format("{0}".PadRight(25).PadLeft(15) + "{1}".PadLeft(5),
                            row.Cells[2].Value.ToString(), row.Cells[4].Value.ToString());

                        transactionList.Add(temp);
                    }
                    else
                    {
                        _totalPrice = decimal.Parse(row.Cells[4].Value.ToString());
                    }
                }
            }


        }

        private void btnG_Finalize_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Are you sure you wish to finalize this transaction?",
                @"Finalize Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            const string cmdQty = "SELECT Quantity FROM Items WHERE Barcode=@code";

            if (dialogResult != DialogResult.Yes) return;

            // update the inventory 
            foreach (DataGridViewRow datarow in dtrgd_POS.Rows)
            {
                var serialNumber = datarow.Cells[0].Value.ToString();
                int orderQty = Convert.ToInt16(datarow.Cells[2].Value.ToString());

                using (_sqlConnection = new SqlConnection(_connString))
                {
                    _sqlConnection.Open();

                    var sqlQty = new SqlCommand(cmdQty, _sqlConnection);
                    sqlQty.Parameters.AddWithValue("@code", serialNumber);

                    var qtyReader = sqlQty.ExecuteReader();
                    var storedQty = 0;
                    while (qtyReader.Read())
                    {
                        storedQty = Convert.ToInt16(qtyReader["Quantity"].ToString());
                    }
                    qtyReader.Close();

                    storedQty -= orderQty;
                    var updateCmd = $"UPDATE Items set Quantity={storedQty} where Barcode=@code";
                    var sqlUpd = new SqlCommand(updateCmd, _sqlConnection);
                    sqlUpd.Parameters.AddWithValue("@code", serialNumber);

                    sqlUpd.ExecuteNonQuery();
                }
            }

            printReceipt(dtrgd_POS);

            _transactionCounter++;
            _tableName = $"[TRANSACTION-{DateTime.Now:MM-dd-yyyy-hh-mm}({_transactionCounter})]";
            dtrgd_POS.Rows.Add("TOTAL",Empty, _totalQuantity.ToString(), _totalPrice.ToString("0.00##"));
            BuildDataTable(dtrgd_POS, _tableName);

            //Reset everything that is involved in the transaction process.
            _totalQuantity = 0;
            dtrgd_POS.Rows.Clear();
            dtrgd_POS.Refresh();
            lbl_totalItems.Text = $@"Total Number of Items: {_totalQuantity}";
            txtbx_total.Text = @"TOTAL     ₱0.00";

            //Update the list of previous transactions
            ListPreviousTransactions();

            //Disable controls that are related to the transaction process as the grid is empty.
            btnG_DeleteItems.Enabled = false;
            btnG_Finalize.Enabled = false;
            btnG_CancelTransaction.Enabled = false;
        }

        public void printReceipt(DataGridView grid)
        {
            collateItems(grid);
            PrintDialog printdiag = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printdiag.Document = printDoc;
            printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt);
            DialogResult result = printdiag.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDoc.Print();
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
                _totalQuantity = 0;
                dtrgd_POS.Rows.Clear();
                dtrgd_POS.Refresh();
                lbl_totalItems.Text = $@"Total Number of Items: {_totalQuantity}";
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
                var dialogResult = MessageBox.Show(
                    @"The settings for the external barcode reader have already been configured. Do you wish to reconfigure them?",
                    @"Reconfigure Scanner", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    var frmIpAddSettings = new FrmIpAddSettings(this);
                    frmIpAddSettings.ShowDialog();
                    if (ScannerSettingsAreSet)
                    {
                        btn_startScan.Enabled = true;
                        ststrplbl_Port.Text = $@"Port: {PortNumber}";
                        ststrplbl_IP.Text = $@"I.P. Address: {IpAddressHolder}";
                    }
                    else
                    {
                        btn_startScan.Enabled = false;
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
                    btn_startScan.Enabled = true;
                    ststrplbl_Port.Text = $@"Port: {PortNumber}";
                    ststrplbl_IP.Text = $@"I.P. Address: {IpAddressHolder}";
                }
                else
                {
                    btn_startScan.Enabled = false;
                    ststrplbl_Port.Text = $@"Port: {"Not Set"}";
                    ststrplbl_IP.Text = $@"I.P. Address: {"Not Set"}";
                }
            }
        }

        private void btnG_StartScanning_Load(object sender, EventArgs e)
        {
            btn_startScan.Label = "START\nSCANNING";
        }

        private async void btnG_StartScanning_Click(object sender, EventArgs e)
        {
            /*Return control to the caller until the scanning process is completed.
            This will keep the UI functional while any received data is being pro-
            cessed.*/
            await Task.Run(() =>
            {
                _isScanning = true;
                while (_isScanning)
                {
                    btn_startScan.Invoke(new MethodInvoker(delegate { btn_startScan.Enabled = false; }));
                    btn_startScan.Invoke(new MethodInvoker(delegate { btn_startScan.Label = "SCANNING"; }));
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
            var dialogResult = MessageBox.Show(@"Are you sure you wish to delete the selected items?",
                @"Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                foreach (DataGridViewRow selectedRow in dtrgd_POS.SelectedRows)
                    dtrgd_POS.Rows.Remove(selectedRow);
        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            _db.UpdateDataset(_ds, "Items");
            BindDatasource(dtgrd_Inventory, "Items");
            ScaleComponents();
        }

        private void btn_PrintTransaction_Click(object sender, EventArgs e)
        {
            //Produce the simulated receipt.
            printReceipt(dtgrd_transactions);
        }

        private void Tbctrl_POS_Click(object sender, EventArgs e)
        {
            dtgrd_Inventory.Refresh();
        }

        /// <summary>
        /// Search the database using the specified serial number.
        /// </summary>
        /// <param name="serialNumber">The item's serial number.</param>
        private void SearchForItem(string serialNumber)
        {
            object[] items;

            var command = "SELECT * FROM Items WHERE Barcode=@code";

            string barcode = Empty, itemName = Empty;
            double itemPrice = 0;

            using (_sqlConnection = new SqlConnection(_connString))
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

                _reader.Close();
            }

            if (SpecifiedQuantity)
            {
                var computedPrice = Convert.ToDouble(SpecificQuantity) * itemPrice;
                items = new object[]
                {
                    barcode, itemName, SpecificQuantity.ToString(CultureInfo.InvariantCulture),
                    computedPrice.ToString("0.00##")
                };
                SpecifiedQuantity = false;
            }
            else
            {
                items = new object[] { barcode, itemName, "1", itemPrice.ToString("0.00##") };
            }

            dtrgd_POS.Invoke(new MethodInvoker(delegate { dtrgd_POS.Rows.Add(items); }));
        }

        private void BuildDataTable(DataGridView grid, string tableName)
        {
            _db.CreateTable(tableName, "ID", "int Identity(1,1) PRIMARY KEY", "Barcode", "varchar(255)", "Item",
                "varchar(255)", "Quantity", "varchar(255)", "Price", "SmallMoney");

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

        private void ListPreviousTransactions()
        {
            lstbx_transactions.Items.Clear();
            const string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
            using (_sqlConnection = new SqlConnection(_connString))
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