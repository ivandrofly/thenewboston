using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Process_Class_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcesses())
            {
                //this line will get all the running process in you computer
                //MessageBox.Show(p.ProcessName.ToString());

                //this line will check if the process is responding
                //MessageBox.Show(p.Responding.ToString());
                if (!p.Responding) p.Kill();
            }
            MessageBox.Show("1-Done!");
            processByName_();
        }

        // this will get all the process of chrome
        private void processByName_()
        {
            foreach (Process p in Process.GetProcessesByName("chrome"))
            {
                MessageBox.Show(p.ProcessName.ToString());
            }
        }
    }
}
