using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar___Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDoStuff_Click(object sender, EventArgs e)
        {
            // Even if it reach is maximum value it will not throw a error
            progressBar1.PerformStep();
            progressBar2.Style = ProgressBarStyle.Marquee;
            progressBar2.MarqueeAnimationSpeed = 100; // Low Value more fast the progress animation will run
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            
            //progressBar2.MarqueeAnimationSpeed = 0; // this will only pause the animation
            progressBar1.Style = ProgressBarStyle.Blocks; // this will change it and stop the animation

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = progressBar1.Maximum.ToString();
        }
    }
}
