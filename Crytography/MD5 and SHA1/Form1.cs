using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace MD5_and_SHA1
{
    public partial class Form1 : Form
    {
        string _hash;
        public Form1()
        {
            InitializeComponent();
            //this.Load += hashIt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string hash = BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(textBox1.Text)));
            _hash = hash;
            //If you want the "standard" looking md5, you can do: return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-","").ToLower();
            _hash = _hash.Replace("-", "").ToUpper();
            this.textBox2.Text = _hash;
        }

        private void hashIt(object sender, EventArgs e)
        {
            // EXAMPLE BY: IVANDRO ISMAEL

            // "MD5"
            var md5 = MD5.Create();
            byte[] computed_hash = md5.ComputeHash(Encoding.UTF8.GetBytes("Ivandro"));
            string hashes = BitConverter.ToString(computed_hash);
            MessageBox.Show(hashes, "MD5");

            // SHA1

            var sha1 = SHA1.Create();
            byte[] computed_hashSHA1 = sha1.ComputeHash(Encoding.UTF8.GetBytes("Ivandro"));
            string decomputed = BitConverter.ToString(computed_hashSHA1);
            MessageBox.Show(decomputed, "SHA1");
        }

        // +20 bytes
        private void button2_Click(object sender, EventArgs e)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            string hash = BitConverter.ToString(sha1.ComputeHash(Encoding.UTF8.GetBytes(textBox1.Text)));
            _hash = hash;
            this.textBox2.Text = _hash;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this._hash != null)
            {
                Clipboard.SetText(_hash);
            }
        }
    }
}