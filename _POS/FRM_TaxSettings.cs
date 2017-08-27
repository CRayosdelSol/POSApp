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
    public partial class FRM_TaxSettings : Form
    {
        FRM_Main mainfrm;

        public FRM_TaxSettings()
        {
            InitializeComponent();
        }

        public FRM_TaxSettings(FRM_Main mainfrm)
        {
            InitializeComponent();
            this.mainfrm = mainfrm;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txtbx_taxMultiplier.Text != "0")
            {
                mainfrm.taxMultiplier = decimal.Parse(txtbx_taxMultiplier.Text) / 100;
                mainfrm.haveSpecificTaxMultiplier = true;
            }
            else
            {
                mainfrm.haveSpecificTaxMultiplier = false;
                mainfrm.taxMultiplier = 0;
            }

            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            mainfrm.haveSpecificTaxMultiplier = false;
            Close();
        }

        private void txtbx_taxMultiplier_TextChanged(object sender, EventArgs e)
        {
            if(txtbx_taxMultiplier.Text == "0" || txtbx_taxMultiplier.Text == string.Empty)
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
