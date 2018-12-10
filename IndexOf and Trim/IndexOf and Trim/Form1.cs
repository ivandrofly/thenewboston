using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndexOf_and_Trim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Substring Method
            string name = "Ivandro Ismael";
            string firstName = name.Substring(0, name.IndexOf(" "));
            string lastName = name.Substring(name.IndexOf(" ") +1);
            MessageBox.Show(firstName + ", " + lastName);

            // Trim
            string name1 = "Ivandro Ismael";
            string trimmed = name.Trim();
            string startTrimmend = name.TrimStart();
            string endTrimmed = name.TrimEnd();
            MessageBox.Show("Trimmed: "+ trimmed + "\nStartTrimmed: " + startTrimmend + "\nEndTrimmed: " + endTrimmed);
        }
    }
}
