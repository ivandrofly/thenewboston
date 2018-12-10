using System.Drawing;
using System.Windows.Forms;

namespace Drawing_with_Pen
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            this.panel1.Click += (sender, e) =>
            {
                Pen pen = new Pen(Color.Red, 3);
                Graphics g = panel1.CreateGraphics();

                //g.DrawRectangle(pen, 20, 20, 50, 50);
                //Point[] points = { new Point(0, 20), new Point(0, 0), new Point(20, 0) };
                //g.DrawPolygon(pen, points);

                g.DrawLine(pen, new Point(0, 0), new Point(100, 100));
            };

            // would work just like the on the top! sender, e not needed
            //this.panel1.Click += delegate
            //{
            //    Pen pen = new Pen(Color.Red, 3);
            //    Graphics g = panel1.CreateGraphics();

            //    //g.DrawRectangle(pen, 20, 20, 50, 50);
            //    //Point[] points = { new Point(0, 20), new Point(0, 0), new Point(20, 0) };
            //    //g.DrawPolygon(pen, points);

            //    g.DrawLine(pen, new Point(0, 0), new Point(100, 100));
            //};
        }
    }
}
