using System;
using System.Drawing;
using System.Windows.Forms;

namespace Drawing_Shapes
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            var sb = new SolidBrush(Color.Green);

            // this mean create graphis in panel1
            Graphics g = panel1.CreateGraphics();
            //DrawRectangle(g, sb);
            //g.FillPie(sb, 20, 20, 60, 60, 0, 270);

            Point[] points = { new Point(0, 20), new Point(0, 0), new Point(20, 0) };
            g.FillPolygon(Brushes.Yellow, points);
        }

        void DrawRectangle(Graphics g, Brush sb)
        {
            g.FillRectangle(sb, 20, 20, 100, 50);
            g.FillEllipse(sb, 50, 50, 50, 50);
        }
    }
}
