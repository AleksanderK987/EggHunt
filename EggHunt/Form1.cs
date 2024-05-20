using System.Xml;
using System.Xml.Serialization;
using static System.Formats.Asn1.AsnWriter;

namespace EggHunt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //retrieving the selected difficulty level 
        public string SelectedDifficulty { get; set; }
        public Form1(string difficulty) : this()
        {
            SelectedDifficulty = difficulty;
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

        //basket moves
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Basket.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                Basket.Left += 8;
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
                    fallSpeed = 3;
                    break;
                case "1":
                    fallSpeed = 4;
                    break;
                case "2":
                    fallSpeed = 5;
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

        void bombFalldown(PictureBox bomb)
        {
            switch (SelectedDifficulty)
            {
                case "0":
                    fallSpeed = 3;
                    break;
                case "1":
                    fallSpeed = 4;
                    break;
                case "2":
                    fallSpeed = 5;
                    break;
            }

            if (bomb.Top <= this.Height)
            {
                bomb.Top += fallSpeed;
            }
            else if (bomb.Top > this.Height)
            {
                bomb.Location = new Point(random.Next(300, 900), 0);
            }

            if (bomb.Bounds.IntersectsWith(Basket.Bounds))
            {
                bomb.Location = new Point(random.Next(300, 900), 0);
                hp--;
                Health.Text = "Health: " + hp.ToString();
                if (hp <= 0 && !isGameOver) //added "!isGameOver" to prevent opening new Menu forms (it was annoying)
                {
                    EndGame();
                }
            }
        }

        void AddScore()
        {
            const string filePath = "highscores.xml";

            if (File.Exists(filePath))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                //downloading the existing root
                XmlElement root = doc.DocumentElement;

                //saving new score to XML file
                if (pts > 0)
                {
                    XmlElement scoreElement = doc.CreateElement("Score");
                    scoreElement.InnerText = pts.ToString();
                    root.AppendChild(scoreElement);
                }

                //Saving doc
                doc.Save(filePath);
            }
        }
        
        void EndGame()
        {
            AddScore();
            isGameOver = true;
            timer1.Stop();
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            falldown(Egg);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bombFalldown(Bomb);
        }
    }
}
