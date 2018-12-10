using System;
using System.Windows.Forms;
using System.IO;

namespace SaveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Test File(*.txt)|*.txt";
            saveFileDialog1.FileName = "MyFile";
            saveFileDialog1.Title = "Save File";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                System.IO.BinaryWriter br = new BinaryWriter(File.Create(path));
                br.Write("Example text file");
                br.Dispose();
            }
        }
    }
}
