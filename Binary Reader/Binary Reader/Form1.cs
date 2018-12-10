using System;
using System.Windows.Forms;

namespace Binary_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
                path = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.BinaryReader br = new System.IO.BinaryReader(System.IO.File.OpenRead(path));
            //textBox1.Text = br.ReadChar().ToString();
            //foreach (char myChar in br.ReadChars(5)) textBox1.Text += myChar;
            //br.BaseStream.Position = 0x11;
            //br.BaseStream.Position = 0x00;
            br.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
            //br.BaseStream.Seek(-0x80, System.IO.SeekOrigin.End);
            byte[] buffer = br.ReadBytes(8);
            Array.Reverse(buffer);
            //textBox1.Text = BitConverter.ToInt64(buffer, 0).ToString("X");
            textBox1.Text = BitConverter.ToInt16(buffer, 0).ToString("X"); // default
            //textBox1.Text = br.ReadInt32().ToString("X"); // note that the binary reader readers right to left but textbox reads left to right
            br.Close();
            //br.Dispose();
        }
    }
}

// Note: http://stackoverflow.com/questions/5890078/streams-why-use-seek0l-seekorigin-begin-instead-of-location-0-or-vice-versa
/*
As far as I can tell, at least for this specific case, nothing.

Both method Seek() and property Position require CanSeek to be true so from what I see it's up to the implementer.

Seek is really there to allow searching from specified locations (SeekOrigins) to an offset (the examples given on MSDN are somewhat convoluted but representative of the purpose: http://msdn.microsoft.com/en-us/library/system.io.filestream.seek.aspx).

Position is absolute and is obviously not meant for searching.

The case you mentioned just happens to be equivalent.

Personally, I'd use .Position = 0 to move to the beginning of the stream as that reads cleaner to me than "Seek using the beginning of the file as an origin and move this 0 offset of bytes."
*/