using System.Xml;
using System.Xml.Serialization;
using static System.Formats.Asn1.AsnWriter;

namespace EggHunt
{
    public partial class Form1 : Form
    {
        [Serializable]
        public class HighScore
        {
            [XmlElement("Score")]
            public int Score { get; set; }
            [XmlElement("Nick")]
            public string Nick { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        //retrieving the selected difficulty level 
        public string SelectedDifficulty { get; set; }
        public string Nickname { get; set; }   
        public Form1(string difficulty, string nick) : this()
        {
            SelectedDifficulty = difficulty;
            Nickname = nick;
        }

        private void Basket_Click(object sender, EventArgs e)
        {

        }

        private void Egg_Click(object sender, EventArgs e)
        {

        }

        private void Health_Click(object sender, EventArgs e)
        {

        }

        private void Points_Click(object sender, EventArgs e)
        {

        }

        //Basket movement
        //Using the async & Invoke to prevent overwriting the main task
        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                await Task.Run(()=>MoveBasket(-moveAmount));
            }
            if (e.KeyCode == Keys.Right)
            {
                await Task.Run(() => MoveBasket(moveAmount));
            }
        }

        int moveAmount = 8;
        private void MoveBasket(int amount)
        {
            if (Basket.InvokeRequired)
            {
                Basket.Invoke(new Action(() => Basket.Left += amount));
            }
            else
            {
                Basket.Left += amount; 
            }
        }

        Random random = new Random();
        int pts = 0, hp = 3, fallSpeed = 4;
        bool isGameOver = false;

        void falldown(PictureBox egg)
        {
            switch (SelectedDifficulty)
            {
                case "0":
                    fallSpeed = 2;
                    break;
                case "1":
                    fallSpeed = 3;
                    break;
            }

            if (egg.Top <= this.Height)
            {
                egg.Top += fallSpeed;
            }
            else if (egg.Top > this.Height)
            {
                egg.Location = new Point(random.Next(300, 900), 0);
                hp--;
                Health.Text = "Health: " + hp.ToString();
                if (hp <= 0 && !isGameOver) //added "!isGameOver" to prevent opening new Menu forms (it was annoying)
                {
                    EndGame();
                }
            }

            if (egg.Bounds.IntersectsWith(Basket.Bounds))
            {
                egg.Location = new Point(random.Next(300, 900), 0);
                pts++;
                Points.Text = "Points: " + pts.ToString();
            }
        }

        void EndGame()
        {
            AddScore();
            isGameOver = true;
            timerEgg1.Stop();
            timerEgg2.Stop();
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        void AddScore()
        {
            const string filePath = "highscores.xml";
            List<HighScore> highScores = new List<HighScore>();

            if (File.Exists(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<HighScore>));
                //loading existing highscores
                using (var reader = new StreamReader(filePath))
                {
                    highScores = (List<HighScore>)serializer.Deserialize(reader);
                }

                //saving new score to file
                if (pts > 0)
                {
                    highScores.Add(new HighScore { Score=pts,Nick=Nickname});
                    //XmlSerializer serializer = new XmlSerializer (typeof(List<HighScore>));
                    using (var writer = new StreamWriter(filePath, false))
                    {
                        serializer.Serialize(writer, highScores);
                    }
                }
            }
        }

        private void timerEgg1_Tick(object sender, EventArgs e)
        {
            falldown(Egg1);
        }

        private void timerEgg2_Tick(object sender, EventArgs e)
        {
            falldown(Egg2);
        }
    }
}
