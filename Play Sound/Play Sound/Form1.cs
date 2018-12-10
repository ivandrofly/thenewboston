using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Play_Sound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  this will play the sound Note: it has to be *.wav
        ///  Note: make sure your system sound is enabled otherwise you won't hear the sound while the system is playing it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //var OfDialog = new OpenFileDialog();
            //if (OfDialog.ShowDialog() == DialogResult.OK)
            //{
            //    var sp = new SoundPlayer(OfDialog.FileName);
            //    sp.Play();
            //}

            #region System Sound
            //SystemSounds.Asterisk.Play();
            SystemSounds.Beep.Play();
            #endregion
        }
    }
}
