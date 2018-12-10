using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            //colorDialog.AllowFullOpen = false; // this will hide the custom color section
            colorDialog.FullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.HelpRequest += colorDialog_HelpRequest;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog.Color;
            }
        }

        void colorDialog_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Chosse a color for backgroup of your button");
        }
    }
}
