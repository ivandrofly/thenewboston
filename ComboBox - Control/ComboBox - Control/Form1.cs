using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox___Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Ivandro Ismael")
            {
                MessageBox.Show(comboBox1.Text);
                MessageBox.Show(comboBox1.Items[1].ToString());
                comboBox1.Items.Add("I'm the new item");
                int total_items = comboBox1.Items.Count;
            }
        }
    }
}
