using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Write_Nodes_to_Existing_XML_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [Description("This is just the example")]
        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("path");
            XmlNode person = doc.CreateElement("Person");
            XmlNode name = doc.CreateElement("Name");
            name.InnerText = textBox1.Text;
            person.AppendChild(name);
            XmlNode age = doc.CreateElement("Name");
            age.InnerText = textBox1.Text;
            person.AppendChild(age);
            doc.DocumentElement.AppendChild(person);
            doc.Save("path");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("path");
            foreach (XmlNode xNode in xdoc.SelectNodes("Peoples/Person"))
            {
                if (xNode.SelectSingleNode("Name").InnerText == textBox1.Text)
                {
                    // this will only remove the child noes in Person(which is name...)
                    //xNode.RemoveAll();
                    // this will remove the Person in (Peoples/Person)
                    xNode.ParentNode.RemoveAll();
                }
            }
            xdoc.Save("path");
        }
    }
}
