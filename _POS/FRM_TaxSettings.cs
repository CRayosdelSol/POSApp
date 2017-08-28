using System;
using System.Windows.Forms;

namespace _POS
{
    public partial class FrmTaxSettings : Form
    {
        readonly FrmMain _mainfrm;

        public FrmTaxSettings()
        {
            InitializeComponent();
        }

        public FrmTaxSettings(FrmMain mainfrm)
        {
            InitializeComponent();
            _mainfrm = mainfrm;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txtbx_taxMultiplier.Text != @"0")
            {
                _mainfrm.TaxMultiplier = decimal.Parse(txtbx_taxMultiplier.Text) / 100;
                _mainfrm.HaveSpecificTaxMultiplier = true;
            }
            else
            {
                _mainfrm.HaveSpecificTaxMultiplier = false;
                _mainfrm.TaxMultiplier = 0;
            }

            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            _mainfrm.HaveSpecificTaxMultiplier = false;
            Close();
        }

        private void txtbx_taxMultiplier_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_taxMultiplier.Text == @"0" || txtbx_taxMultiplier.Text == string.Empty)
            {
                btn_OK.Enabled = false;

            }
            else
            {
                btn_OK.Enabled = true;
            }
        }
    }
}
