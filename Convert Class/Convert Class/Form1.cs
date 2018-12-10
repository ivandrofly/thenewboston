using System;
using System.Windows.Forms;

namespace Convert_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         int myNum = Convert.ToInt32(textBox1.Text) + 2 ;
         MessageBox.Show(myNum.ToString());
        }
    }
}
