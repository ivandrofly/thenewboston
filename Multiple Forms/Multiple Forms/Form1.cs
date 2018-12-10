using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_2  form2 = new Form_2(textBox1.Text);
            form2.Show(); 
            //form2.ShowDialog(); // you will not be able to move between the forms
            //System.Windows.Forms.Application.Run
            //Application.Exit;
        }
    }
}
