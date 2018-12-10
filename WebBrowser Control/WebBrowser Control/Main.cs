using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser_Control
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void buttonGoForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void buttonGoHome_Click(object sender, EventArgs e)
        {
            // this browser uses the Internet Explorer frame, so its going to
            // run the Internet Explorer home page.
            webBrowser1.GoHome();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
