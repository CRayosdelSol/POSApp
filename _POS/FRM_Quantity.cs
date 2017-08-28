using System;
using System.Windows.Forms;

namespace _POS
{
    public partial class FrmQuantity : Form
    {
        readonly FrmMain _mainFrm;

        public FrmQuantity()
        {
            InitializeComponent();
        }

        public FrmQuantity(FrmMain mainFrm)
        {
            InitializeComponent();
            _mainFrm = mainFrm;
            ControlBox = false;
        }

        private void btn_Quantity_Click(object sender, EventArgs e)
        {
            _mainFrm.SpecificQuantity = int.Parse(txtbx_Quantity.Text);
            _mainFrm.SpecifiedQuantity = true;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            _mainFrm.SpecifiedQuantity = false;
            Close();
        }

        private void txtbx_Quantity_TextChanged(object sender, EventArgs e)
        {
            btn_ok.Enabled = txtbx_Quantity.Text != string.Empty;
        }
    }
}
