namespace EggHunt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Basket = new PictureBox();
            Egg1 = new PictureBox();
            Points = new Label();
            Health = new Label();
            timerEgg1 = new System.Windows.Forms.Timer(components);
            timerEgg2 = new System.Windows.Forms.Timer(components);
            Egg2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Basket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Egg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Egg2).BeginInit();
            SuspendLayout();
            // 
            // Basket
            // 
            Basket.BackColor = Color.Transparent;
            Basket.BackgroundImageLayout = ImageLayout.None;
            Basket.Image = (Image)resources.GetObject("Basket.Image");
            Basket.Location = new Point(468, 446);
            Basket.Name = "Basket";
            Basket.Size = new Size(127, 120);
            Basket.SizeMode = PictureBoxSizeMode.StretchImage;
            Basket.TabIndex = 0;
            Basket.TabStop = false;
            Basket.Click += Basket_Click;
            // 
            // Egg1
            // 
            Egg1.AccessibleName = "Egg";
            Egg1.BackColor = Color.Transparent;
            Egg1.BackgroundImageLayout = ImageLayout.None;
            Egg1.Image = (Image)resources.GetObject("Egg1.Image");
            Egg1.Location = new Point(550, 21);
            Egg1.Name = "Egg1";
            Egg1.Size = new Size(64, 76);
            Egg1.SizeMode = PictureBoxSizeMode.StretchImage;
            Egg1.TabIndex = 1;
            Egg1.TabStop = false;
            Egg1.Click += Egg_Click;
            // 
            // Points
            // 
            Points.AutoSize = true;
            Points.BackColor = Color.Transparent;
            Points.Font = new Font("Calibri", 32F, FontStyle.Bold, GraphicsUnit.Point);
            Points.ForeColor = Color.LimeGreen;
            Points.Location = new Point(894, 9);
            Points.Name = "Points";
            Points.Size = new Size(178, 53);
            Points.TabIndex = 2;
            Points.Text = "Points: 0";
            Points.Click += Points_Click;
            // 
            // Health
            // 
            Health.AutoSize = true;
            Health.BackColor = Color.Transparent;
            Health.Font = new Font("Calibri", 32F, FontStyle.Bold, GraphicsUnit.Point);
            Health.ForeColor = Color.Red;
            Health.Location = new Point(12, 9);
            Health.Name = "Health";
            Health.Size = new Size(186, 53);
            Health.TabIndex = 3;
            Health.Text = "Health: 3";
            Health.Click += Health_Click;
            // 
            // timerEgg1
            // 
            timerEgg1.Enabled = true;
            timerEgg1.Interval = 10;
            timerEgg1.Tick += timerEgg1_Tick;
            // 
            // timerEgg2
            // 
            timerEgg2.Enabled = true;
            timerEgg2.Interval = 20;
            timerEgg2.Tick += timerEgg2_Tick;
            // 
            // Egg2
            // 
            Egg2.AccessibleName = "Egg2";
            Egg2.BackColor = Color.Transparent;
            Egg2.BackgroundImageLayout = ImageLayout.None;
            Egg2.Image = (Image)resources.GetObject("Egg2.Image");
            Egg2.Location = new Point(158, 93);
            Egg2.Name = "Egg2";
            Egg2.Size = new Size(64, 76);
            Egg2.SizeMode = PictureBoxSizeMode.StretchImage;
            Egg2.TabIndex = 5;
            Egg2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 149, 255);
            ClientSize = new Size(1080, 564);
            Controls.Add(Egg2);
            Controls.Add(Health);
            Controls.Add(Points);
            Controls.Add(Egg1);
            Controls.Add(Basket);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Basket).EndInit();
            ((System.ComponentModel.ISupportInitialize)Egg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Egg2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Basket;
        private PictureBox Egg1;
        private Label Points;
        private Label Health;
        private System.Windows.Forms.Timer timerEgg1;
        private System.Windows.Forms.Timer timerEgg2;
        private PictureBox Egg2;
    }
}
