using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }
        string word = string.Empty;
        List<Label> listLabel = new List<Label>();
        int _amount;

        private enum BodyParts
        {
            Head,
            LeftEye,
            RightEye,
            Mouth,
            RightArm,
            LeftArm,
            Body,
            Rightleg,
            LeftLeg
        }

        void Form1_Shown(object sender, EventArgs e)
        {
            DrawHangPost();
            MakeLAbel();
        }

        void DrawHangPost()
        {
            Graphics g = panel1.CreateGraphics();
            var p = new Pen(Color.Brown, 10);

            /*
            g.DrawLine(p, )
            g.DrawLine(p, new Point(130, 218), new Point(130, 5)); // #2 point x = padding for length y = is the padding space
            g.DrawLine(p, new Point(135, 5), new Point(65, 5));
            g.DrawLine(p, new Point(60, 0), new Point(60, 60));
            */
            //"C:\Users\Ivandrofly\Videos\Programming Videos\TheNewBoston\C#\C# Beginners Tutorial - 155 - Project 3 Hangman, Drawing Hang Post.mp4"
            // watch video C# Beginners Tutorial - 155 - Project 3 Hangman, Drawing Hang Post
            g.DrawLine(p, new Point(130, 218), new Point(130, 5)); // this will be like: first point .                   . second point
            g.DrawLine(p, new Point(135, 5), new Point(65, 5));
            g.DrawLine(p, new Point(60, 0), new Point(60, 60));

            //DrawBodyPart(BodyParts.Head);
            //DrawBodyPart(BodyParts.LeftEye);
            //DrawBodyPart(BodyParts.RightEye);
            //DrawBodyPart(BodyParts.Mouth);
            //DrawBodyPart(BodyParts.Body);
            //DrawBodyPart(BodyParts.RightArm);
            //DrawBodyPart(BodyParts.LeftArm);
            //DrawBodyPart(BodyParts.LeftLeg);
            //DrawBodyPart(BodyParts.Rightleg);
        }

        void MakeLAbel()
        {
            word = GetRandomWord();
            var charArray = word.ToCharArray(); // last will contain \n 
            int between = 441 / charArray.Length - 2;

            for (int i = 0; i < charArray.Length - 1; i++)
            {
                var label = new Label() { Location = new Point((i * between) + 10, 80) };
                label.Text = "_";
                label.Parent = groupBox2;
                label.BringToFront();
                label.CreateControl();
                listLabel.Add(label);
            }
            label1.Text = "Word length: " + (word.Length - 1 > 0 ? word.Length - 1 : 00).ToString();
        }

        private string GetRandomWord()
        {
            var wc = new WebClient();
            string wordsList = wc.DownloadString("http://dictionary-thesaurus.com/wordlists/Adjectives%2850%29.txt");
            string[] words = wordsList.Split('\n');
            var rand = new Random();
            return words[rand.Next(0, words.Length - 1)];
        }

        void DrawBodyPart(BodyParts bodyPart)
        {

            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Blue, 2);
            SolidBrush sb;
            switch (bodyPart)
            {
                case BodyParts.Head:
                    g.DrawEllipse(p, 40, 58, 40, 40); // Todo: adjust head!
                    break;
                case BodyParts.LeftEye:
                    sb = new SolidBrush(Color.Black);
                    g.FillEllipse(sb, 50, 68, 5, 5);
                    break;
                case BodyParts.RightEye:
                    sb = new SolidBrush(Color.Black);
                    g.FillEllipse(sb, 63, 68, 5, 5);
                    break;
                case BodyParts.Mouth:
                    g.DrawArc(p, 50, 69, 20, 20, 45, 90);
                    break;
                case BodyParts.RightArm:
                    g.DrawLine(p, new Point(60, 100), new Point(90, 85));
                    break;
                case BodyParts.LeftArm:
                    g.DrawLine(p, new Point(60, 100), new Point(30, 85));
                    break;
                case BodyParts.Body:
                    g.DrawLine(p, new Point(60, 90), new Point(60, 170));
                    break;
                case BodyParts.Rightleg:
                    g.DrawLine(p, new Point(60, 170), new Point(90, 190));
                    break;
                case BodyParts.LeftLeg:
                    g.DrawLine(p, new Point(60, 170), new Point(30, 190));
                    break;
            }
            g.DrawLine(p, new Point(60, 170), new Point(60, 185));
        }

        private void buttonSubmitLetter_Click(object sender, EventArgs e)
        {
            char chr = textBox1.Text.ToLower()[0];
            if (!char.IsLetter(chr))
                return;

            int idx = -1;
            if (word.Contains(chr))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (!(chr == word[i]))
                        continue;
                    else
                        idx = i;
                    listLabel[idx].Text = chr.ToString();
                }
                foreach (Label label in listLabel)
                    if (label.Text == "_")
                        return;
                    else
                        MessageBox.Show("You have won the game", "Congrats");
                ResetGame();
            }
            else
            {
                MessageBox.Show("The letter that you guessed isn't in the word", "Sorry");
                labelMissed.Text += " " + chr + ",";
                _amount++;
                DrawBodyPart((BodyParts)_amount);
                if (_amount > 7)
                {
                    MessageBox.Show("Sorry but you lost!");
                    ResetGame();
                }
                // could be 
            }
        }
        void ResetGame()
        {
            //Graphics g = panel1.CreateGraphics();
            //g.Clear();
            panel1.Invalidate();
            GetRandomWord();
            MakeLAbel();
            DrawHangPost();
            labelMissed.Text = "Missed: ";
            _amount = 0;
            textBox1.Text = "";
        }

        private void buttonSubmitWord_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToLower() == word.ToLower())
            {
                MessageBox.Show("You don't the game!");
                ResetGame();
            }
            else
            {
                MessageBox.Show("The word that you guess is wrong...", "Sorry");
                DrawBodyPart((BodyParts)_amount);
                _amount++;
                if (_amount == 9)
                {
                    MessageBox.Show("Sorry but you lost! The word was " + word);
                    ResetGame();
                }
            }
        }
    }
}
