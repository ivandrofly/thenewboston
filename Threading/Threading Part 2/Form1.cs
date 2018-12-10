using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Threading_Part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread t;
        string myString;
        private void button1_Click(object sender, EventArgs e)
        {
            t = new Thread(MyMethod);
            t.Start();

            while (t.IsAlive) //; // this is going to loop while 't' thread is doing his jobs
                textBox1.Text = myString;
        }

        void MyMethod()
        {
            for (int i = 0; i < 1000; i++)
            {
                myString += "#" + i.ToString() + "\r\n";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                t.Abort();
            }
            catch { }
        }
    }
}
