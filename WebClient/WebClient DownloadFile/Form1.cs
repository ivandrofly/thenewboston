
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WebClient_DownloadFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Multiple filtering => Image Files (*.bmp, *.jpg)|*.bmp;*.jpg
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { FileName = "THEME.tar.7z", Filter = "7Zip (*.7z)|*.7z|All Files (*.*)|*." };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                button1.Enabled = false;
                WebClient wc = new WebClient();
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += wc_DownloadFileCompleted;
                wc.DownloadFileAsync(new Uri("https://dl.dropboxusercontent.com/s/l24uf3q8bk4xg5v/THEME.tar.7z?token_hash=AAENJ0WvLM0Q5MCIdGVRVvSdyCwGDxeZRBbZkI_mHwz3rQ&dl=1"), sfd.FileName);
            }
            button1.Enabled = true;
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = (e.ProgressPercentage);
            label1.Text = "Completed (" + e.ProgressPercentage.ToString() + "%)";
        }

        void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //MessageBox.Show("File Downloaded Successfully");
            label1.Text = "Download Completed";
        }
    }
}
