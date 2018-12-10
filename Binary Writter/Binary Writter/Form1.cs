using System;
using System.Windows.Forms;
using System.IO;

namespace Binary_Writter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string path;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
                path = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryWriter br = new BinaryWriter(File.OpenWrite(path));
            short myShort = 1;
            int myint = 0x2345;
            byte[] buffer  = BitConverter.GetBytes(myint);
            Array.Reverse(buffer);
            br.Write(buffer);
            //br.Write('C');
            //br.Write('H');
            br.Dispose();
        }
    }
}
