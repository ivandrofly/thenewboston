using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form2
{
    public partial class Form1 : Form
    {
        WebBrowser _webBrowser = new WebBrowser();
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Text = "experiment5x";
        }
        // http://halo.bungie.net/stats/reach/default.aspx?player=experiment5x&sd=0
        private void button1_Click(object sender, EventArgs e)
        {
            string userId = this.textBox1.Text;
            // 659433
            _webBrowser.Navigate(@"http://www.bungie.net/stats/reach/default.aspx?player=" + userId + "&sg=0");
            _webBrowser.DocumentCompleted += _webBrowser_DocumentCompleted;
        }

        void _webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (1 > 2)
                label1.Text = "Last Played " + _webBrowser.Document.GetElementById("astPlayedLabel").InnerText;
            else
                //label1.Text = _webBrowser.Document.GetElementById("content").InnerText;
                label1.Text = _webBrowser.Document.GetElementById("content").InnerText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userId = this.textBox1.Text;
            // 659433
            _webBrowser.Navigate("http://subscene.com/subtitles/were-the-millers/english/811424");
            _webBrowser.DocumentCompleted += _webBrowser_DocumentCompleted;
        }
    }
}
