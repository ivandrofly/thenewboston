using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitwise_Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 0101 = 5 
            // 1111111111 1010 = 
            // Note: all the 11111111111 isn't needed the result is 1010
            short myshort = ~5; ;
            MessageBox.Show(Convert.ToString(myshort, 2));
        }
    }
}
