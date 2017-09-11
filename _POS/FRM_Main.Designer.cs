namespace _POS
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnG_Quantity = new _POS.btnG_Quantity();
            this.btnG_TaxMultiplier = new _POS.btnG_TaxMultiplier();
            this.btnG_DeleteItems = new _POS.btnG_DeleteItems();
            this.btn_startScan = new _POS.btnG_StartScanning();
            this.btnG_ScannerSettings = new _POS.btnG_ScannerSettings();
            this.btnG_CancelTransaction = new _POS.btnG_CancelTransaction();
            this.btnG_Placeholder1 = new _POS.btnG_Placeholder();
            this.btnG_Finalize = new _POS.btnG_Finalize();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbx_total = new System.Windows.Forms.TextBox();
            this.grpbx_summary = new System.Windows.Forms.GroupBox();
            this.lbl_CurrentTaxMult = new System.Windows.Forms.Label();
            this.lbl_totalItems = new System.Windows.Forms.Label();
            this.dtrgd_POS = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.History = new System.Windows.Forms.TabPage();
            this.grpbx_transactionList = new System.Windows.Forms.GroupBox();
            this.btn_DeleteTransaction = new _POS.btnG_CancelTransaction();
            this.btn_PrintTransaction = new _POS.btnG_Finalize();
            this.lstbx_transactions = new System.Windows.Forms.ListBox();
            this.dtgrd_transactions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.grpbx_transactionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(53)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ststrplbl_Datetime,
            this.ststrplbl_Port,
            this.ststrplbl_IP});
            this.statusStrip1.Location = new System.Drawing.Point(0, 608);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1011, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ststrplbl_Datetime
            // 
            this.ststrplbl_Datetime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ststrplbl_Datetime.Name = "ststrplbl_Datetime";
            this.ststrplbl_Datetime.Size = new System.Drawing.Size(92, 25);
            this.ststrplbl_Datetime.Text = "Date Time";
            // 
            // ststrplbl_Port
            // 
            this.ststrplbl_Port.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ststrplbl_Port.Name = "ststrplbl_Port";
            this.ststrplbl_Port.Size = new System.Drawing.Size(44, 25);
            this.ststrplbl_Port.Text = "Port";
            // 
            // ststrplbl_IP
            // 
            this.ststrplbl_IP.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            this.Tbctrl_POS.Size = new System.Drawing.Size(1017, 600);
            this.Tbctrl_POS.TabIndex = 2;
            this.Tbctrl_POS.SelectedIndexChanged += new System.EventHandler(this.Tbctrl_POS_SelectedIndexChanged);
            this.Tbctrl_POS.Click += new System.EventHandler(this.Tbctrl_POS_Click);
            // 
            // Inventory
            // 
            this.Inventory.Controls.Add(this.groupBox1);
            this.Inventory.Controls.Add(this.grpbx_DBActions);
            this.Inventory.Controls.Add(this.dtgrd_Inventory);
            this.Inventory.Location = new System.Drawing.Point(4, 29);
            this.Inventory.Name = "Inventory";
            this.Inventory.Padding = new System.Windows.Forms.Padding(3);
            this.Inventory.Size = new System.Drawing.Size(1009, 567);
            this.Inventory.TabIndex = 0;
            this.Inventory.Text = "Inventory";
            this.Inventory.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbbx_searchMode);
            this.groupBox1.Controls.Add(this.txtbx_searchBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 130);
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
            "Barcode"});
            this.cmbbx_searchMode.Location = new System.Drawing.Point(14, 48);
            this.cmbbx_searchMode.Name = "cmbbx_searchMode";
            this.cmbbx_searchMode.Size = new System.Drawing.Size(256, 28);
            this.cmbbx_searchMode.TabIndex = 8;
            this.cmbbx_searchMode.SelectedIndexChanged += new System.EventHandler(this.cmbbx_searchMode_SelectedIndexChanged);
            // 
            // txtbx_searchBox
            // 
            this.txtbx_searchBox.Location = new System.Drawing.Point(14, 85);
            this.txtbx_searchBox.Name = "txtbx_searchBox";
            this.txtbx_searchBox.Size = new System.Drawing.Size(256, 26);
            this.txtbx_searchBox.TabIndex = 7;
            this.txtbx_searchBox.TextChanged += new System.EventHandler(this.txtbx_searchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search By:";
            // 
            // grpbx_DBActions
            // 
            this.grpbx_DBActions.Controls.Add(this.btn_Del);
            this.grpbx_DBActions.Controls.Add(this.btn_commit);
            this.grpbx_DBActions.Location = new System.Drawing.Point(10, 142);
            this.grpbx_DBActions.Name = "grpbx_DBActions";
            this.grpbx_DBActions.Size = new System.Drawing.Size(284, 102);
            this.grpbx_DBActions.TabIndex = 2;
            this.grpbx_DBActions.TabStop = false;
            this.grpbx_DBActions.Text = "Actions";
            // 
            // btn_Del
            // 
            this.btn_Del.Image = ((System.Drawing.Image)(resources.GetObject("btn_Del.Image")));
            this.btn_Del.Location = new System.Drawing.Point(88, 26);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(69, 65);
            this.btn_Del.TabIndex = 2;
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_commit
            // 
            this.btn_commit.Image = ((System.Drawing.Image)(resources.GetObject("btn_commit.Image")));
            this.btn_commit.Location = new System.Drawing.Point(14, 26);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(69, 65);
            this.btn_commit.TabIndex = 1;
            this.btn_commit.UseVisualStyleBackColor = true;
            this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
            // 
            // dtgrd_Inventory
            // 
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dtgrd_Inventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_Inventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dtgrd_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Barcode,
            this.Item,
            this.Price,
            this.Quantity});
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrd_Inventory.DefaultCellStyle = dataGridViewCellStyle37;
            this.dtgrd_Inventory.GridColor = System.Drawing.Color.DarkOrange;
            this.dtgrd_Inventory.Location = new System.Drawing.Point(308, 6);
            this.dtgrd_Inventory.Name = "dtgrd_Inventory";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_Inventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dtgrd_Inventory.RowTemplate.Height = 28;
            this.dtgrd_Inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrd_Inventory.Size = new System.Drawing.Size(693, 547);
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
            dataGridViewCellStyle36.Format = "C2";
            dataGridViewCellStyle36.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle36;
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
            this.POS.Controls.Add(this.btnG_Quantity);
            this.POS.Controls.Add(this.btnG_TaxMultiplier);
            this.POS.Controls.Add(this.btnG_DeleteItems);
            this.POS.Controls.Add(this.btn_startScan);
            this.POS.Controls.Add(this.btnG_ScannerSettings);
            this.POS.Controls.Add(this.btnG_CancelTransaction);
            this.POS.Controls.Add(this.btnG_Placeholder1);
            this.POS.Controls.Add(this.btnG_Finalize);
            this.POS.Controls.Add(this.panel1);
            this.POS.Controls.Add(this.grpbx_summary);
            this.POS.Controls.Add(this.dtrgd_POS);
            this.POS.Location = new System.Drawing.Point(4, 29);
            this.POS.Name = "POS";
            this.POS.Padding = new System.Windows.Forms.Padding(3);
            this.POS.Size = new System.Drawing.Size(1009, 567);
            this.POS.TabIndex = 1;
            this.POS.Text = "Point Of Sale";
            this.POS.UseVisualStyleBackColor = true;
            // 
            // btnG_Quantity
            // 
            this.btnG_Quantity.BackColor = System.Drawing.Color.OliveDrab;
            this.btnG_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnG_Quantity.Label = "QUANTITY";
            this.btnG_Quantity.Location = new System.Drawing.Point(850, 238);
            this.btnG_Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.btnG_Quantity.Name = "btnG_Quantity";
            this.btnG_Quantity.Size = new System.Drawing.Size(143, 108);
            this.btnG_Quantity.TabIndex = 33;
            this.btnG_Quantity.Click += new System.EventHandler(this.btnG_Quantity_Click);
            // 
            // btnG_TaxMultiplier
            // 
            this.btnG_TaxMultiplier.BackColor = System.Drawing.Color.BlueViolet;
            this.btnG_TaxMultiplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnG_TaxMultiplier.Label = "TAX";
            this.btnG_TaxMultiplier.Location = new System.Drawing.Point(698, 238);
            this.btnG_TaxMultiplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnG_TaxMultiplier.Name = "btnG_TaxMultiplier";
            this.btnG_TaxMultiplier.Size = new System.Drawing.Size(143, 108);
            this.btnG_TaxMultiplier.TabIndex = 32;
            this.btnG_TaxMultiplier.Load += new System.EventHandler(this.btnG_TaxMultiplier_Load);
            this.btnG_TaxMultiplier.Click += new System.EventHandler(this.btnG_TaxMultiplier_Click);
            // 
            // btnG_DeleteItems
            // 
            this.btnG_DeleteItems.BackColor = System.Drawing.Color.Coral;
            this.btnG_DeleteItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnG_DeleteItems.Enabled = false;
            this.btnG_DeleteItems.Label = "DELETE";
            this.btnG_DeleteItems.Location = new System.Drawing.Point(698, 122);
            this.btnG_DeleteItems.Margin = new System.Windows.Forms.Padding(2);
            this.btnG_DeleteItems.Name = "btnG_DeleteItems";
            this.btnG_DeleteItems.Size = new System.Drawing.Size(143, 108);
            this.btnG_DeleteItems.TabIndex = 31;
            this.btnG_DeleteItems.Load += new System.EventHandler(this.btnG_DeleteItems_Load);
            this.btnG_DeleteItems.Click += new System.EventHandler(this.btnG_DeleteItems_Click);
            // 
            // btn_startScan
            // 
            this.btn_startScan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_startScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_startScan.Enabled = false;
            this.btn_startScan.Label = "SCAN";
            this.btn_startScan.Location = new System.Drawing.Point(850, 355);
            this.btn_startScan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_startScan.Name = "btn_startScan";
            this.btn_startScan.Size = new System.Drawing.Size(143, 110);
            this.btn_startScan.TabIndex = 30;
            this.btn_startScan.Load += new System.EventHandler(this.btnG_StartScanning_Load);
            this.btn_startScan.Click += new System.EventHandler(this.btnG_StartScanning_Click);
            // 
            // btnG_ScannerSettings
            // 
            this.btnG_ScannerSettings.BackColor = System.Drawing.Color.Purple;
            this.btnG_ScannerSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnG_ScannerSettings.Label = "SET SCAN";
            this.btnG_ScannerSettings.Location = new System.Drawing.Point(698, 355);
            this.btnG_ScannerSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnG_ScannerSettings.Name = "btnG_ScannerSettings";
            this.btnG_ScannerSettings.Size = new System.Drawing.Size(143, 108);
            this.btnG_ScannerSettings.TabIndex = 29;
            this.btnG_ScannerSettings.Load += new System.EventHandler(this.btnG_ScannerSettings_Load);
            this.btnG_ScannerSettings.Click += new System.EventHandler(this.btnG_ScannerSettings_Click);
            // 
            // btnG_CancelTransaction
            // 
            this.btnG_CancelTransaction.BackColor = System.Drawing.Color.Firebrick;
            this.btnG_CancelTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnG_CancelTransaction.Enabled = false;
            this.btnG_CancelTransaction.Label = "CANCEL";
            this.btnG_CancelTransaction.Location = new System.Drawing.Point(848, 8);
            this.btnG_CancelTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btnG_CancelTransaction.Name = "btnG_CancelTransaction";
            this.btnG_CancelTransaction.Size = new System.Drawing.Size(148, 108);
            this.btnG_CancelTransaction.TabIndex = 28;
            this.btnG_CancelTransaction.Load += new System.EventHandler(this.btnG_CancelTransaction_Load);
            this.btnG_CancelTransaction.Click += new System.EventHandler(this.btnG_CancelTransaction_Click);
            // 
            // btnG_Placeholder1
            // 
            this.btnG_Placeholder1.BackColor = System.Drawing.Color.Chocolate;
            this.btnG_Placeholder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnG_Placeholder1.Enabled = false;
            this.btnG_Placeholder1.Label = "";
            this.btnG_Placeholder1.Location = new System.Drawing.Point(849, 122);
            this.btnG_Placeholder1.Margin = new System.Windows.Forms.Padding(2);
            this.btnG_Placeholder1.Name = "btnG_Placeholder1";
            this.btnG_Placeholder1.Size = new System.Drawing.Size(144, 108);
            this.btnG_Placeholder1.TabIndex = 27;
            // 
            // btnG_Finalize
            // 
            this.btnG_Finalize.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnG_Finalize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnG_Finalize.Enabled = false;
            this.btnG_Finalize.ForeColor = System.Drawing.SystemColors.Info;
            this.btnG_Finalize.Label = "FINALIZE";
            this.btnG_Finalize.Location = new System.Drawing.Point(696, 6);
            this.btnG_Finalize.Margin = new System.Windows.Forms.Padding(2);
            this.btnG_Finalize.Name = "btnG_Finalize";
            this.btnG_Finalize.Size = new System.Drawing.Size(144, 110);
            this.btnG_Finalize.TabIndex = 20;
            this.btnG_Finalize.Load += new System.EventHandler(this.btnG_Finalize_Load);
            this.btnG_Finalize.Click += new System.EventHandler(this.btnG_Finalize_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtbx_total);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 94);
            this.panel1.TabIndex = 16;
            // 
            // txtbx_total
            // 
            this.txtbx_total.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtbx_total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_total.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_total.ForeColor = System.Drawing.Color.Lime;
            this.txtbx_total.Location = new System.Drawing.Point(3, 18);
            this.txtbx_total.Name = "txtbx_total";
            this.txtbx_total.Size = new System.Drawing.Size(674, 61);
            this.txtbx_total.TabIndex = 11;
            this.txtbx_total.Text = "TOTAL     ₱0.00";
            this.txtbx_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpbx_summary
            // 
            this.grpbx_summary.Controls.Add(this.lbl_CurrentTaxMult);
            this.grpbx_summary.Controls.Add(this.lbl_totalItems);
            this.grpbx_summary.Location = new System.Drawing.Point(692, 472);
            this.grpbx_summary.Name = "grpbx_summary";
            this.grpbx_summary.Size = new System.Drawing.Size(301, 83);
            this.grpbx_summary.TabIndex = 12;
            this.grpbx_summary.TabStop = false;
            this.grpbx_summary.Text = "Additional Details";
            // 
            // lbl_CurrentTaxMult
            // 
            this.lbl_CurrentTaxMult.AutoSize = true;
            this.lbl_CurrentTaxMult.Location = new System.Drawing.Point(22, 54);
            this.lbl_CurrentTaxMult.Name = "lbl_CurrentTaxMult";
            this.lbl_CurrentTaxMult.Size = new System.Drawing.Size(170, 20);
            this.lbl_CurrentTaxMult.TabIndex = 1;
            this.lbl_CurrentTaxMult.Text = "Current Tax Multiplier: -";
            // 
            // lbl_totalItems
            // 
            this.lbl_totalItems.AutoSize = true;
            this.lbl_totalItems.Location = new System.Drawing.Point(20, 23);
            this.lbl_totalItems.Name = "lbl_totalItems";
            this.lbl_totalItems.Size = new System.Drawing.Size(200, 20);
            this.lbl_totalItems.TabIndex = 0;
            this.lbl_totalItems.Text = "Current Total No. of Items:-";
            // 
            // dtrgd_POS
            // 
            this.dtrgd_POS.AllowUserToAddRows = false;
            this.dtrgd_POS.AllowUserToDeleteRows = false;
            this.dtrgd_POS.AllowUserToOrderColumns = true;
            this.dtrgd_POS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtrgd_POS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dtrgd_POS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtrgd_POS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtrgd_POS.DefaultCellStyle = dataGridViewCellStyle41;
            this.dtrgd_POS.Location = new System.Drawing.Point(8, 106);
            this.dtrgd_POS.Name = "dtrgd_POS";
            this.dtrgd_POS.RowTemplate.Height = 28;
            this.dtrgd_POS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtrgd_POS.Size = new System.Drawing.Size(680, 449);
            this.dtrgd_POS.TabIndex = 3;
            this.dtrgd_POS.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtrgd_POS_RowsAdded);
            this.dtrgd_POS.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtrgd_POS_RowsRemoved);
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
            dataGridViewCellStyle40.Format = "C2";
            dataGridViewCellStyle40.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // History
            // 
            this.History.Controls.Add(this.grpbx_transactionList);
            this.History.Controls.Add(this.dtgrd_transactions);
            this.History.Location = new System.Drawing.Point(4, 29);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(3);
            this.History.Size = new System.Drawing.Size(1009, 567);
            this.History.TabIndex = 2;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            // 
            // grpbx_transactionList
            // 
            this.grpbx_transactionList.Controls.Add(this.btn_DeleteTransaction);
            this.grpbx_transactionList.Controls.Add(this.btn_PrintTransaction);
            this.grpbx_transactionList.Controls.Add(this.lstbx_transactions);
            this.grpbx_transactionList.Location = new System.Drawing.Point(6, 6);
            this.grpbx_transactionList.Name = "grpbx_transactionList";
            this.grpbx_transactionList.Size = new System.Drawing.Size(284, 553);
            this.grpbx_transactionList.TabIndex = 2;
            this.grpbx_transactionList.TabStop = false;
            this.grpbx_transactionList.Text = "Transactions";
            // 
            // btn_DeleteTransaction
            // 
            this.btn_DeleteTransaction.BackColor = System.Drawing.Color.Firebrick;
            this.btn_DeleteTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_DeleteTransaction.Label = "DELETE";
            this.btn_DeleteTransaction.Location = new System.Drawing.Point(8, 366);
            this.btn_DeleteTransaction.Name = "btn_DeleteTransaction";
            this.btn_DeleteTransaction.Size = new System.Drawing.Size(270, 86);
            this.btn_DeleteTransaction.TabIndex = 2;
            this.btn_DeleteTransaction.Click += new System.EventHandler(this.btn_DeleteTransaction_Click);
            // 
            // btn_PrintTransaction
            // 
            this.btn_PrintTransaction.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_PrintTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_PrintTransaction.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_PrintTransaction.Label = "PRINT";
            this.btn_PrintTransaction.Location = new System.Drawing.Point(8, 457);
            this.btn_PrintTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PrintTransaction.Name = "btn_PrintTransaction";
            this.btn_PrintTransaction.Size = new System.Drawing.Size(272, 87);
            this.btn_PrintTransaction.TabIndex = 1;
            this.btn_PrintTransaction.Click += new System.EventHandler(this.btn_PrintTransaction_Click);
            // 
            // lstbx_transactions
            // 
            this.lstbx_transactions.FormattingEnabled = true;
            this.lstbx_transactions.ItemHeight = 20;
            this.lstbx_transactions.Location = new System.Drawing.Point(6, 24);
            this.lstbx_transactions.Name = "lstbx_transactions";
            this.lstbx_transactions.Size = new System.Drawing.Size(270, 324);
            this.lstbx_transactions.TabIndex = 0;
            this.lstbx_transactions.Click += new System.EventHandler(this.lstbx_transactions_SelectedIndexChanged);
            // 
            // dtgrd_transactions
            // 
            this.dtgrd_transactions.AllowUserToAddRows = false;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtgrd_transactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle42;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_transactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.dtgrd_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrd_transactions.DefaultCellStyle = dataGridViewCellStyle44;
            this.dtgrd_transactions.GridColor = System.Drawing.Color.DarkOrange;
            this.dtgrd_transactions.Location = new System.Drawing.Point(306, 6);
            this.dtgrd_transactions.Name = "dtgrd_transactions";
            this.dtgrd_transactions.ReadOnly = true;
            this.dtgrd_transactions.RowTemplate.Height = 28;
            this.dtgrd_transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrd_transactions.Size = new System.Drawing.Size(693, 553);
            this.dtgrd_transactions.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Barcode";
            this.dataGridViewTextBoxColumn6.HeaderText = "Barcode";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn7.HeaderText = "Item";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn9.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn8.HeaderText = "Price";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1011, 638);
            this.Controls.Add(this.Tbctrl_POS);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1033, 694);
            this.MinimumSize = new System.Drawing.Size(1033, 694);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Village Mini Grocery POS ";
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
        private System.Windows.Forms.GroupBox grpbx_summary;
        private System.Windows.Forms.Label lbl_totalItems;
        private System.Windows.Forms.DataGridView dtrgd_POS;
        private System.Windows.Forms.TabPage History;
        private System.Windows.Forms.GroupBox grpbx_transactionList;
        private System.Windows.Forms.ListBox lstbx_transactions;
        private System.Windows.Forms.DataGridView dtgrd_transactions;
        private System.Windows.Forms.ToolStripStatusLabel ststrplbl_Port;
        private System.Windows.Forms.ToolStripStatusLabel ststrplbl_IP;
        private System.Windows.Forms.Label lbl_CurrentTaxMult;
        private btnG_Finalize btnG_Finalize;
        private btnG_Placeholder btnG_Placeholder1;
        private btnG_CancelTransaction btnG_CancelTransaction;
        private btnG_ScannerSettings btnG_ScannerSettings;
        private btnG_StartScanning btn_startScan;
        private btnG_DeleteItems btnG_DeleteItems;
        private btnG_TaxMultiplier btnG_TaxMultiplier;
        private btnG_Quantity btnG_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbx_total;
        private btnG_Finalize btn_PrintTransaction;
        private btnG_CancelTransaction btn_DeleteTransaction;
    }
}

