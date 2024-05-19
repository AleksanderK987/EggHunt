using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EggHunt.Form1;
using System.Xml.Serialization;
using System.Xml;

namespace EggHunt
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            difficulty.SelectedIndex = 1; //to prevent sending null to Form1
            HighScores();
        }

        private void play_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedDifficulty = difficulty.SelectedIndex.ToString();
            Form1 form1 = new Form1(selectedDifficulty); //funfact: when sending this form without sending difficulty property, the timer in the form1 was running and calling functions all the time
            form1.ShowDialog();
        }

        private void difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public List<int> _scores = new List<int>();
        const string filePath = "highscores.xml";
        void HighScores()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNodeList scoreNodes = doc.GetElementsByTagName("Score");
            foreach (XmlNode scoreNode in scoreNodes)
            {
                int score;
                if (int.TryParse(scoreNode.InnerText, out score))
                {
                    _scores.Add(score);
                }
            }
            //displaying the highscores in textbox
            DisplayHS();
        }

        void DisplayHS()
        {
            //showing the highscores from best to worse
            _scores.Sort((x, y) => y.CompareTo(x));
            foreach (var score in _scores)
            {
                highscores.AppendText($"Score: {score}\n");
            }
        }
        private void highscores_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
