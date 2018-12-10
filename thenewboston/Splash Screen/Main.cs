using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Splash_Screen
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.FormClosed += Main_FormClosed;
        }

        void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            // this will exit the whole application!
            Application.Exit();
        }
    }
}
