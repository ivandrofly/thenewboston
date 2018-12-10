using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Substrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myString = "Ivandro Ismael";
            string name = myString.Substring(0, 7);
            string lastname = myString.Substring(8);
            MessageBox.Show("Name: " + name + "\nLast-Name: " + lastname);
        }
    }
}
