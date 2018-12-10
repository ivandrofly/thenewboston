using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generate_Random_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            byte[] buffer = new byte[5];

            //MessageBox.Show(r.Next(1, 300).ToString());
            MessageBox.Show(r.NextDouble().ToString());

            r.NextBytes(buffer);
            MessageBox.Show(BitConverter.ToString(buffer));

        }
    }
}
