using System;
using System.Windows.Forms;

namespace Partial
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
            mc.ShowMessage("Ivandro Ismael");
        }
    }
}
