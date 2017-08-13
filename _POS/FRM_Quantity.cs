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
    public partial class FRM_Quantity : Form
    {
        FRM_Main mainFrm;
        
        public FRM_Quantity()
        {
            InitializeComponent();
        }

        public FRM_Quantity(FRM_Main mainFrm)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;
            ControlBox = false;
        }

        private void btn_Quantity_Click(object sender, EventArgs e)
        {
            mainFrm.specificQuantity = int.Parse(txtbx_Quantity.Text);
            mainFrm.specified_Quantity = true;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            mainFrm.specified_Quantity = false;
            Close();
        }
    }
}
