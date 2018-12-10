using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Strings_Text
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            this.panel1.Click += panel1_Click;
        }

        void panel1_Click(object sender, EventArgs e)
        {
            var s = new SolidBrush(Color.Blue);
            Graphics g = panel1.CreateGraphics();

            var ffamily = new FontFamily("Courier New"); // Aria, Comic Sans Ms
            Font font = new System.Drawing.Font(ffamily, 50, FontStyle.Italic | FontStyle.Bold);
            g.DrawString("Ivandro", font, s, new Point(20, 20));
        }
    }
}
