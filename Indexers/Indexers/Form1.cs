using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indexers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string MyProperty { get; set; }
        private void Btn_Set_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MyProperty = textBox1.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myClass MC= new myClass();

            //MC[(int)numericUpDown1.Value] = "Ivandro Ismael";
            //MC[Convert.ToInt32(numericUpDown1.Value)] = "Ivandro Ismael";

            if (MyProperty != "")
            {
                MC[(int)numericUpDown1.Value] = MyProperty;
            }

            MessageBox.Show(MC[(int)numericUpDown1.Value].ToString());
            MyProperty = "";
        }
    }
}
