using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using static System.Int32;

namespace _POS
{
    public partial class FrmIpAddSettings : Form
    {
        string _localIp;
        string[] _ipBits;

        public FrmMain MainForm { get; set; }

        public FrmIpAddSettings()
        {
            InitializeComponent();
        }

        public FrmIpAddSettings(FrmMain mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            MainForm.IpAddressHolder =
                $"{txtbx_netAddA.Text}.{txtbx_netAddB.Text}.{txtbx_netAddC.Text}.{txtbx_netAddD.Text}";
            MainForm.PortNumber = Parse(txtbx_portNum.Text);
            MainForm.ScannerSettingsAreSet = true;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            MainForm.ScannerSettingsAreSet = false;

        }

        private void txtbx_portNum_TextChanged(object sender, EventArgs e)
        {
            btn_confirm.Enabled = txtbx_portNum.Text.Length != 0;
        }

        /// <summary>
        /// Obtain the IPV4 Address of the host.
        /// </summary>
        public void ObtainLocalHostIp()
        {
            _localIp = string.Empty;
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily != AddressFamily.InterNetwork) continue;
                _localIp = ip.ToString();
                _ipBits = _localIp.Split('.');
                txtbx_netAddA.Text = _ipBits[0];
                txtbx_netAddB.Text = _ipBits[1];
                txtbx_netAddC.Text = _ipBits[2];
                txtbx_netAddD.Text = _ipBits[3];
                txtbx_portNum.Select();
            }
        }

        private void FRM_IPAddSettings_Load(object sender, EventArgs e)
        {
            ObtainLocalHostIp();
            txtbx_portNum.Text = @"5000";
        }
    }

}
