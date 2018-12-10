using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Multi_Colors_LinearGradientBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Draw ellipse using ColorBlend.
            Point startPoint2 = new Point(20, 110);
            Point endPoint2 = new Point(140, 110);
            Color[] myColors = {Color.Green,
                           Color.Yellow,
                           Color.Yellow,
                           Color.Blue,
                           Color.Red,
                           Color.Red};
            float[] myPositions = { 0.0f, .20f, .40f, .60f, .80f, 1.0f };
            ColorBlend myBlend = new ColorBlend();
            myBlend.Colors = myColors;
            myBlend.Positions = myPositions;
            LinearGradientBrush lgBrush2 = new LinearGradientBrush(startPoint2,
                endPoint2,
                Color.Green,
                Color.Red);
            lgBrush2.InterpolationColors = myBlend;
            Rectangle ellipseRect2 = new Rectangle(20, 110, 120, 80);
            e.Graphics.FillEllipse(lgBrush2, ellipseRect2);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            //this.Refresh();
            LinearGradientBrush lgb = new LinearGradientBrush(new Point(20, 20), new Point(20, 70), Color.Black, Color.Red);
            Graphics g = panel1.CreateGraphics();
            ColorBlend cb = new ColorBlend();
            cb.Colors = new Color[] { Color.Black, Color.Blue, Color.SkyBlue, Color.White };
            cb.Positions = new float[] { 0f, .33f, .66f, 1.0f };
            lgb.InterpolationColors = cb;
            g.FillRectangle(lgb, 20, 20, 50, 50);
        }
    }
}