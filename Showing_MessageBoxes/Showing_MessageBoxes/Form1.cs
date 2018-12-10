using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Showing_MessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Number = 23 + 23 ;
            bool readhair = false;
            object myobjct = true;
            object myobjc2 = "This is a string";
            MessageBox.Show("The Numer is:" + Number.ToString() + " End of you number");
            MessageBox.Show("This is a boolean: " + readhair.ToString());

            MessageBox.Show("This is objc1: " + myobjct.ToString());
            MessageBox.Show("This is objc2: " + myobjc2.ToString());
            button1.Text = "Item"; // This will set the text value of button text to Item
            button1.Enabled = false; // This will disable the button1
           // button1.Height = 60; // This line will change the text Height
            textBox1.Text = "The Button1 were clicked";
            textBox1.MaxLength = 10; // This set the maximum character the users can type
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //string name = "Ivandro Ismael";
            //int num = 3;
            //MessageBox.Show(num.ToString);
        }

        private void Btn_CheckSex_Click(object sender, EventArgs e)
        {
            if (RadioFemale.Checked)
            {
                MessageBox.Show("You are Female");
            }
            else if (RadioMale.Checked)
            {
                MessageBox.Show("You are male");
            }
            else 
            {
                MessageBox.Show("Nothing check, please check a radio and click me", "Error");
            }

            if(!checkBox1.Checked)
            {
                checkBox1.Checked = !checkBox1.Checked;
            }


        }

    }
}
