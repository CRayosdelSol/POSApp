using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Configuration;

namespace _POS
{
    public partial class btnG_Quantity : UserControl
    {
        public btnG_Quantity()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int leftRect, int topRect, int rightRect, int bottomRect, int wEllipse, int hEllipse);
        Pen p = new Pen(Color.OliveDrab);

        [Description("The text associated with the control")]
        [Category("Appearance")]
        public string Label
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
                label1.Location = new Point(this.Width / 2 - label1.Width / 2, this.Height / 2 - label1.Height / 2);
            }
        }

        protected void onMouseEnter()
        {
            p.Color = Color.YellowGreen; this.BackColor = Color.YellowGreen; this.Invalidate();
        }

        protected void onMouseDown()
        {
            this.BackColor = Color.DarkOliveGreen; this.Invalidate();
        }

        protected void NormalStyle()
        {
            p.Color = Color.OliveDrab; this.BackColor = Color.OliveDrab; this.Invalidate();
        }

        protected void onMouseLeave()
        {
            p.Color = Color.OliveDrab; this.BackColor = Color.OliveDrab; this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width + 1, this.Height + 1, 3, 3));
            LinearGradientBrush lb = new LinearGradientBrush(new Rectangle(0, 0, this.Width, this.Height), Color.FromArgb(150, Color.White), Color.FromArgb(50, Color.White), LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(lb, 2, 2, this.Width - 6, this.Height / 2);
            e.Graphics.DrawRectangle(p, 0, 0, this.Width - 3, this.Height - 3);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            label1.Location = new Point(this.Width / 2 - label1.Width / 2, this.Height / 2 - label1.Height / 2);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e); onMouseEnter();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e); NormalStyle();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e); onMouseDown();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e); onMouseEnter();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            onMouseEnter();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            NormalStyle();
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            onMouseEnter();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.OnClick(EventArgs.Empty);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            onMouseDown();
        }
    }
}
