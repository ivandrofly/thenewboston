using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePickerStruct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2013, 10, 20, 23, 20, 2);
            DateTime dtt = DateTime.Today; // return the day but the current hour will not be return
            DateTime dtn = DateTime.Now; // return the current date and time
            MessageBox.Show(dtn.ToString());
            MessageBox.Show("Is 2012 leap year = " + DateTime.IsLeapYear(2012).ToString());

            MessageBox.Show(DateTime.Now.ToFileTime().ToString("X"));
            //DateTime dtff = DateTime.FromFileTime(
        }
    }
}
