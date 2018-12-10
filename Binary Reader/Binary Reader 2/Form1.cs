using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Reader_2
{
    public partial class Form1 : Form
    {
        private string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
                this.path = ofd.FileName;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.IO.BinaryReader br = new System.IO.BinaryReader(System.IO.File.OpenRead(path));
            //br.BaseStream.Position = 0x1E;
            byte[] buffer = br.ReadBytes(2);
            //Array.Reverse(buffer);
            //buffer = BitConverter.GetBytes(4728394);
            textBox1.Text = BitConverter.ToInt16(buffer, 0).ToString("x");
            br.Close();
            //br.Dispose();
        }
    }
}
