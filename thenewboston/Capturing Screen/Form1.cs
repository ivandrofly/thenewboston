using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Capturing_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Ilussion);
            t.Start();
            // this is the stupidiet think I have asked google :) "how to spell parallel" :D
        }

        private void Ilussion()
        {
            //Parallel.Invoke();
            for (; ; )
            {
                Bitmap b = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                Graphics g = Graphics.FromImage(b);
                g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.WorkingArea.Size);
                pictureBox1.Image = b;
            }

            //Parallel.For(0, )
        }
    }
}