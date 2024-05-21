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
            play = new Button();
            Title = new Label();
            highScoreTitle = new Label();
            highscores = new RichTextBox();
            difficulty = new ComboBox();
            exit = new Button();
            nickname = new TextBox();
            SuspendLayout();
            // 
            // play
            // 
            play.Location = new Point(12, 144);
            play.Name = "play";
            play.Size = new Size(195, 41);
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
            highscores.Size = new Size(171, 148);
            highscores.TabIndex = 5;
            highscores.Text = "";
            highscores.TextChanged += highscores_TextChanged;
            // 
            // difficulty
            // 
            difficulty.FormattingEnabled = true;
            difficulty.Items.AddRange(new object[] { "Easy", "Hard" });
            difficulty.Location = new Point(47, 115);
            difficulty.Name = "difficulty";
            difficulty.Size = new Size(121, 23);
            difficulty.TabIndex = 6;
            difficulty.SelectedIndexChanged += difficulty_SelectedIndexChanged;
            // 
            // exit
            // 
            exit.Location = new Point(12, 191);
            exit.Name = "exit";
            exit.Size = new Size(195, 40);
            exit.TabIndex = 7;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // nickname
            // 
            nickname.Location = new Point(47, 86);
            nickname.Name = "nickname";
            nickname.Size = new Size(122, 23);
            nickname.TabIndex = 8;
            nickname.TextChanged += nickname_TextChanged;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 242);
            Controls.Add(nickname);
            Controls.Add(exit);
            Controls.Add(difficulty);
            Controls.Add(highscores);
            Controls.Add(highScoreTitle);
            Controls.Add(Title);
            Controls.Add(play);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
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
        private TextBox nickname;
    }
}