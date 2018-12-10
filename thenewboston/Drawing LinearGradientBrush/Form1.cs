using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Drawing_LinearGradientBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            this.Refresh();
            LinearGradientBrush lgb =
               new LinearGradientBrush(new Point(20, 20), new Point(70, 70), Color.Red, Color.Yellow);
            Graphics g = panel1.CreateGraphics();

            g.FillRectangle(lgb, 20, 20, 50, 50);
            g.FillEllipse(lgb, 100, 20, 100, 100);
        }
    }
}