using System;
using System.Windows.Forms;

namespace Timer_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Tick += timer1_Tick;
        }

        int i = 0;
        void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            textBox1.Text += i;
        }
    }
}
