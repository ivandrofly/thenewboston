using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Array_ = new string[4];
            Array_[1] = "Ismael";
            Array_[0] = "Ivandro";
            Array_[4] = "718947982";
            

            string[] Name = { "Ivandro", "Ismael", "Jao" };     
           MessageBox.Show(Name[0]);
        }
    }
}
