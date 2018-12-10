using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Split_and_ToCharArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Ivandro;Ismael;Gomes;Jao";
            string[] names = name.Split(';');
            foreach (string myname in names)
            {
                MessageBox.Show(myname);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string letter = "abcdefghij";
            char[] letters = letter.ToCharArray();
            foreach (char myletter in letters)
            {
                MessageBox.Show(myletter.ToString());
            }
        }
    }
}
