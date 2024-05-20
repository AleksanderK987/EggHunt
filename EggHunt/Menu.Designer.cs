﻿namespace EggHunt
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
            play = new Button();
            Title = new Label();
            highScoreTitle = new Label();
            highscores = new RichTextBox();
            difficulty = new ComboBox();
            exit = new Button();
            SuspendLayout();
            // 
            // play
            // 
            play.Location = new Point(12, 83);
            play.Name = "play";
            play.Size = new Size(195, 51);
            play.TabIndex = 0;
            play.Text = "Play";
            play.UseVisualStyleBackColor = true;
            play.Click += play_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("SimSun-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(12, 20);
            Title.Name = "Title";
            Title.Size = new Size(195, 48);
            Title.TabIndex = 3;
            Title.Text = "EggHunt";
            // 
            // highScoreTitle
            // 
            highScoreTitle.AutoSize = true;
            highScoreTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            highScoreTitle.Location = new Point(240, 40);
            highScoreTitle.Name = "highScoreTitle";
            highScoreTitle.Size = new Size(112, 28);
            highScoreTitle.TabIndex = 4;
            highScoreTitle.Text = "Highscores:";
            // 
            // highscores
            // 
            highscores.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            highscores.Location = new Point(240, 83);
            highscores.Name = "highscores";
            highscores.Size = new Size(112, 137);
            highscores.TabIndex = 5;
            highscores.Text = "";
            highscores.TextChanged += highscores_TextChanged;
            // 
            // difficulty
            // 
            difficulty.FormattingEnabled = true;
            difficulty.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            difficulty.Location = new Point(48, 140);
            difficulty.Name = "difficulty";
            difficulty.Size = new Size(121, 23);
            difficulty.TabIndex = 6;
            difficulty.SelectedIndexChanged += difficulty_SelectedIndexChanged;
            // 
            // exit
            // 
            exit.Location = new Point(12, 169);
            exit.Name = "exit";
            exit.Size = new Size(195, 51);
            exit.TabIndex = 7;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 235);
            Controls.Add(exit);
            Controls.Add(difficulty);
            Controls.Add(highscores);
            Controls.Add(highScoreTitle);
            Controls.Add(Title);
            Controls.Add(play);
            Name = "Menu";
            Text = "prze";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button play;
        private Label Title;
        private Label highScoreTitle;
        private RichTextBox highscores;
        private ComboBox difficulty;
        private Button exit;
    }
}