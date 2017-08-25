namespace _POS
{
    partial class FRM_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ststrplbl_Datetime = new System.Windows.Forms.ToolStripStatusLabel();
            this.ststrplbl_Port = new System.Windows.Forms.ToolStripStatusLabel();
            this.ststrplbl_IP = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tbctrl_POS = new System.Windows.Forms.TabControl();
            this.Inventory = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbbx_searchMode = new System.Windows.Forms.ComboBox();
            this.txtbx_searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpbx_DBActions = new System.Windows.Forms.GroupBox();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_commit = new System.Windows.Forms.Button();
            this.dtgrd_Inventory = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POS = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbx_total = new System.Windows.Forms.TextBox();
            this.btn_setScanner = new System.Windows.Forms.Button();
            this.btn_startScan = new System.Windows.Forms.Button();
            this.grpbx_summary = new System.Windows.Forms.GroupBox();
            this.lbl_totalItems = new System.Windows.Forms.Label();
            this.btn_cancelTransaction = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_quantity = new System.Windows.Forms.Button();
            this.btn_finalize = new System.Windows.Forms.Button();
            this.dtrgd_POS = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.History = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbbx_searchCategory = new System.Windows.Forms.ComboBox();
            this.txtbx_searchKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbx_transactionList = new System.Windows.Forms.GroupBox();
            this.lstbx_transactions = new System.Windows.Forms.ListBox();
            this.dtgrd_transactions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.Tbctrl_POS.SuspendLayout();
            this.Inventory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpbx_DBActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_Inventory)).BeginInit();
            this.POS.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpbx_summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtrgd_POS)).BeginInit();
            this.History.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpbx_transactionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ststrplbl_Datetime,
            this.ststrplbl_Port,
            this.ststrplbl_IP});
            this.statusStrip1.Location = new System.Drawing.Point(0, 627);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1017, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ststrplbl_Datetime
            // 
            this.ststrplbl_Datetime.Name = "ststrplbl_Datetime";
            this.ststrplbl_Datetime.Size = new System.Drawing.Size(92, 25);
            this.ststrplbl_Datetime.Text = "Date Time";
            // 
            // ststrplbl_Port
            // 
            this.ststrplbl_Port.Name = "ststrplbl_Port";
            this.ststrplbl_Port.Size = new System.Drawing.Size(44, 25);
            this.ststrplbl_Port.Text = "Port";
            // 
            // ststrplbl_IP
            // 
            this.ststrplbl_IP.Name = "ststrplbl_IP";
            this.ststrplbl_IP.Size = new System.Drawing.Size(97, 25);
            this.ststrplbl_IP.Text = "IP Address";
            // 
            // Tbctrl_POS
            // 
            this.Tbctrl_POS.Controls.Add(this.Inventory);
            this.Tbctrl_POS.Controls.Add(this.POS);
            this.Tbctrl_POS.Controls.Add(this.History);
            this.Tbctrl_POS.Location = new System.Drawing.Point(0, 5);
            this.Tbctrl_POS.Name = "Tbctrl_POS";
            this.Tbctrl_POS.SelectedIndex = 0;
            this.Tbctrl_POS.Size = new System.Drawing.Size(1016, 625);
            this.Tbctrl_POS.TabIndex = 2;
            // 
            // Inventory
            // 
            this.Inventory.Controls.Add(this.groupBox1);
            this.Inventory.Controls.Add(this.grpbx_DBActions);
            this.Inventory.Controls.Add(this.dtgrd_Inventory);
            this.Inventory.Location = new System.Drawing.Point(4, 29);
            this.Inventory.Name = "Inventory";
            this.Inventory.Padding = new System.Windows.Forms.Padding(3);
            this.Inventory.Size = new System.Drawing.Size(1008, 592);
            this.Inventory.TabIndex = 0;
            this.Inventory.Text = "Inventory";
            this.Inventory.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbbx_searchMode);
            this.groupBox1.Controls.Add(this.txtbx_searchBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // cmbbx_searchMode
            // 
            this.cmbbx_searchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_searchMode.FormattingEnabled = true;
            this.cmbbx_searchMode.Items.AddRange(new object[] {
            "Name",
            "Barcode",
            "Price"});
            this.cmbbx_searchMode.Location = new System.Drawing.Point(13, 48);
            this.cmbbx_searchMode.Name = "cmbbx_searchMode";
            this.cmbbx_searchMode.Size = new System.Drawing.Size(256, 28);
            this.cmbbx_searchMode.TabIndex = 8;
            this.cmbbx_searchMode.SelectedIndexChanged += new System.EventHandler(this.cmbbx_searchMode_SelectedIndexChanged);
            // 
            // txtbx_searchBox
            // 
            this.txtbx_searchBox.Location = new System.Drawing.Point(13, 84);
            this.txtbx_searchBox.Name = "txtbx_searchBox";
            this.txtbx_searchBox.Size = new System.Drawing.Size(256, 26);
            this.txtbx_searchBox.TabIndex = 7;
            this.txtbx_searchBox.TextChanged += new System.EventHandler(this.txtbx_searchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search By:";
            // 
            // grpbx_DBActions
            // 
            this.grpbx_DBActions.Controls.Add(this.btn_Del);
            this.grpbx_DBActions.Controls.Add(this.btn_commit);
            this.grpbx_DBActions.Location = new System.Drawing.Point(10, 147);
            this.grpbx_DBActions.Name = "grpbx_DBActions";
            this.grpbx_DBActions.Size = new System.Drawing.Size(269, 117);
            this.grpbx_DBActions.TabIndex = 2;
            this.grpbx_DBActions.TabStop = false;
            this.grpbx_DBActions.Text = "Actions";
            // 
            // btn_Del
            // 
            this.btn_Del.Image = global::_POS.Properties.Resources.DeleteCell_16x;
            this.btn_Del.Location = new System.Drawing.Point(95, 37);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(69, 64);
            this.btn_Del.TabIndex = 2;
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_commit
            // 
            this.btn_commit.Image = global::_POS.Properties.Resources.Save_16x;
            this.btn_commit.Location = new System.Drawing.Point(20, 37);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(69, 64);
            this.btn_commit.TabIndex = 1;
            this.btn_commit.UseVisualStyleBackColor = true;
            this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
            // 
            // dtgrd_Inventory
            // 
            this.dtgrd_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Barcode,
            this.Item,
            this.Price,
            this.Quantity});
            this.dtgrd_Inventory.Location = new System.Drawing.Point(308, 6);
            this.dtgrd_Inventory.Name = "dtgrd_Inventory";
            this.dtgrd_Inventory.RowTemplate.Height = 28;
            this.dtgrd_Inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrd_Inventory.Size = new System.Drawing.Size(694, 580);
            this.dtgrd_Inventory.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // POS
            // 
            this.POS.Controls.Add(this.panel1);
            this.POS.Controls.Add(this.btn_setScanner);
            this.POS.Controls.Add(this.btn_startScan);
            this.POS.Controls.Add(this.grpbx_summary);
            this.POS.Controls.Add(this.btn_cancelTransaction);
            this.POS.Controls.Add(this.btn_delete);
            this.POS.Controls.Add(this.btn_quantity);
            this.POS.Controls.Add(this.btn_finalize);
            this.POS.Controls.Add(this.dtrgd_POS);
            this.POS.Location = new System.Drawing.Point(4, 29);
            this.POS.Name = "POS";
            this.POS.Padding = new System.Windows.Forms.Padding(3);
            this.POS.Size = new System.Drawing.Size(1008, 592);
            this.POS.TabIndex = 1;
            this.POS.Text = "Point Of Sale";
            this.POS.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtbx_total);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 94);
            this.panel1.TabIndex = 16;
            // 
            // txtbx_total
            // 
            this.txtbx_total.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtbx_total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_total.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_total.ForeColor = System.Drawing.Color.Lime;
            this.txtbx_total.Location = new System.Drawing.Point(-7, 19);
            this.txtbx_total.Name = "txtbx_total";
            this.txtbx_total.Size = new System.Drawing.Size(682, 61);
            this.txtbx_total.TabIndex = 11;
            this.txtbx_total.Text = "TOTAL     ₱0.00";
            this.txtbx_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_setScanner
            // 
            this.btn_setScanner.Location = new System.Drawing.Point(697, 280);
            this.btn_setScanner.Name = "btn_setScanner";
            this.btn_setScanner.Size = new System.Drawing.Size(150, 132);
            this.btn_setScanner.TabIndex = 14;
            this.btn_setScanner.Text = "SCNNER SETTINGS";
            this.btn_setScanner.UseVisualStyleBackColor = true;
            this.btn_setScanner.Click += new System.EventHandler(this.btn_setScanner_Click);
            // 
            // btn_startScan
            // 
            this.btn_startScan.Enabled = false;
            this.btn_startScan.Location = new System.Drawing.Point(852, 280);
            this.btn_startScan.Name = "btn_startScan";
            this.btn_startScan.Size = new System.Drawing.Size(150, 132);
            this.btn_startScan.TabIndex = 13;
            this.btn_startScan.Text = "START SCANNING";
            this.btn_startScan.UseVisualStyleBackColor = true;
            this.btn_startScan.Click += new System.EventHandler(this.btn_startScan_Click);
            // 
            // grpbx_summary
            // 
            this.grpbx_summary.Controls.Add(this.lbl_totalItems);
            this.grpbx_summary.Location = new System.Drawing.Point(696, 427);
            this.grpbx_summary.Name = "grpbx_summary";
            this.grpbx_summary.Size = new System.Drawing.Size(309, 76);
            this.grpbx_summary.TabIndex = 12;
            this.grpbx_summary.TabStop = false;
            this.grpbx_summary.Text = "Additional Details";
            // 
            // lbl_totalItems
            // 
            this.lbl_totalItems.AutoSize = true;
            this.lbl_totalItems.Location = new System.Drawing.Point(21, 38);
            this.lbl_totalItems.Name = "lbl_totalItems";
            this.lbl_totalItems.Size = new System.Drawing.Size(143, 20);
            this.lbl_totalItems.TabIndex = 0;
            this.lbl_totalItems.Text = "Total No. of Items:-";
            // 
            // btn_cancelTransaction
            // 
            this.btn_cancelTransaction.Location = new System.Drawing.Point(852, 4);
            this.btn_cancelTransaction.Name = "btn_cancelTransaction";
            this.btn_cancelTransaction.Size = new System.Drawing.Size(150, 132);
            this.btn_cancelTransaction.TabIndex = 10;
            this.btn_cancelTransaction.Text = "CANCEL TRANSACTION";
            this.btn_cancelTransaction.UseVisualStyleBackColor = true;
            this.btn_cancelTransaction.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(852, 142);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 132);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "DELETE ITEM(S)";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_quantity
            // 
            this.btn_quantity.Location = new System.Drawing.Point(697, 142);
            this.btn_quantity.Name = "btn_quantity";
            this.btn_quantity.Size = new System.Drawing.Size(150, 132);
            this.btn_quantity.TabIndex = 8;
            this.btn_quantity.Text = "QUANTITY";
            this.btn_quantity.UseVisualStyleBackColor = true;
            this.btn_quantity.Click += new System.EventHandler(this.btn_quantity_Click);
            // 
            // btn_finalize
            // 
            this.btn_finalize.Location = new System.Drawing.Point(697, 4);
            this.btn_finalize.Name = "btn_finalize";
            this.btn_finalize.Size = new System.Drawing.Size(150, 132);
            this.btn_finalize.TabIndex = 7;
            this.btn_finalize.Text = "FINALIZE TRANSACTION";
            this.btn_finalize.UseVisualStyleBackColor = true;
            this.btn_finalize.Click += new System.EventHandler(this.btn_finalize_Click);
            // 
            // dtrgd_POS
            // 
            this.dtrgd_POS.AllowUserToAddRows = false;
            this.dtrgd_POS.AllowUserToDeleteRows = false;
            this.dtrgd_POS.AllowUserToOrderColumns = true;
            this.dtrgd_POS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtrgd_POS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtrgd_POS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtrgd_POS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.dtrgd_POS.Location = new System.Drawing.Point(7, 106);
            this.dtrgd_POS.Name = "dtrgd_POS";
            this.dtrgd_POS.RowTemplate.Height = 28;
            this.dtrgd_POS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtrgd_POS.Size = new System.Drawing.Size(683, 480);
            this.dtrgd_POS.TabIndex = 3;
            this.dtrgd_POS.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtrgd_POS_RowsAdded);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Barcode";
            this.dataGridViewTextBoxColumn1.HeaderText = "Barcode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // History
            // 
            this.History.Controls.Add(this.groupBox3);
            this.History.Controls.Add(this.grpbx_transactionList);
            this.History.Controls.Add(this.dtgrd_transactions);
            this.History.Location = new System.Drawing.Point(4, 29);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(3);
            this.History.Size = new System.Drawing.Size(1008, 592);
            this.History.TabIndex = 2;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbbx_searchCategory);
            this.groupBox3.Controls.Add(this.txtbx_searchKey);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(7, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 121);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // cmbbx_searchCategory
            // 
            this.cmbbx_searchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_searchCategory.FormattingEnabled = true;
            this.cmbbx_searchCategory.Items.AddRange(new object[] {
            "Name",
            "Barcode",
            "Price"});
            this.cmbbx_searchCategory.Location = new System.Drawing.Point(13, 48);
            this.cmbbx_searchCategory.Name = "cmbbx_searchCategory";
            this.cmbbx_searchCategory.Size = new System.Drawing.Size(256, 28);
            this.cmbbx_searchCategory.TabIndex = 8;
            // 
            // txtbx_searchKey
            // 
            this.txtbx_searchKey.Location = new System.Drawing.Point(13, 84);
            this.txtbx_searchKey.Name = "txtbx_searchKey";
            this.txtbx_searchKey.Size = new System.Drawing.Size(256, 26);
            this.txtbx_searchKey.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search By:";
            // 
            // grpbx_transactionList
            // 
            this.grpbx_transactionList.Controls.Add(this.lstbx_transactions);
            this.grpbx_transactionList.Location = new System.Drawing.Point(6, 155);
            this.grpbx_transactionList.Name = "grpbx_transactionList";
            this.grpbx_transactionList.Size = new System.Drawing.Size(284, 430);
            this.grpbx_transactionList.TabIndex = 2;
            this.grpbx_transactionList.TabStop = false;
            this.grpbx_transactionList.Text = "Transactions";
            // 
            // lstbx_transactions
            // 
            this.lstbx_transactions.FormattingEnabled = true;
            this.lstbx_transactions.ItemHeight = 20;
            this.lstbx_transactions.Location = new System.Drawing.Point(6, 25);
            this.lstbx_transactions.Name = "lstbx_transactions";
            this.lstbx_transactions.Size = new System.Drawing.Size(272, 404);
            this.lstbx_transactions.TabIndex = 0;
            this.lstbx_transactions.Click += new System.EventHandler(this.lstbx_transactions_SelectedIndexChanged);
            // 
            // dtgrd_transactions
            // 
            this.dtgrd_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dtgrd_transactions.Location = new System.Drawing.Point(306, 11);
            this.dtgrd_transactions.Name = "dtgrd_transactions";
            this.dtgrd_transactions.RowTemplate.Height = 28;
            this.dtgrd_transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrd_transactions.Size = new System.Drawing.Size(694, 576);
            this.dtgrd_transactions.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 62;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Barcode";
            this.dataGridViewTextBoxColumn6.HeaderText = "Barcode";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 105;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn7.HeaderText = "Item";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 77;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn8.HeaderText = "Price";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn9.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 104;
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1017, 657);
            this.Controls.Add(this.Tbctrl_POS);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AAAAAAAAAAA FUCK.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Tbctrl_POS.ResumeLayout(false);
            this.Inventory.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbx_DBActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_Inventory)).EndInit();
            this.POS.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpbx_summary.ResumeLayout(false);
            this.grpbx_summary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtrgd_POS)).EndInit();
            this.History.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpbx_transactionList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_transactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ststrplbl_Datetime;
        private System.Windows.Forms.TabControl Tbctrl_POS;
        private System.Windows.Forms.TabPage Inventory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbbx_searchMode;
        private System.Windows.Forms.TextBox txtbx_searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpbx_DBActions;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_commit;
        private System.Windows.Forms.DataGridView dtgrd_Inventory;
        private System.Windows.Forms.TabPage POS;
        private System.Windows.Forms.Button btn_setScanner;
        private System.Windows.Forms.Button btn_startScan;
        private System.Windows.Forms.GroupBox grpbx_summary;
        private System.Windows.Forms.Label lbl_totalItems;
        private System.Windows.Forms.TextBox txtbx_total;
        private System.Windows.Forms.Button btn_cancelTransaction;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_quantity;
        private System.Windows.Forms.Button btn_finalize;
        private System.Windows.Forms.DataGridView dtrgd_POS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabPage History;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbbx_searchCategory;
        private System.Windows.Forms.TextBox txtbx_searchKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbx_transactionList;
        private System.Windows.Forms.ListBox lstbx_transactions;
        private System.Windows.Forms.DataGridView dtgrd_transactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.ToolStripStatusLabel ststrplbl_Port;
        private System.Windows.Forms.ToolStripStatusLabel ststrplbl_IP;
        private System.Windows.Forms.Panel panel1;
    }
}

