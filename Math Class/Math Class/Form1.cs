using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = Math.Abs(-4).ToString(); // which is four (4)
            
            //label1.Text = Math.PI.ToString(); // this will return the PI 3.141592653

            //label1.Text = Math.Pow(4,2).ToString(); //4*2=8*2=16

            // Round
            //label1.Text = Math.Round(4.7).ToString(); // which wil be 5
            label1.Text = Math.Round(4.73421, 2).ToString(); // this will try to round the 73, if (0 in , 2)  it would be 5;
        }
    }
}
