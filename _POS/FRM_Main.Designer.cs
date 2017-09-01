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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lstbx_transactions = new System.Windows.Forms.ListBox();
            this.dtgrd_transactions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbx_total = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.Tbctrl_POS.SuspendLayout();
            this.Inventory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpbx_DBActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_Inventory)).BeginInit();
            this.POS.SuspendLayout();
            this.grpbx_summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtrgd_POS)).BeginInit();
            this.History.SuspendLayout();
            this.grpbx_transactionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_transactions)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(682, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ststrplbl_Datetime
            // 
            this.ststrplbl_Datetime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ststrplbl_Datetime.Name = "ststrplbl_Datetime";
            this.ststrplbl_Datetime.Size = new System.Drawing.Size(61, 17);
            this.ststrplbl_Datetime.Text = "Date Time";
            // 
            // ststrplbl_Port
            // 
            this.ststrplbl_Port.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ststrplbl_Port.Name = "ststrplbl_Port";
            this.ststrplbl_Port.Size = new System.Drawing.Size(29, 17);
            this.ststrplbl_Port.Text = "Port";
            // 
            // ststrplbl_IP
            // 
            this.ststrplbl_IP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ststrplbl_IP.Name = "ststrplbl_IP";
            this.ststrplbl_IP.Size = new System.Drawing.Size(62, 17);
            this.ststrplbl_IP.Text = "IP Address";
            // 
            // Tbctrl_POS
            // 
            this.Tbctrl_POS.Controls.Add(this.Inventory);
            this.Tbctrl_POS.Controls.Add(this.POS);
            this.Tbctrl_POS.Controls.Add(this.History);
            this.Tbctrl_POS.Location = new System.Drawing.Point(0, 3);
            this.Tbctrl_POS.Margin = new System.Windows.Forms.Padding(2);
            this.Tbctrl_POS.Name = "Tbctrl_POS";
            this.Tbctrl_POS.SelectedIndex = 0;
            this.Tbctrl_POS.Size = new System.Drawing.Size(678, 402);
            this.Tbctrl_POS.TabIndex = 2;
            // 
            // Inventory
            // 
            this.Inventory.Controls.Add(this.groupBox1);
            this.Inventory.Controls.Add(this.grpbx_DBActions);
            this.Inventory.Controls.Add(this.dtgrd_Inventory);
            this.Inventory.Location = new System.Drawing.Point(4, 22);
            this.Inventory.Margin = new System.Windows.Forms.Padding(2);
            this.Inventory.Name = "Inventory";
            this.Inventory.Padding = new System.Windows.Forms.Padding(2);
            this.Inventory.Size = new System.Drawing.Size(670, 376);
            this.Inventory.TabIndex = 0;
            this.Inventory.Text = "Inventory";
            this.Inventory.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbbx_searchMode);
            this.groupBox1.Controls.Add(this.txtbx_searchBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(189, 82);
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
            this.cmbbx_searchMode.Location = new System.Drawing.Point(9, 31);
            this.cmbbx_searchMode.Margin = new System.Windows.Forms.Padding(2);
            this.cmbbx_searchMode.Name = "cmbbx_searchMode";
            this.cmbbx_searchMode.Size = new System.Drawing.Size(172, 21);
            this.cmbbx_searchMode.TabIndex = 8;
            this.cmbbx_searchMode.SelectedIndexChanged += new System.EventHandler(this.cmbbx_searchMode_SelectedIndexChanged);
            // 
            // txtbx_searchBox
            // 
            this.txtbx_searchBox.Location = new System.Drawing.Point(9, 55);
            this.txtbx_searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_searchBox.Name = "txtbx_searchBox";
            this.txtbx_searchBox.Size = new System.Drawing.Size(172, 20);
            this.txtbx_searchBox.TabIndex = 7;
            this.txtbx_searchBox.TextChanged += new System.EventHandler(this.txtbx_searchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search By:";
            // 
            // grpbx_DBActions
            // 
            this.grpbx_DBActions.Controls.Add(this.btn_Del);
            this.grpbx_DBActions.Controls.Add(this.btn_commit);
            this.grpbx_DBActions.Location = new System.Drawing.Point(7, 90);
            this.grpbx_DBActions.Margin = new System.Windows.Forms.Padding(2);
            this.grpbx_DBActions.Name = "grpbx_DBActions";
            this.grpbx_DBActions.Padding = new System.Windows.Forms.Padding(2);
            this.grpbx_DBActions.Size = new System.Drawing.Size(189, 66);
            this.grpbx_DBActions.TabIndex = 2;
            this.grpbx_DBActions.TabStop = false;
            this.grpbx_DBActions.Text = "Actions";
            // 
            // btn_Del
            // 
            this.btn_Del.Image = ((System.Drawing.Image)(resources.GetObject("btn_Del.Image")));
            this.btn_Del.Location = new System.Drawing.Point(59, 17);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(46, 42);
            this.btn_Del.TabIndex = 2;
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_commit
            // 
            this.btn_commit.Image = ((System.Drawing.Image)(resources.GetObject("btn_commit.Image")));
            this.btn_commit.Location = new System.Drawing.Point(9, 17);
            this.btn_commit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(46, 42);
            this.btn_commit.TabIndex = 1;
            this.btn_commit.UseVisualStyleBackColor = true;
            this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
            // 
            // dtgrd_Inventory
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dtgrd_Inventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_Inventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgrd_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Barcode,
            this.Item,
            this.Price,
            this.Quantity});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrd_Inventory.DefaultCellStyle = dataGridViewCellStyle18;
            this.dtgrd_Inventory.GridColor = System.Drawing.Color.DarkOrange;
            this.dtgrd_Inventory.Location = new System.Drawing.Point(205, 4);
            this.dtgrd_Inventory.Margin = new System.Windows.Forms.Padding(2);
            this.dtgrd_Inventory.Name = "dtgrd_Inventory";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_Inventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dtgrd_Inventory.RowTemplate.Height = 28;
            this.dtgrd_Inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrd_Inventory.Size = new System.Drawing.Size(462, 368);
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
            dataGridViewCellStyle17.Format = "C2";
            dataGridViewCellStyle17.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle17;
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
            this.POS.Location = new System.Drawing.Point(4, 22);
            this.POS.Margin = new System.Windows.Forms.Padding(2);
            this.POS.Name = "POS";
            this.POS.Padding = new System.Windows.Forms.Padding(2);
            this.POS.Size = new System.Drawing.Size(670, 376);
            this.POS.TabIndex = 1;
            this.POS.Text = "Point Of Sale";
            this.POS.UseVisualStyleBackColor = true;
            // 
            // btnG_Quantity
            // 
            this.btnG_Quantity.BackColor = System.Drawing.Color.OliveDrab;
            this.btnG_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnG_Quantity.Label = "QUANTITY";
            this.btnG_Quantity.Location = new System.Drawing.Point(567, 155);
            this.btnG_Quantity.Margin = new System.Windows.Forms.Padding(1);
            this.btnG_Quantity.Name = "btnG_Quantity";
            this.btnG_Quantity.Size = new System.Drawing.Size(96, 71);
            this.btnG_Quantity.TabIndex = 33;
            this.btnG_Quantity.Click += new System.EventHandler(this.btnG_Quantity_Click);
            // 
            // btnG_TaxMultiplier
            // 
            this.btnG_TaxMultiplier.BackColor = System.Drawing.Color.BlueViolet;
            this.btnG_TaxMultiplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnG_TaxMultiplier.Label = "TAX";
            this.btnG_TaxMultiplier.Location = new System.Drawing.Point(465, 155);
            this.btnG_TaxMultiplier.Margin = new System.Windows.Forms.Padding(1);
            this.btnG_TaxMultiplier.Name = "btnG_TaxMultiplier";
            this.btnG_TaxMultiplier.Size = new System.Drawing.Size(96, 71);
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
            this.btnG_DeleteItems.Location = new System.Drawing.Point(465, 79);
            this.btnG_DeleteItems.Margin = new System.Windows.Forms.Padding(1);
            this.btnG_DeleteItems.Name = "btnG_DeleteItems";
            this.btnG_DeleteItems.Size = new System.Drawing.Size(96, 71);
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
            this.btn_startScan.Location = new System.Drawing.Point(567, 231);
            this.btn_startScan.Margin = new System.Windows.Forms.Padding(1);
            this.btn_startScan.Name = "btn_startScan";
            this.btn_startScan.Size = new System.Drawing.Size(96, 72);
            this.btn_startScan.TabIndex = 30;
            this.btn_startScan.Load += new System.EventHandler(this.btnG_StartScanning_Load);
            this.btn_startScan.Click += new System.EventHandler(this.btnG_StartScanning_Click);
            // 
            // btnG_ScannerSettings
            // 
            this.btnG_ScannerSettings.BackColor = System.Drawing.Color.Purple;
            this.btnG_ScannerSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnG_ScannerSettings.Label = "SET SCAN";
            this.btnG_ScannerSettings.Location = new System.Drawing.Point(465, 231);
            this.btnG_ScannerSettings.Margin = new System.Windows.Forms.Padding(1);
            this.btnG_ScannerSettings.Name = "btnG_ScannerSettings";
            this.btnG_ScannerSettings.Size = new System.Drawing.Size(96, 71);
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
            this.btnG_CancelTransaction.Location = new System.Drawing.Point(565, 5);
            this.btnG_CancelTransaction.Margin = new System.Windows.Forms.Padding(1);
            this.btnG_CancelTransaction.Name = "btnG_CancelTransaction";
            this.btnG_CancelTransaction.Size = new System.Drawing.Size(99, 71);
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
            this.btnG_Placeholder1.Location = new System.Drawing.Point(566, 79);
            this.btnG_Placeholder1.Margin = new System.Windows.Forms.Padding(1);
            this.btnG_Placeholder1.Name = "btnG_Placeholder1";
            this.btnG_Placeholder1.Size = new System.Drawing.Size(97, 71);
            this.btnG_Placeholder1.TabIndex = 27;
            // 
            // btnG_Finalize
            // 
            this.btnG_Finalize.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnG_Finalize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnG_Finalize.Enabled = false;
            this.btnG_Finalize.ForeColor = System.Drawing.SystemColors.Info;
            this.btnG_Finalize.Label = "FINALIZE";
            this.btnG_Finalize.Location = new System.Drawing.Point(464, 4);
            this.btnG_Finalize.Margin = new System.Windows.Forms.Padding(1);
            this.btnG_Finalize.Name = "btnG_Finalize";
            this.btnG_Finalize.Size = new System.Drawing.Size(97, 72);
            this.btnG_Finalize.TabIndex = 20;
            this.btnG_Finalize.Load += new System.EventHandler(this.btnG_Finalize_Load);
            this.btnG_Finalize.Click += new System.EventHandler(this.btnG_Finalize_Click);
            // 
            // grpbx_summary
            // 
            this.grpbx_summary.Controls.Add(this.lbl_CurrentTaxMult);
            this.grpbx_summary.Controls.Add(this.lbl_totalItems);
            this.grpbx_summary.Location = new System.Drawing.Point(461, 307);
            this.grpbx_summary.Margin = new System.Windows.Forms.Padding(2);
            this.grpbx_summary.Name = "grpbx_summary";
            this.grpbx_summary.Padding = new System.Windows.Forms.Padding(2);
            this.grpbx_summary.Size = new System.Drawing.Size(206, 65);
            this.grpbx_summary.TabIndex = 12;
            this.grpbx_summary.TabStop = false;
            this.grpbx_summary.Text = "Additional Details";
            // 
            // lbl_CurrentTaxMult
            // 
            this.lbl_CurrentTaxMult.AutoSize = true;
            this.lbl_CurrentTaxMult.Location = new System.Drawing.Point(15, 41);
            this.lbl_CurrentTaxMult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CurrentTaxMult.Name = "lbl_CurrentTaxMult";
            this.lbl_CurrentTaxMult.Size = new System.Drawing.Size(115, 13);
            this.lbl_CurrentTaxMult.TabIndex = 1;
            this.lbl_CurrentTaxMult.Text = "Current Tax Multiplier: -";
            // 
            // lbl_totalItems
            // 
            this.lbl_totalItems.AutoSize = true;
            this.lbl_totalItems.Location = new System.Drawing.Point(13, 21);
            this.lbl_totalItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_totalItems.Name = "lbl_totalItems";
            this.lbl_totalItems.Size = new System.Drawing.Size(134, 13);
            this.lbl_totalItems.TabIndex = 0;
            this.lbl_totalItems.Text = "Current Total No. of Items:-";
            // 
            // dtrgd_POS
            // 
            this.dtrgd_POS.AllowUserToAddRows = false;
            this.dtrgd_POS.AllowUserToDeleteRows = false;
            this.dtrgd_POS.AllowUserToOrderColumns = true;
            this.dtrgd_POS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtrgd_POS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtrgd_POS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtrgd_POS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtrgd_POS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtrgd_POS.DefaultCellStyle = dataGridViewCellStyle14;
            this.dtrgd_POS.Location = new System.Drawing.Point(5, 69);
            this.dtrgd_POS.Margin = new System.Windows.Forms.Padding(2);
            this.dtrgd_POS.Name = "dtrgd_POS";
            this.dtrgd_POS.RowTemplate.Height = 28;
            this.dtrgd_POS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtrgd_POS.Size = new System.Drawing.Size(453, 303);
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
            dataGridViewCellStyle13.Format = "C2";
            dataGridViewCellStyle13.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // History
            // 
            this.History.Controls.Add(this.grpbx_transactionList);
            this.History.Controls.Add(this.dtgrd_transactions);
            this.History.Location = new System.Drawing.Point(4, 22);
            this.History.Margin = new System.Windows.Forms.Padding(2);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(2);
            this.History.Size = new System.Drawing.Size(670, 376);
            this.History.TabIndex = 2;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            // 
            // grpbx_transactionList
            // 
            this.grpbx_transactionList.Controls.Add(this.lstbx_transactions);
            this.grpbx_transactionList.Location = new System.Drawing.Point(4, 4);
            this.grpbx_transactionList.Margin = new System.Windows.Forms.Padding(2);
            this.grpbx_transactionList.Name = "grpbx_transactionList";
            this.grpbx_transactionList.Padding = new System.Windows.Forms.Padding(2);
            this.grpbx_transactionList.Size = new System.Drawing.Size(189, 368);
            this.grpbx_transactionList.TabIndex = 2;
            this.grpbx_transactionList.TabStop = false;
            this.grpbx_transactionList.Text = "Transactions";
            // 
            // lstbx_transactions
            // 
            this.lstbx_transactions.FormattingEnabled = true;
            this.lstbx_transactions.Location = new System.Drawing.Point(4, 16);
            this.lstbx_transactions.Margin = new System.Windows.Forms.Padding(2);
            this.lstbx_transactions.Name = "lstbx_transactions";
            this.lstbx_transactions.Size = new System.Drawing.Size(181, 290);
            this.lstbx_transactions.TabIndex = 0;
            this.lstbx_transactions.Click += new System.EventHandler(this.lstbx_transactions_SelectedIndexChanged);
            // 
            // dtgrd_transactions
            // 
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtgrd_transactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_transactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dtgrd_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrd_transactions.DefaultCellStyle = dataGridViewCellStyle22;
            this.dtgrd_transactions.GridColor = System.Drawing.Color.DarkOrange;
            this.dtgrd_transactions.Location = new System.Drawing.Point(204, 4);
            this.dtgrd_transactions.Margin = new System.Windows.Forms.Padding(2);
            this.dtgrd_transactions.Name = "dtgrd_transactions";
            this.dtgrd_transactions.ReadOnly = true;
            this.dtgrd_transactions.RowTemplate.Height = 28;
            this.dtgrd_transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrd_transactions.Size = new System.Drawing.Size(462, 368);
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
            // txtbx_total
            // 
            this.txtbx_total.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtbx_total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_total.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_total.ForeColor = System.Drawing.Color.Lime;
            this.txtbx_total.Location = new System.Drawing.Point(2, 12);
            this.txtbx_total.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_total.Name = "txtbx_total";
            this.txtbx_total.Size = new System.Drawing.Size(449, 41);
            this.txtbx_total.TabIndex = 11;
            this.txtbx_total.Text = "TOTAL     ₱0.00";
            this.txtbx_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtbx_total);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 61);
            this.panel1.TabIndex = 16;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(682, 438);
            this.Controls.Add(this.Tbctrl_POS);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(698, 477);
            this.MinimumSize = new System.Drawing.Size(698, 477);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donkey Horse Mini Grocery POS ";
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
            this.grpbx_summary.ResumeLayout(false);
            this.grpbx_summary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtrgd_POS)).EndInit();
            this.History.ResumeLayout(false);
            this.grpbx_transactionList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_transactions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

