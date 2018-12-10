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
    public partial class Splash : Form
    {

        Timer t;
        public Splash()
        {
            t = new Timer();
            InitializeComponent();
            t.Start();
            t.Tick += t_Tick;
        }

        void t_Tick(object sender, EventArgs e)
        {
            t.Stop();
            var main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
