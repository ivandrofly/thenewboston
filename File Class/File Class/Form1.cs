using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // this will return a boolean
                MessageBox.Show(File.Exists(ofd.FileName).ToString());
                MessageBox.Show(File.Exists(@"D:\VolumeChecker.bat").ToString());

                // this line will delete the selected file.
                File.Delete(ofd.FileName);
            }
        }
    }
}
