using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace TipleDES_Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // this is privte array
        byte[] encrypted;
        byte[] decrypted;
        private void button1_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();

            var crypto = TripleDES.Create();
            tDes.Key = md5.ComputeHash(Encoding.UTF8.GetBytes(textBoxEncryptKey.Text));
            tDes.Mode = CipherMode.ECB;
            tDes.Padding = PaddingMode.PKCS7;

            ICryptoTransform trans = tDes.CreateEncryptor();
            encrypted = trans.TransformFinalBlock(Encoding.UTF8.GetBytes(textBoxToEncrypt.Text), 0, Encoding.UTF8.GetBytes(textBoxToEncrypt.Text).Length);
            textBox3.Text = BitConverter.ToString(encrypted);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();

            tDes.Key = md5.ComputeHash(Encoding.UTF8.GetBytes(textBox4.Text));
            tDes.Mode = CipherMode.ECB;
            tDes.Padding = PaddingMode.PKCS7;

            ICryptoTransform trans = tDes.CreateDecryptor();
            decrypted = trans.TransformFinalBlock(encrypted, 0, encrypted.Length);
            textBox5.Text = Encoding.UTF8.GetString(decrypted);
        }

        private byte[] FromFile()
        {
            // this was running supper slow
            byte[] buffer = File.ReadAllBytes(@"D:\uTorrent\True\01 Wake Me Up.mp3");
            return buffer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
