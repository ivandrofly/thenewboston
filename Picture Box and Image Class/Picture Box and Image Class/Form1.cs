using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Box_and_Image_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var oFileDialog = new OpenFileDialog();
            if (oFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Image image = Image.FromFile(oFileDialog.FileName);
                //pictureBox1.Image = image;
                pictureBox1.ImageLocation = @"http://www.scienceweek.ie/assets/media/Features/2012%20Feature%20Articles/google_logo.jpg";
            }
        }
    }
}
