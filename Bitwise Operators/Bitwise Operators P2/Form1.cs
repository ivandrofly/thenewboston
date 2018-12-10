using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitwise_Operators_P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // And Operator
            short myshort = 3 & 5; // 011 && 101 = 001


            // Or Operator 1
            //             0
            //             true
            // Note: the only way to get a 0 here is all the bytes to be 0
            short myshort1 = 3 | 4;

            MessageBox.Show("this is the or operator: " + Convert.ToString(myshort1, 2));
            MessageBox.Show("this is the and operator: " + Convert.ToString(myshort, 2));
        }
    }
}
