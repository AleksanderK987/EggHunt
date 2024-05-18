namespace EggHunt
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            easy = new Button();
            medium = new Button();
            hard = new Button();
            Title = new Label();
            highScoreTitle = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // easy
            // 
            easy.Location = new Point(12, 82);
            easy.Name = "easy";
            easy.Size = new Size(189, 51);
            easy.TabIndex = 0;
            easy.Text = "Easy";
            easy.UseVisualStyleBackColor = true;
            // 
            // medium
            // 
            medium.Location = new Point(12, 139);
            medium.Name = "medium";
            medium.Size = new Size(189, 51);
            medium.TabIndex = 1;
            medium.Text = "Medium";
            medium.UseVisualStyleBackColor = true;
            // 
            // hard
            // 
            hard.Location = new Point(12, 197);
            hard.Name = "hard";
            hard.Size = new Size(189, 51);
            hard.TabIndex = 2;
            hard.Text = "Hard";
            hard.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("SimSun-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(12, 18);
            Title.Name = "Title";
            Title.Size = new Size(195, 48);
            Title.TabIndex = 3;
            Title.Text = "EggHunt";
            // 
            // highScoreTitle
            // 
            highScoreTitle.AutoSize = true;
            highScoreTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            highScoreTitle.Location = new Point(295, 51);
            highScoreTitle.Name = "highScoreTitle";
            highScoreTitle.Size = new Size(112, 28);
            highScoreTitle.TabIndex = 4;
            highScoreTitle.Text = "Highscores:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(240, 82);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(210, 166);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 284);
            Controls.Add(richTextBox1);
            Controls.Add(highScoreTitle);
            Controls.Add(Title);
            Controls.Add(hard);
            Controls.Add(medium);
            Controls.Add(easy);
            Name = "Menu";
            Text = "prze";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button easy;
        private Button medium;
        private Button hard;
        private Label Title;
        private Label highScoreTitle;
        private RichTextBox richTextBox1;
    }
}