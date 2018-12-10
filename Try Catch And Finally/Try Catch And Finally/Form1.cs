using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try_Catch_And_Finally
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] names = new string[2];
                string s = names[5];
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error " + ex.Message);
            }
            finally
            { MessageBox.Show("your code is done!"); }
        }
    }
}
