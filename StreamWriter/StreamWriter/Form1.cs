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


namespace StreamWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
                this.Text = ofd.SafeFileName;
                path = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(File.Create(path));
            sw.BaseStream.Position = 0x28;
            byte[] buffer = { 0x08, 0x09, 0x0A };
            sw.BaseStream.Write(buffer, 0, 3);
            sw.Dispose();
        }
    }
}
