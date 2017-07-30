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


namespace _POS
{
    public partial class FRM_Main : Form
    {
        string dir;
        protected string filepath;
        protected string connString;
        DataSet ds;
        SqlDataAdapter da;
        DatabaseOps Db;

        internal int specificQuantity, totalQuantity;
        internal decimal totalPrice;

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

            scaleComponents(dtgrd_Inventory);
        }

        public void scaleComponents(DataGridView grid)
        {
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;


            //Scale the datagridview so that all of its contents are properly shown to the user.
            grid.Width = grid.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) +
            (grid.RowHeadersVisible ? grid.RowHeadersWidth : 0) + 3;


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

            bindDatasource(dtgrd_Inventory);
            scaleComponents(dtgrd_Inventory);

        }

        public void bindDatasource(DataGridView grid)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(connString);
                string command = "SELECT * FROM Items";
                SqlCommand sqlComm = new SqlCommand(command, sqlConn);
                da = new SqlDataAdapter(sqlComm);
                ds = new DataSet();
                da.Fill(ds, "Items");
                grid.DataMember = "Items";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Db.UpdateDataset(ds);
            bindDatasource(dtgrd_Inventory);
            scaleComponents(dtgrd_Inventory);
        }
        #endregion

        private void updateTime(object sender, EventArgs e)
        {
            ststrplbl_Datetime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dtrgd_POS.Rows.Clear();
            dtrgd_POS.Refresh();
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
            foreach(DataGridViewRow row in dtrgd_POS.Rows)
            {
                totalQuantity += Convert.ToInt32(row.Cells["Quantity"].Value);
                totalPrice += Convert.ToDecimal(row.Cells["Price"].Value);
            }

            //Display the total cost in terms of Philippine Peso
            txtbx_total.Text = totalPrice.ToString("C3", CultureInfo.CreateSpecificCulture("en-PH"));

            scaleComponents(dtrgd_POS);
        }
    }
}
