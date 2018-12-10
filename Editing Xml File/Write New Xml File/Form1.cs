using System;
using System.Windows.Forms;
using System.Xml;
//using System.Xml.Linq;
namespace Write_New_Xml_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Xml
        private void button2_Click(object sender, EventArgs e)
        {
            var xWriter = new XmlTextWriter(@"D:\Testing\Xml\.xDoc1.xml", System.Text.Encoding.UTF8);
            xWriter.Formatting = Formatting.Indented;

            xWriter.WriteStartElement("People");
            xWriter.WriteStartElement("Person");
            xWriter.WriteStartElement("Name");
            xWriter.WriteString(textBox1.Text);
            xWriter.WriteEndElement();
            xWriter.WriteEndElement();
            xWriter.WriteEndElement();
            xWriter.Close();
        }
    }
}
