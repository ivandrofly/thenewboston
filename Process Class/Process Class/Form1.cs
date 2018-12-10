using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Process_Class
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
                //Process.Start("notepad.exe", ofd.FileName);
                MessageBox.Show(Process.GetCurrentProcess().ProcessName);
                
                // this will kill the current process
                Process.GetCurrentProcess().Kill();
            }
        }
    }
}
