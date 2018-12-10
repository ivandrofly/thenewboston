using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Access_Modifiers_and_Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass MC = new MyClass("Ivandro ismael");
            //MessageBox.Show(MC.Name());

            MyClass.ShowMessage("Hello I'm Message");
        }
    }
}
