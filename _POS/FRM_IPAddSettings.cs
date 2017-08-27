using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace _POS
{
    public partial class FRM_IPAddSettings : Form
    {

        FRM_Main mainForm;
        string localIP;
        string[] IPBits;

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
            mainForm.scannerSettingsAreSet = true;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            mainForm.scannerSettingsAreSet = false;
            
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

        /// <summary>
        /// Obtain the IPV4 Address of the host.
        /// </summary>
        public void obtainLocalHostIP()
        {
            IPHostEntry host;
            localIP = string.Empty;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    IPBits = localIP.Split('.');
                    txtbx_netAddA.Text = IPBits[0];
                    txtbx_netAddB.Text = IPBits[1];
                    txtbx_netAddC.Text = IPBits[2];
                    txtbx_netAddD.Text = IPBits[3];
                    txtbx_portNum.Select();
                }
            }
        }

        private void FRM_IPAddSettings_Load(object sender, EventArgs e)
        {
            obtainLocalHostIP();
            txtbx_portNum.Text = "5000";
        }
    }

}
