using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editing_Xml_File
{
    public partial class Form1 : Form
    {
        static string path = string.Empty;

        System.Xml.XmlDocument xDoc;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML|*.xml";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                    xDoc = new System.Xml.XmlDocument();
                    xDoc.Load(path);
                    textBox1.Text = xDoc.SelectSingleNode("customers/customer/name").InnerText;
                    textBox2.Text = xDoc.SelectSingleNode("customers/customer/country").InnerText;
                    //textBox3.Text = xDoc.SelectSingleNode("customers/customer/country").InnerText;
                }
            }
            //System.IO.BinaryReader
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (xDoc != null)
            {
                xDoc.SelectSingleNode("customers/customer/name").InnerText = textBox1.Text;
                xDoc.SelectSingleNode("customers/customer/country").InnerText = textBox2.Text;
                xDoc.Save(path);
            }
        }
    }
}
