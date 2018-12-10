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

namespace Threading_Part_3
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
            t = new Thread(ivandro); // this will only point to method => ivandro
            object[] objcArray = { "PsPortable", 500 };
            t.Start(objcArray); // this will past the object array to => ivandro(object array)

            while (t.IsAlive) //; // this is going to loop while 't' is doing is jobs
                textBox1.Text = myString;
        }

        /// <summary>
        /// This method as the be a object nothing more but object datatype or it will not work
        /// </summary>
        /// <param name="name">This is a object and can't be another type of data</param>
        void ivandro(object array)
        {
            object[] o = array as object[];
            for (int i = 0; i < (int)o[1]; i++)
            {
                Thread.Sleep(30); // this is gong to make is crash for 30 milliseconds
                myString += o[0].ToString() + i.ToString() + "\r\n";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { t.Abort(); }
            catch { }
        }
    }
}
