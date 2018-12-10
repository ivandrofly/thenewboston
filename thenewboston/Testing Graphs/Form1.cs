using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Graphs
{
    public partial class Form1 : Form
    {
        Graphics graph;
        Pen pen;
        int x, y;
        public Form1()
        {
            InitializeComponent();
            graph = panel1.CreateGraphics();
            pen = new Pen(Brushes.Blue);
            x = panel1.Width / 2;
            y = panel1.Height / 2;
            timer1.Tick += timer1_Tick;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            graph.DrawLine(pen, new Point((panel1.Width / 2), (panel1.Height / 2)), new Point(x, y));
            y += 5;
            x += 5;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
