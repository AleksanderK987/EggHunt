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
        [Serializable]
        public class HighScore
        {
            [XmlElement("Score")]
            public int Score { get; set; }
            [XmlElement("Nick")]
            public string Nick { get; set; }
        }

        public Menu()
        {
            InitializeComponent();
            //to prevent sending nulls to Form1
            difficulty.SelectedIndex = 0;
            nickname.Text = "Guest";
            HighScores();
        }

        private void play_Click(object sender, EventArgs e)
        {
            string selectedDifficulty = difficulty.SelectedIndex.ToString();
            string playerNick = nickname.Text;
            this.Hide();
            Form1 form1 = new Form1(selectedDifficulty, playerNick); //funfact: when sending this form without sending difficulty property, the timer in the form1 was running and calling functions all the time
            form1.ShowDialog();
        }

        public List<HighScore> _scores = new List<HighScore>();
        const string filePath = "highscores.xml";
        void HighScores()
        {
            if (File.Exists(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<HighScore>));
                using (var reader = new StreamReader(filePath))
                {
                    _scores = (List<HighScore>)serializer.Deserialize(reader);
                }
            }
            //displaying the highscores in textbox
            DisplayHS();
        }

        void DisplayHS()
        {
            //showing the highscores from best to worse
            _scores.Sort((x, y) => y.Score.CompareTo(x.Score));
            foreach (var score in _scores)
            {
                highscores.AppendText(score.Nick+": "+score.Score+"\n");
            }
        }

        private void difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void highscores_TextChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void nickname_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
