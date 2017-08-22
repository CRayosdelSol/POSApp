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


namespace _POS
{
    public partial class FRM_Main : Form
    {
        string dir;
        protected string filepath;
        protected string connString;
        protected bool isScanning;
        int transactionCounter;

        DataSet ds;
        SqlDataAdapter da;
        DatabaseOps Db;
        SqlDataReader reader;
        SqlConnection sqlConnection;
        SqlCommand sqlComm;




        internal int specificQuantity, totalQuantity;
        internal decimal totalPrice;
        internal string IPAddressHolder;
        internal Int32 PortNumber;
        internal bool specified_Quantity, setScannerSettings;

        public FRM_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            initializeDataGrid();
            dtgrd_Inventory.AutoGenerateColumns = false;
            Timer tmr = new Timer();
            tmr.Interval = 1000; // ticks every 1 second
            tmr.Tick += new EventHandler(updateTime);
            tmr.Start();
            cmbbx_searchMode.SelectedIndex = 0;
            statusStrip1.Text = "OMG";
            scaleComponents(dtgrd_Inventory);
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

            Db.CreateTable("Items", "ID", "int Identity(1,1) PRIMARY KEY", "Barcode", "varchar(255)", "Item", "varchar(255)", "Price", "varchar(255)", "Quantity", "varchar(255)");

            bindDatasource(dtgrd_Inventory,"Items");
            scaleComponents(dtgrd_Inventory);

        }

        public void bindDatasource(DataGridView grid, string tableName)
        {
            try
            {
                sqlConnection = new SqlConnection(connString);
                string command = "SELECT * FROM " + tableName;
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            string tableName = string.Format("TRANSACTION_{0}_{1}", DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"), transactionCounter);
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to cancel this transaction?", "Cancel Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                dtrgd_POS.Rows.Clear();
                dtrgd_POS.Refresh();
                Db.dropTable(tableName);
            }
            else
            {
                //Just making sure nothing happens.
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
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

        private void btn_quantity_Click(object sender, EventArgs e)
        {
            FRM_Quantity quantityFrm = new FRM_Quantity(this);
            quantityFrm.ShowDialog();
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

            foreach(DataGridViewRow row in dtrgd_POS.Rows)
            {
                totalQuantity += Convert.ToInt32(row.Cells[2].Value);
                totalPrice += Convert.ToDecimal(row.Cells[3].Value);
            }

            //Display the total cost in terms of Philippine Peso
            txtbx_total.Text = "TOTAL:   " +  totalPrice.ToString("C2", CultureInfo.CreateSpecificCulture("en-PH"));

            //scaleComponents(dtrgd_POS);

            //TRANSAC_HISTORY_BIT_AL
            //string tableName = string.Format("[TRANSACTION_{0}_{1}]", DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"), transactionCounter+10000);
            //Db.CreateTable(tableName, "ID", "int Identity(1,1) PRIMARY KEY", "Barcode", "varchar(255)", "Item", "varchar(255)", "Price", "varchar(255)", "Quantity", "varchar(255)");
            //bindDatasource(dtrgd_POS, tableName);
            //Db.UpdateDataset(ds,tableName);
        }

        private void btn_setScanner_Click(object sender, EventArgs e)
        {
            FRM_IPAddSettings frm_IpAddSettings = new FRM_IPAddSettings(this);
            frm_IpAddSettings.ShowDialog();
            if (setScannerSettings)
            {
                btn_startScan.Enabled = true;
                ststrplbl_Port.Text = string.Format("Port: {0}", PortNumber);
                ststrplbl_IP.Text = string.Format("I.P. Address: {0}", IPAddressHolder);
            }
            else
            {
                btn_startScan.Enabled = false;
            }
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
                btn_startScan.Invoke(new MethodInvoker(delegate { btn_startScan.Enabled = true; }));
                btn_startScan.Invoke(new MethodInvoker(delegate { btn_startScan.Text = "START SCANNING"; }));
            }


        }

        private async void btn_startScan_Click(object sender, EventArgs e)
        {
            /*Return control to the caller until the scanning process is completed.
            This will keep the UI functional while any received data is being pro-
            cessed.*/
            await Task.Run(() =>
            {
                isScanning = true;
                while (isScanning)
                {
                    btn_startScan.Invoke(new MethodInvoker(delegate { btn_startScan.Enabled = false; }));
                    btn_startScan.Invoke(new MethodInvoker(delegate { btn_startScan.Text = "SCANNING"; }));
                    Scan();
                }
            });
        }

        private void lstbx_transactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = lstbx_transactions.SelectedItem;
            if(lstbx_transactions.SelectedIndex > -1)
            {
                bindDatasource(dtgrd_transactions, lstbx_transactions.SelectedItem.ToString());
            }
        }

        private void btn_finalize_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to finalize this transaction?", "Finalize Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                transactionCounter++;
            }
            else
            {
                //making sure nothing happens. 
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
            string[] items = null;

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
                    items = new string[] { barcode, itemName, specificQuantity.ToString(), computedPrice.ToString() };
                    specified_Quantity = false;
                }
                else
                {
                    
                    items = new string[] { barcode, itemName, "1", itemPrice.ToString() };
                }

                dtrgd_POS.Invoke(new MethodInvoker(delegate { dtrgd_POS.Rows.Add(items); }));
                //dtrgd_POS.Rows.Add(items);
            }
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
