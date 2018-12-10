using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Is__As__Casting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object myobj = "Ivandro Ismael Gomes Jao";
            if (myobj is string) MessageBox.Show((string)myobj);

            Control myControl = button1;
            if (myControl is Button)
            {
                // this is two is the same
                Button myButton = (Button)myControl;
                Button myButton1 = myControl as Button;

                MessageBox.Show(myButton.Text);

            }
        }
    }
}
