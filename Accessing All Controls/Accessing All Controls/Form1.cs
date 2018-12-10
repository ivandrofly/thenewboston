using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accessing_All_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccessAll(this.Controls);
        }

        public void AccessAll(Control.ControlCollection controls)
        {
            // This will do the recursion 
            foreach (Control control in controls)
            {
                if (control is CheckBox)
                {
                    CheckBox newCheckBox = control as CheckBox;
                    newCheckBox.Checked = true;
                }

                if (control.HasChildren)
                {
                    AccessAll(control.Controls);
                }

                if (control is Button)
                {
                    control.Click += control_Click;
                }
            }
        }

        void control_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked a button");
        }
    }
}
