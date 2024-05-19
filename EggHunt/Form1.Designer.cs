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
            Egg = new PictureBox();
            Points = new Label();
            Health = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Basket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Egg).BeginInit();
            SuspendLayout();
            // 
            // Basket
            // 
            Basket.BackColor = Color.Transparent;
            Basket.BackgroundImageLayout = ImageLayout.None;
            Basket.Image = (Image)resources.GetObject("Basket.Image");
            Basket.Location = new Point(456, 431);
            Basket.Name = "Basket";
            Basket.Size = new Size(158, 149);
            Basket.SizeMode = PictureBoxSizeMode.StretchImage;
            Basket.TabIndex = 0;
            Basket.TabStop = false;
            Basket.Click += Basket_Click;
            // 
            // Egg
            // 
            Egg.AccessibleName = "Egg";
            Egg.BackColor = Color.Transparent;
            Egg.BackgroundImageLayout = ImageLayout.None;
            Egg.Image = (Image)resources.GetObject("Egg.Image");
            Egg.Location = new Point(788, 9);
            Egg.Name = "Egg";
            Egg.Size = new Size(86, 98);
            Egg.SizeMode = PictureBoxSizeMode.StretchImage;
            Egg.TabIndex = 1;
            Egg.TabStop = false;
            Egg.Click += Egg_Click;
            // 
            // Points
            // 
            Points.AutoSize = true;
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
            Health.Font = new Font("Calibri", 32F, FontStyle.Bold, GraphicsUnit.Point);
            Health.ForeColor = Color.Red;
            Health.Location = new Point(12, 9);
            Health.Name = "Health";
            Health.Size = new Size(186, 53);
            Health.TabIndex = 3;
            Health.Text = "Health: 3";
            Health.Click += Health_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1084, 578);
            Controls.Add(Health);
            Controls.Add(Points);
            Controls.Add(Egg);
            Controls.Add(Basket);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Basket).EndInit();
            ((System.ComponentModel.ISupportInitialize)Egg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Basket;
        private PictureBox Egg;
        private Label Points;
        private Label Health;
        private System.Windows.Forms.Timer timer1;
    }
}
