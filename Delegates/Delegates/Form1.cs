using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            if (textBox1.Text != "")
            {
                mc.ShowThoseMessage(textBox1.Text);
            }
            else
            {
                mc.ShowThoseMessage();
            }
        }
    }
}
