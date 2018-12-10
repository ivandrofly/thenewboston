using System;
using System.Windows.Forms;
using System.IO;

namespace Path_Class
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
                // this will return the file parent directory
                MessageBox.Show(Path.GetDirectoryName(ofd.FileName));
                
                // this will return the filename without extension
                MessageBox.Show(Path.GetFileNameWithoutExtension(ofd.FileName));

                // this will check if the selected file has a extension and will return a boolean datatype
                MessageBox.Show(Path.HasExtension(ofd.FileName).ToString());
            }
        }
    }
}
