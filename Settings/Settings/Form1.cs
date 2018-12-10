using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Settings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Properties.Settings.Default.Name = textBox1.Text;
            Settings.Properties.Settings.Default.Val = textBox1.Text.Length;
            Settings.Properties.Settings.Default.myButton = button1;
            Settings.Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Settings.Properties.Settings.Default.Name + 
                Settings.Properties.Settings.Default.Val;
            
        }
    }
}
