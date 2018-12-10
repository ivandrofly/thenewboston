using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Making_Controls
{
    public partial class AdvCtrl : Button
    {
        public AdvCtrl()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                if (value == "Ivandro")
                {
                    MessageBox.Show("You are not allowed to set that name!");
                    base.Text = "Usercontrol 1";
                    return;
                }
                base.Text = value;
            }
        }
    }
}
