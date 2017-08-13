using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _POS
{
    public partial class FRM_IPAddSettings : Form
    {

        FRM_Main mainForm;

        public FRM_IPAddSettings()
        {
            InitializeComponent();
        }

        public FRM_IPAddSettings(FRM_Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            mainForm.IPAddressHolder = string.Format("{0}.{1}.{2}.{3}", txtbx_netAddA.Text, txtbx_netAddB.Text, txtbx_netAddC.Text, txtbx_netAddD.Text);
            mainForm.PortNumber = Int32.Parse(txtbx_portNum.Text);
            mainForm.setScannerSettings = true;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            mainForm.setScannerSettings = false;
            
        }

        private void txtbx_portNum_TextChanged(object sender, EventArgs e)
        {
            if(txtbx_portNum.Text.Length == 0)
            {
                btn_confirm.Enabled = false;
            }
            else
            {
                btn_confirm.Enabled = true;
            }

        }
    }
}
