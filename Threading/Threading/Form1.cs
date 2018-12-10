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
namespace Threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread t;

        private void button1_Click(object sender, EventArgs e)
        {
            t = new Thread(ivandro);
            t.Start();
        }

        void ivandro()
        {
            for (; ; ) ;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                t.Abort();
            }
            catch (Exception)
            {
            }
        }

    }
}
