using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Address_Book
{
    public partial class Main : Form
    {
        private List<Person> listPerson = new List<Person>();
        private string _settingFile;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "\\Address Book - Ivandro"))
                Directory.CreateDirectory(path + "\\Address Book - Ivandro");

            _settingFile = path + "\\Address Book - Ivandro\\settings.xml";
            if (!File.Exists(path + "\\Address Book - Ivandro\\settings.xml"))
            {
                //File.Create(path + "\\Address Book - Ivandro\\settings.xml");
                // XmlTextWriter if quit useful tough
                XmlTextWriter xtw = new XmlTextWriter(path + "\\Address Book - Ivandro\\settings.xml", Encoding.UTF8);
                xtw.WriteStartElement("People");
                xtw.WriteEndElement();
                xtw.Close();
            }
            else
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(_settingFile);
                foreach (XmlNode xNode in xDoc.SelectNodes("People/Person"))
                {
                    var person = new Person();
                    person.Name = xNode.SelectSingleNode("Name").InnerText;
                    person.Email = xNode.SelectSingleNode("Email").InnerText;
                    person.Street = xNode.SelectSingleNode("Address").InnerText;
                    person.AdditonalInfo = xNode.SelectSingleNode("Notes").InnerText;
                    person.Birthday = DateTime.FromFileTime(Convert.ToInt64(xNode.SelectSingleNode("Birthday").InnerText));
                    listPerson.Add(person);
                    listView1.Items.Add(person.Name);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var person = new Person();
            person.Name = textBoxName.Text;
            person.Email = textBoxEmail.Text;
            person.Birthday = dateTimePicker1.Value;
            person.AdditonalInfo = textBoxAdditionalInfo.Text;
            person.Street = textBoxStreet.Text;

            // Note: there can be checking validation input
            this.listPerson.Add(person);
            listView1.Items.Add(person.Name);
            ResetProperties();
        }

        private void ResetProperties()
        {
            textBoxAdditionalInfo.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxStreet.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }

        //http://stackoverflow.com/questions/5740756/catching-unselecting-all-in-listview-selectedindexchanged-firing-twice
        [Obsolete("Dont you this cause it will fire two times which will cause index outrange exception. use listView1_ItemSelectionChanged() instead", true)]
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listView1.SelectedItems[0].Index > -1 ? listView1.SelectedItems[0].Index : 0;
            textBoxAdditionalInfo.Text = listPerson[index].AdditonalInfo;
            textBoxEmail.Text = listPerson[index].Email;
            textBoxName.Text = listPerson[index].Name;
            textBoxStreet.Text = listPerson[index].Street;
            dateTimePicker1.Value = listPerson[index].Birthday;
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                int index = e.Item.Index;
                textBoxAdditionalInfo.Text = listPerson[index].AdditonalInfo;
                textBoxEmail.Text = listPerson[index].Email;
                textBoxName.Text = listPerson[index].Name;
                textBoxStreet.Text = listPerson[index].Street;
                dateTimePicker1.Value = listPerson[index].Birthday;
            }
        }

        private void RemoveItems()
        {
            if (listView1.Items.Count < 1)
                return;
            try
            {
                listPerson.RemoveAt(listView1.SelectedItems[0].Index);
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            catch (Exception) { }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveItems();
            ResetProperties();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveItems();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count < 1)
                return;

            if (listView1.SelectedItems.Count < 1)
                return;
            int index = listView1.SelectedItems[0].Index;
            listPerson[index].AdditonalInfo = textBoxAdditionalInfo.Text;
            listPerson[index].Name = textBoxName.Text;
            listPerson[index].Email = textBoxEmail.Text;
            listPerson[index].Street = textBoxStreet.Text;
            listPerson[index].Birthday = dateTimePicker1.Value;
            listView1.SelectedItems[index].Text = textBoxName.Text;
        }

        // this should be on closing not Main_FormClosed
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!File.Exists(_settingFile))
            {
                MessageBox.Show("Setting file not found!", "File not found", MessageBoxButtons.OK);
                return;
            }
            // Some topic about xmldocument & xdocument(LINQ)
            // http://www.codeproject.com/Questions/244234/how-to-create-xml-document-programatically-in-csha
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(_settingFile);

            XmlNode xNode = xDoc.SelectSingleNode("People");
            xNode.RemoveAll();
            foreach (Person p in listPerson)
            {
                XmlNode xTop = xDoc.CreateElement("Person");
                XmlNode xName = xDoc.CreateElement("Name");
                XmlNode xEmail = xDoc.CreateElement("Email");
                XmlNode xAddress = xDoc.CreateElement("Address");
                XmlNode xNote = xDoc.CreateElement("Notes");
                XmlNode xBirthday = xDoc.CreateElement("Birthday");

                xName.InnerText = p.Name;
                xEmail.InnerText = p.Email;
                xAddress.InnerText = p.Street;
                xNote.InnerText = p.AdditonalInfo;
                xBirthday.InnerText = p.Birthday.ToFileTime().ToString();

                xTop.AppendChild(xName);
                xTop.AppendChild(xEmail);
                xTop.AppendChild(xAddress);
                xTop.AppendChild(xNote);
                xTop.AppendChild(xBirthday);
                xDoc.DocumentElement.AppendChild(xTop);
                // Wow... this would be easyier using LINQ XDocument
            }
            xDoc.Save(_settingFile);
        }
    }
}