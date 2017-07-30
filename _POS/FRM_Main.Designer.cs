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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grpbx_summary = new System.Windows.Forms.GroupBox();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.lbl_totalItems = new System.Windows.Forms.Label();
            this.txtbx_total = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_quantity = new System.Windows.Forms.Button();
            this.btn_finalize = new System.Windows.Forms.Button();
            this.dtrgd_POS = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ststrplbl_Datetime = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tbctrl_POS.SuspendLayout();
            this.Inventory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpbx_DBActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_Inventory)).BeginInit();
            this.POS.SuspendLayout();
            this.grpbx_summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtrgd_POS)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbctrl_POS
            // 
            this.Tbctrl_POS.Controls.Add(this.Inventory);
            this.Tbctrl_POS.Controls.Add(this.POS);
            this.Tbctrl_POS.Location = new System.Drawing.Point(1, 0);
            this.Tbctrl_POS.Name = "Tbctrl_POS";
            this.Tbctrl_POS.SelectedIndex = 0;
            this.Tbctrl_POS.Size = new System.Drawing.Size(1016, 624);
            this.Tbctrl_POS.TabIndex = 0;
            // 
            // Inventory
            // 
            this.Inventory.Controls.Add(this.groupBox1);
            this.Inventory.Controls.Add(this.grpbx_DBActions);
            this.Inventory.Controls.Add(this.dtgrd_Inventory);
            this.Inventory.Location = new System.Drawing.Point(4, 29);
            this.Inventory.Name = "Inventory";
            this.Inventory.Padding = new System.Windows.Forms.Padding(3);
            this.Inventory.Size = new System.Drawing.Size(1008, 591);
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
            this.btn_commit.Click += new System.EventHandler(this.button1_Click);
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
            this.dtgrd_Inventory.Size = new System.Drawing.Size(694, 576);
            this.dtgrd_Inventory.TabIndex = 0;
            this.dtgrd_Inventory.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_Inventory_CellValueChanged);
            this.dtgrd_Inventory.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_Inventory_RowLeave);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 62;
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.Width = 105;
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.Width = 77;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 80;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 104;
            // 
            // POS
            // 
            this.POS.Controls.Add(this.button2);
            this.POS.Controls.Add(this.button3);
            this.POS.Controls.Add(this.grpbx_summary);
            this.POS.Controls.Add(this.txtbx_total);
            this.POS.Controls.Add(this.btn_clear);
            this.POS.Controls.Add(this.btn_delete);
            this.POS.Controls.Add(this.btn_quantity);
            this.POS.Controls.Add(this.btn_finalize);
            this.POS.Controls.Add(this.dtrgd_POS);
            this.POS.Location = new System.Drawing.Point(4, 29);
            this.POS.Name = "POS";
            this.POS.Padding = new System.Windows.Forms.Padding(3);
            this.POS.Size = new System.Drawing.Size(1008, 591);
            this.POS.TabIndex = 1;
            this.POS.Text = "Point Of Sale";
            this.POS.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 132);
            this.button2.TabIndex = 14;
            this.button2.Text = "START SCANNING";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(849, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 132);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // grpbx_summary
            // 
            this.grpbx_summary.Controls.Add(this.lbl_totalPrice);
            this.grpbx_summary.Controls.Add(this.lbl_totalItems);
            this.grpbx_summary.Location = new System.Drawing.Point(696, 416);
            this.grpbx_summary.Name = "grpbx_summary";
            this.grpbx_summary.Size = new System.Drawing.Size(309, 119);
            this.grpbx_summary.TabIndex = 12;
            this.grpbx_summary.TabStop = false;
            this.grpbx_summary.Text = "Transaction Summary";
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.Location = new System.Drawing.Point(21, 77);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(92, 20);
            this.lbl_totalPrice.TabIndex = 1;
            this.lbl_totalPrice.Text = "Total Price:-";
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
            // txtbx_total
            // 
            this.txtbx_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_total.Location = new System.Drawing.Point(6, 9);
            this.txtbx_total.Name = "txtbx_total";
            this.txtbx_total.Size = new System.Drawing.Size(682, 89);
            this.txtbx_total.TabIndex = 11;
            this.txtbx_total.Text = "TOTAL           $0.00";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(852, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(150, 132);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(697, 4);
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
            this.btn_finalize.Location = new System.Drawing.Point(852, 142);
            this.btn_finalize.Name = "btn_finalize";
            this.btn_finalize.Size = new System.Drawing.Size(150, 132);
            this.btn_finalize.TabIndex = 7;
            this.btn_finalize.Text = "PAY";
            this.btn_finalize.UseVisualStyleBackColor = true;
            // 
            // dtrgd_POS
            // 
            this.dtrgd_POS.AllowUserToAddRows = false;
            this.dtrgd_POS.AllowUserToDeleteRows = false;
            this.dtrgd_POS.AllowUserToOrderColumns = true;
            this.dtrgd_POS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtrgd_POS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dtrgd_POS.Location = new System.Drawing.Point(7, 106);
            this.dtrgd_POS.Name = "dtrgd_POS";
            this.dtrgd_POS.RowTemplate.Height = 28;
            this.dtrgd_POS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtrgd_POS.Size = new System.Drawing.Size(683, 481);
            this.dtrgd_POS.TabIndex = 3;
            this.dtrgd_POS.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtrgd_POS_RowsAdded);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Barcode";
            this.dataGridViewTextBoxColumn1.HeaderText = "Barcode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 105;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 77;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 104;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ststrplbl_Datetime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 627);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1017, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ststrplbl_Datetime
            // 
            this.ststrplbl_Datetime.Name = "ststrplbl_Datetime";
            this.ststrplbl_Datetime.Size = new System.Drawing.Size(179, 25);
            this.ststrplbl_Datetime.Text = "toolStripStatusLabel1";
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1017, 657);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Tbctrl_POS);
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tbctrl_POS.ResumeLayout(false);
            this.Inventory.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbx_DBActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_Inventory)).EndInit();
            this.POS.ResumeLayout(false);
            this.POS.PerformLayout();
            this.grpbx_summary.ResumeLayout(false);
            this.grpbx_summary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtrgd_POS)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tbctrl_POS;
        private System.Windows.Forms.TabPage Inventory;
        private System.Windows.Forms.TabPage POS;
        private System.Windows.Forms.DataGridView dtgrd_Inventory;
        private System.Windows.Forms.Button btn_commit;
        private System.Windows.Forms.DataGridView dtrgd_POS;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_quantity;
        private System.Windows.Forms.Button btn_finalize;
        private System.Windows.Forms.TextBox txtbx_total;
        private System.Windows.Forms.GroupBox grpbx_summary;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Label lbl_totalItems;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox grpbx_DBActions;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ststrplbl_Datetime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbbx_searchMode;
        private System.Windows.Forms.TextBox txtbx_searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

