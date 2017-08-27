using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseOperations;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Net.Sockets;
using System.Net;
using DGVPrinterHelper;



namespace _POS
{
    public partial class FRM_Main : Form
    {
        string dir;
        string tableName;
        protected string filepath;
        protected string connString;
        int transactionCounter;

        DataTable dt;
        DataSet ds;
        SqlDataAdapter da;
        DatabaseOps Db;
        SqlDataReader reader;
        SqlConnection sqlConnection;
        SqlCommand sqlComm;
        
        internal int specificQuantity, totalQuantity;
        internal decimal totalPrice, taxMultiplier;
        internal string IPAddressHolder;
        internal Int32 PortNumber;
        internal bool specified_Quantity, haveSpecificTaxMultiplier, scannerSettingsAreSet, isScanning;

        public FRM_Main()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            initializeDataGrid();
            dtgrd_Inventory.AutoGenerateColumns = false;
            dtgrd_transactions.AutoGenerateColumns = false;
            Timer tmr = new Timer();
            tmr.Interval = 1000; // ticks every 1 second
            tmr.Tick += new EventHandler(updateTime);
            tmr.Start();
            cmbbx_searchMode.SelectedIndex = 0;
            scaleComponents(dtgrd_Inventory);
            listPreviousTransactions();

            btn_startScan.Enabled = false;
            ststrplbl_Port.Text = string.Format("Port: {0}", "Not Set");
            ststrplbl_IP.Text = string.Format("I.P. Address: {0}", "Not Set");
            lbl_CurrentTaxMult.Text = string.Format("Current Tax Multiplier: {0}", "Not Set");
            lbl_totalItems.Text = string.Format("Current Total No. of Items: {0}", 0);
        }

        public void scaleComponents(DataGridView grid)
        {
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        #region Inventory Bits
        public void initializeDataGrid()
        {
            
            dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ProjectFiles\";
            filepath = dir + "Inventory.mdf";

            // Create the database within the specified directory
            DirectoryInfo dirInf = Directory.CreateDirectory(dir);
            dirInf.Attributes = FileAttributes.Directory;

            // DB Connection Setup
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + filepath + "; Integrated Security=True;Connect Timeout=30";
            Db = new DatabaseOps(connString);

            //Create the database if and only if it doesn't exist
            if (!File.Exists(filepath))
            {
                Db.CreateDatabase(filepath);
            }

            tableName = string.Format("[TRANSACTION-{0}({1})]", DateTime.Now.ToString("MM-dd-yyyy-hh-mm"), transactionCounter);


            Db.CreateTable("Items", "ID", "int Identity(1,1) PRIMARY KEY", "Barcode", "varchar(255)", "Item", "varchar(255)", "Price", "varchar(255)", "Quantity", "varchar(255)");

            bindDatasource(dtgrd_Inventory,"Items");
            scaleComponents(dtgrd_Inventory);

        }

        public void bindDatasource(DataGridView grid, string tableName)
        {
            try
            {
                sqlConnection = new SqlConnection(connString);
                string command = "SELECT * FROM [" + tableName + "]";
                sqlComm = new SqlCommand(command, sqlConnection);
                da = new SqlDataAdapter(sqlComm);
                ds = new DataSet();
                da.Fill(ds, tableName);
                grid.DataMember = tableName;
                grid.DataSource = ds;

                sqlComm.Dispose();
                da.Dispose();
                ds.Dispose();
                SqlConnection.ClearAllPools();
            }
            catch
            {
                //The error happened. Don't let the user know becuase he doesn't need to.
            }
        }

        private void dtgrd_Inventory_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
        }


        #endregion

        private void updateTime(object sender, EventArgs e)
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
            string searchMode = cmbbx_searchMode.GetItemText(cmbbx_searchMode.SelectedItem).Replace(" ", "").ToLower();
            if (searchMode == "name")
            {
                ds.Tables["Items"].DefaultView.RowFilter = string.Format("Item LIKE '{0}%'", txtbx_searchBox.Text);
            }
            else if(searchMode == "barcode")
            {
                ds.Tables["Items"].DefaultView.RowFilter = string.Format("Barcode LIKE '{0}%'", txtbx_searchBox.Text);
            }
            else if (searchMode == "price")
            {
                if (txtbx_searchBox.Text.Length >= 3 && txtbx_searchBox.Text.Contains("-"))
                {
                    string[] values = txtbx_searchBox.Text.Split('-');
                    ds.Tables["Items"].DefaultView.RowFilter = string.Format("Price >= {0} and Price <= {1}", values[0], values[1]);
                }
                else
                {

                }
            }

            dtgrd_Inventory.DataSource = ds.Tables["Items"].DefaultView;
        }
        #endregion

        private void dtgrd_Inventory_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            scaleComponents(dtgrd_Inventory);
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dtgrd_Inventory.SelectedRows)
            {
                dtgrd_Inventory.Rows.Remove(row);
            }
        }

        private void dtrgd_POS_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            totalPrice = 0;
            totalQuantity = 0;

            btnG_DeleteItems.Enabled = true;
            btnG_Finalize.Enabled = true;
            btnG_CancelTransaction.Enabled = true;

            foreach (DataGridViewRow row in dtrgd_POS.Rows)
            {
                if (row.Cells[0].Value.ToString() != "TOTAL")
                {
                    totalQuantity += Convert.ToInt32(row.Cells[2].Value);
                    totalPrice += Convert.ToDecimal(row.Cells[3].Value);

                    if (haveSpecificTaxMultiplier)
                    {
                        totalPrice += totalPrice * taxMultiplier;
                    }

                }
            }

            //Display the total cost in terms of Philippine Peso
            txtbx_total.Text = "TOTAL:   " +  totalPrice.ToString("C2", CultureInfo.CreateSpecificCulture("en-PH"));
            lbl_totalItems.Text = string.Format("Total Number of Items: {0}", totalQuantity);
        }

        public void Scan()
        {
            TcpListener server = null;

            Byte[] bytes = new byte[512];
            string serialNumberHolder = string.Empty;

            try
            {
                IPAddress ipAdd = IPAddress.Parse(IPAddressHolder);
                server = new TcpListener(ipAdd, PortNumber);
                server.Start();

                TcpClient client = server.AcceptTcpClient();

                NetworkStream stream = client.GetStream();

                int i;

                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    serialNumberHolder = Encoding.ASCII.GetString(bytes, 0, i);
                    searchForItem(serialNumberHolder);
                }

                client.Close();
            }
            catch (SocketException ex)
            {

            }
            finally
            {
                server.Stop();
                isScanning = false;
                btn_startScan.Invoke(new MethodInvoker(delegate { btnG_StartScanning.Enabled = true; }));
                btn_startScan.Invoke(new MethodInvoker(delegate { btnG_StartScanning.Label = string.Format("{0}\n{1}", "START", "SCANNING"); }));
            }
            //bring me back

        }

        private void lstbx_transactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = lstbx_transactions.SelectedItem;
            if(lstbx_transactions.SelectedIndex > -1)
            {
                bindDatasource(dtgrd_transactions, lstbx_transactions.SelectedItem.ToString());
            }
        }

        public void printReceipt(DataGridView grid)
        {

        }

        private void btnG_Finalize_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to finalize this transaction?", "Finalize Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                transactionCounter++;
                tableName = string.Format("[TRANSACTION-{0}({1})]", DateTime.Now.ToString("MM-dd-yyyy-hh-mm"), transactionCounter);
                dtrgd_POS.Rows.Add(new object[] { "TOTAL", string.Empty, totalQuantity.ToString(), totalPrice.ToString() });
                buildDataTable(dtrgd_POS, dt, tableName);

                //Reset everything that is involved in the transaction process.
                totalQuantity = 0;
                dtrgd_POS.Rows.Clear();
                dtrgd_POS.Refresh();
                lbl_totalItems.Text = string.Format("Total Number of Items: {0}", totalQuantity);
                txtbx_total.Text = "TOTAL     ₱0.00";

                //Update the list of previous transactions
                listPreviousTransactions();
                
                //Disable controls that are related to the transaction process as the grid is empty.
                btnG_DeleteItems.Enabled = false;
                btnG_Finalize.Enabled = false;
                btnG_CancelTransaction.Enabled = false;
            }
            else
            {
                //making sure nothing happens. 
            }
        }

        private void btnG_CancelTransaction_Load(object sender, EventArgs e)
        {
            btnG_CancelTransaction.Label = string.Format("{0}\n{1}", "CANCEL", "TRANSACTION");
        }

        private void btnG_CancelTransaction_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to cancel this transaction?", "Cancel Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                totalQuantity = 0;
                dtrgd_POS.Rows.Clear();
                dtrgd_POS.Refresh();
                lbl_totalItems.Text = string.Format("Total Number of Items: {0}", totalQuantity);
                txtbx_total.Text = "TOTAL     ₱0.00";

                btnG_DeleteItems.Enabled = false;
                btnG_Finalize.Enabled = false;
                btnG_CancelTransaction.Enabled = false;
            }
            else
            {
                //Just making sure nothing happens.
            }
        }

        private void btnG_Finalize_Load(object sender, EventArgs e)
        {
            btnG_Finalize.Label = string.Format("{0}\n{1}", "FINALIZE", "TRANSACTION");
        }

        private void btnG_DeleteItems_Load(object sender, EventArgs e)
        {
            btnG_DeleteItems.Label = string.Format("{0}\n{1}", "DELETE", "ITEM(S)");
        }

        private void btnG_TaxMultiplier_Load(object sender, EventArgs e)
        {
            btnG_TaxMultiplier.Label = string.Format("{0}\n{1}", "TAX", "MULTIPLIER");
        }

        private void btnG_TaxMultiplier_Click(object sender, EventArgs e)
        {
            haveSpecificTaxMultiplier = false;
            FRM_TaxSettings taxSetFrm = new FRM_TaxSettings(this);
            taxSetFrm.ShowDialog();
            if (haveSpecificTaxMultiplier)
            {
                lbl_CurrentTaxMult.Text = string.Format("Current Tax Multiplier:{0}%", (taxMultiplier*100).ToString());
            }
            else
            {
                lbl_CurrentTaxMult.Text = string.Format("Current Tax Multiplier:{0}", "Not Set");
            }
        }

        private void btnG_Quantity_Click(object sender, EventArgs e)
        {
            FRM_Quantity quantityFrm = new FRM_Quantity(this);
            quantityFrm.ShowDialog();
        }

        private void btnG_ScannerSettings_Load(object sender, EventArgs e)
        {
            btnG_ScannerSettings.Label = string.Format("{0}\n{1}", "SCANNER", "SETTINGS");
        }

        private void btnG_ScannerSettings_Click(object sender, EventArgs e)
        {
            if (scannerSettingsAreSet)
            {
                DialogResult dialogResult = MessageBox.Show("You have previously specified the settings to be used for your external barcode scanner. Do you wish to set them again?", "Set Scanner Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    FRM_IPAddSettings frm_IpAddSettings = new FRM_IPAddSettings(this);
                    frm_IpAddSettings.ShowDialog();
                    if (scannerSettingsAreSet)
                    {
                        btnG_StartScanning.Enabled = true;
                        ststrplbl_Port.Text = string.Format("Port: {0}", PortNumber);
                        ststrplbl_IP.Text = string.Format("I.P. Address: {0}", IPAddressHolder);
                    }
                    else
                    {
                        btnG_StartScanning.Enabled = false;
                        ststrplbl_Port.Text = string.Format("Port: {0}", "Not Set");
                        ststrplbl_IP.Text = string.Format("I.P. Address: {0}", "Not Set");
                    }
                }
                else
                {
                    //just making sure nothing happens.
                }
            }
            else
            {
                FRM_IPAddSettings frm_IpAddSettings = new FRM_IPAddSettings(this);
                frm_IpAddSettings.ShowDialog();

                if (scannerSettingsAreSet)
                {
                    btnG_StartScanning.Enabled = true;
                    ststrplbl_Port.Text = string.Format("Port: {0}", PortNumber);
                    ststrplbl_IP.Text = string.Format("I.P. Address: {0}", IPAddressHolder);
                }
                else
                {
                    btnG_StartScanning.Enabled = false;
                    ststrplbl_Port.Text = string.Format("Port: {0}", "Not Set");
                    ststrplbl_IP.Text = string.Format("I.P. Address: {0}", "Not Set");
                }
            }
        }

        private void btnG_StartScanning_Load(object sender, EventArgs e)
        {
            btnG_StartScanning.Label = string.Format("{0}\n{1}", "START", "SCANNING");
        }

        private async void btnG_StartScanning_Click(object sender, EventArgs e)
        {
            /*Return control to the caller until the scanning process is completed.
            This will keep the UI functional while any received data is being pro-
            cessed.*/
            await Task.Run(() =>
            {
                isScanning = true;
                while (isScanning)
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
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete the selected items?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow selectedRow in dtrgd_POS.SelectedRows)
                {
                    dtrgd_POS.Rows.Remove(selectedRow);
                }
            }
            else
            {
                //do nothing.
            }
        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            Db.UpdateDataset(ds, "Items");
            bindDatasource(dtgrd_Inventory, "Items");
            scaleComponents(dtgrd_Inventory);
        }

        /// <summary>
        /// Search the database using the specified serial number.
        /// </summary>
        /// <param name="serialNumber">The item's serial number.</param>
        public void searchForItem(string serialNumber)
        {
            object[] items = null;

            string command = "SELECT * FROM Items WHERE Barcode=@code";

            string barcode = string.Empty, itemName = string.Empty;
            double itemPrice = 0, computedPrice = 0;

            using (sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                sqlComm = new SqlCommand(command,sqlConnection);
                sqlComm.Parameters.AddWithValue("@code", serialNumber);
                reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    barcode = reader["Barcode"].ToString();
                    itemName = reader["Item"].ToString();
                    itemPrice = Convert.ToDouble(reader["Price"].ToString());
                }

                if (specified_Quantity)
                {
                    computedPrice = Convert.ToDouble(specificQuantity) * itemPrice;
                    items = new object[] { barcode, itemName, specificQuantity.ToString(), computedPrice.ToString() };
                    specified_Quantity = false;
                }
                else
                {
                    
                    items = new object[] { barcode, itemName, "1", itemPrice.ToString() };
                }

                dtrgd_POS.Invoke(new MethodInvoker(delegate { dtrgd_POS.Rows.Add(items); }));

                //dtrgd_POS.Invoke(new MethodInvoker(delegate { dtrgd_POS.DataSource = dt; }));
                //dtrgd_POS.Rows.Add(items);
            }
        }

        public void buildDataTable(DataGridView grid, DataTable table, string tableName) 
        {
            var brcd = string.Empty;
            var itm = string.Empty;
            var qnty = string.Empty;
            var prc = string.Empty;
            object[] items = null;

            Db.CreateTable(tableName, "ID", "int Identity(1,1) PRIMARY KEY", "Barcode", "varchar(255)", "Item", "varchar(255)", "Quantity", "varchar(255)", "Price", "varchar(255)");

            dt = new DataTable(tableName);
            dt.Columns.Add("Barcode", Type.GetType("System.String"));
            dt.Columns.Add("Item", Type.GetType("System.String"));
            dt.Columns.Add("Quantity", Type.GetType("System.String"));
            dt.Columns.Add("Price", Type.GetType("System.String"));

            foreach (DataGridViewRow row in grid.Rows)
            {
                brcd = row.Cells[0].Value.ToString();
                itm = row.Cells[1].Value.ToString();
                qnty = row.Cells[2].Value.ToString();
                prc = row.Cells[3].Value.ToString();
                items = new object[] { brcd, itm, qnty, prc };
                dt.Rows.Add(items);
            }

            ds.Tables.Add(dt);
            Db.UpdateDataset(ds, tableName);
        }

        public void listPreviousTransactions()
        {
            lstbx_transactions.Items.Clear();
            string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
            using (sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                using(sqlComm = new SqlCommand(query,sqlConnection))
                {
                    using(reader = sqlComm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string filter = reader["TABLE_NAME"].ToString();
                            if (filter.Contains("TRANSACTION"))
                            {
                                lstbx_transactions.Items.Add(filter);
                            }
                        }
                    }
                }
            }

        }
    }
}
