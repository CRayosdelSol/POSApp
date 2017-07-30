namespace _POS
{
    partial class FRM_Quantity
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Quantity = new System.Windows.Forms.Button();
            this.txtbx_Quantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Quantity:";
            // 
            // btn_Quantity
            // 
            this.btn_Quantity.Location = new System.Drawing.Point(326, 24);
            this.btn_Quantity.Name = "btn_Quantity";
            this.btn_Quantity.Size = new System.Drawing.Size(75, 43);
            this.btn_Quantity.TabIndex = 1;
            this.btn_Quantity.Text = "OK";
            this.btn_Quantity.UseVisualStyleBackColor = true;
            this.btn_Quantity.Click += new System.EventHandler(this.btn_Quantity_Click);
            // 
            // txtbx_Quantity
            // 
            this.txtbx_Quantity.Location = new System.Drawing.Point(179, 35);
            this.txtbx_Quantity.Name = "txtbx_Quantity";
            this.txtbx_Quantity.Size = new System.Drawing.Size(127, 26);
            this.txtbx_Quantity.TabIndex = 2;
            // 
            // FRM_Quantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 94);
            this.Controls.Add(this.txtbx_Quantity);
            this.Controls.Add(this.btn_Quantity);
            this.Controls.Add(this.label1);
            this.Name = "FRM_Quantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Quantity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Quantity;
        private System.Windows.Forms.TextBox txtbx_Quantity;
    }
}