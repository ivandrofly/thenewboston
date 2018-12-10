using System;
using System.Windows.Forms;
using System.Net;

namespace WebClient_Status_p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            //textBox1.Text = wc.DownloadString(@"https://docs.google.com/document/d/1_lwNjeoFubfjz06kNIMpucQ0bxnEqoN62XzkGkz_kqM/edit");
            //textBox1.Text = wc.DownloadString(@"http://simple.wikiquote.org/wiki/List_of_people_by_name");
            byte[] array = wc.DownloadData(@"http://simple.wikiquote.org/wiki/List_of_people_by_name");
            textBox1.Text = array.Length.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
