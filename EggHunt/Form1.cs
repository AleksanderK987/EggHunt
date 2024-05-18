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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Basket.Left += -10;
            }
            if (e.KeyCode == Keys.Right)
            {
                Basket.Left += 10;
            }
        }

        Random random = new Random();
        int pts = 0,hp = 3;
        void falldown(PictureBox egg)
        {
            if (egg.Top <= this.Height)
            {
                egg.Top += 3;
            }
            else if (egg.Top > this.Height)
            {
                egg.Location = new Point(random.Next(300, 900), 0);
                hp--;
                Health.Text = "Health: " + hp.ToString();
            }

            if (egg.Bounds.IntersectsWith(Basket.Bounds))
            {
                egg.Location = new Point(random.Next(300, 900), 0);
                pts++;
                Points.Text = "Points: " + pts.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            falldown(Egg);
        }
    }
}
