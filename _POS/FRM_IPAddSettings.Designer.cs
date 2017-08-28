namespace _POS
{
    partial class FrmIpAddSettings
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_netAddA = new System.Windows.Forms.TextBox();
            this.txtbx_netAddB = new System.Windows.Forms.TextBox();
            this.txtbx_netAddC = new System.Windows.Forms.TextBox();
            this.txtbx_netAddD = new System.Windows.Forms.TextBox();
            this.txtbx_portNum = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port Number:";
            // 
            // txtbx_netAddA
            // 
            this.txtbx_netAddA.Location = new System.Drawing.Point(83, 14);
            this.txtbx_netAddA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_netAddA.Name = "txtbx_netAddA";
            this.txtbx_netAddA.Size = new System.Drawing.Size(36, 20);
            this.txtbx_netAddA.TabIndex = 1;
            // 
            // txtbx_netAddB
            // 
            this.txtbx_netAddB.Location = new System.Drawing.Point(130, 14);
            this.txtbx_netAddB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_netAddB.Name = "txtbx_netAddB";
            this.txtbx_netAddB.Size = new System.Drawing.Size(36, 20);
            this.txtbx_netAddB.TabIndex = 2;
            // 
            // txtbx_netAddC
            // 
            this.txtbx_netAddC.Location = new System.Drawing.Point(178, 14);
            this.txtbx_netAddC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_netAddC.Name = "txtbx_netAddC";
            this.txtbx_netAddC.Size = new System.Drawing.Size(36, 20);
            this.txtbx_netAddC.TabIndex = 3;
            // 
            // txtbx_netAddD
            // 
            this.txtbx_netAddD.Location = new System.Drawing.Point(227, 13);
            this.txtbx_netAddD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_netAddD.Name = "txtbx_netAddD";
            this.txtbx_netAddD.Size = new System.Drawing.Size(36, 20);
            this.txtbx_netAddD.TabIndex = 4;
            // 
            // txtbx_portNum
            // 
            this.txtbx_portNum.Location = new System.Drawing.Point(83, 40);
            this.txtbx_portNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_portNum.Name = "txtbx_portNum";
            this.txtbx_portNum.Size = new System.Drawing.Size(91, 20);
            this.txtbx_portNum.TabIndex = 5;
            this.txtbx_portNum.TextChanged += new System.EventHandler(this.txtbx_portNum_TextChanged);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Enabled = false;
            this.btn_confirm.Location = new System.Drawing.Point(155, 63);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(69, 21);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "CONFIRM";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = ".";
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(69, 63);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(68, 21);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FRM_IPAddSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 92);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txtbx_portNum);
            this.Controls.Add(this.txtbx_netAddD);
            this.Controls.Add(this.txtbx_netAddC);
            this.Controls.Add(this.txtbx_netAddB);
            this.Controls.Add(this.txtbx_netAddA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmIpAddSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scanner Settings";
            this.Load += new System.EventHandler(this.FRM_IPAddSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_netAddA;
        private System.Windows.Forms.TextBox txtbx_netAddB;
        private System.Windows.Forms.TextBox txtbx_netAddC;
        private System.Windows.Forms.TextBox txtbx_netAddD;
        private System.Windows.Forms.TextBox txtbx_portNum;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancel;
    }
}