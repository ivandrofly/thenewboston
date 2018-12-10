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

namespace Directory_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] filenames = Directory.GetFiles(fbd.SelectedPath);
                string[] drives = Directory.GetLogicalDrives();
                //MessageBox.Show(drives[0]);
                //MessageBox.Show(Directory.GetCreationTime(fbd.SelectedPath).ToString());
                //MessageBox.Show(Directory.GetLastAccessTime(fbd.SelectedPath).ToString());
                //MessageBox.Show(Directory.GetParent(fbd.SelectedPath).ToString());
                //foreach (string filename in filenames)
                //{
                //    MessageBox.Show(filename);
                //}

                
                // Directory class
                if(!Directory.Exists(fbd.SelectedPath + @"\Ivandro"))
                {
                Directory.CreateDirectory(fbd.SelectedPath + @"\Ivandro");
                // Note: you can't movie the directory from a volume to another
                Directory.Move(fbd.SelectedPath + @"\Ivandro", @"D:\My Movie\Ivandro");
                }
            }
        }
    }
}
