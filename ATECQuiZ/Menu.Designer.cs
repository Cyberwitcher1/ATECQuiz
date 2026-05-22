namespace ATECQuiZ
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.cbb_games = new System.Windows.Forms.ComboBox();
            this.lbl_games = new System.Windows.Forms.Label();
            this.cbb_difficulty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_level1 = new System.Windows.Forms.Button();
            this.btn_level3 = new System.Windows.Forms.Button();
            this.btn_level2 = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_cinema = new System.Windows.Forms.Button();
            this.btn_sport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_start.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_start.Location = new System.Drawing.Point(250, 350);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(186, 94);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Começar jogo!";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_exit.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_exit.Location = new System.Drawing.Point(950, 350);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(185, 94);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Sair";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // cbb_games
            // 
            this.cbb_games.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_games.FormattingEnabled = true;
            this.cbb_games.Items.AddRange(new object[] {
            "Desporto",
            "História",
            "Cinema"});
            this.cbb_games.Location = new System.Drawing.Point(301, 208);
            this.cbb_games.Name = "cbb_games";
            this.cbb_games.Size = new System.Drawing.Size(121, 33);
            this.cbb_games.TabIndex = 2;
            // 
            // lbl_games
            // 
            this.lbl_games.AutoSize = true;
            this.lbl_games.BackColor = System.Drawing.Color.Transparent;
            this.lbl_games.Font = new System.Drawing.Font("Ravie", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_games.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_games.Location = new System.Drawing.Point(292, 45);
            this.lbl_games.Name = "lbl_games";
            this.lbl_games.Size = new System.Drawing.Size(701, 129);
            this.lbl_games.TabIndex = 3;
            this.lbl_games.Text = "ATECQuiz!";
            this.lbl_games.Click += new System.EventHandler(this.lbl_games_Click);
            // 
            // cbb_difficulty
            // 
            this.cbb_difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_difficulty.FormattingEnabled = true;
            this.cbb_difficulty.Items.AddRange(new object[] {
            "Level1",
            "Level2",
            "Level3"});
            this.cbb_difficulty.Location = new System.Drawing.Point(616, 555);
            this.cbb_difficulty.Name = "cbb_difficulty";
            this.cbb_difficulty.Size = new System.Drawing.Size(121, 33);
            this.cbb_difficulty.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(540, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(690, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dificuldade";
            // 
            // btn_level1
            // 
            this.btn_level1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_level1.Location = new System.Drawing.Point(725, 325);
            this.btn_level1.Name = "btn_level1";
            this.btn_level1.Size = new System.Drawing.Size(96, 32);
            this.btn_level1.TabIndex = 7;
            this.btn_level1.Text = "Level1";
            this.btn_level1.UseVisualStyleBackColor = false;
            this.btn_level1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_level3
            // 
            this.btn_level3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_level3.Location = new System.Drawing.Point(725, 425);
            this.btn_level3.Name = "btn_level3";
            this.btn_level3.Size = new System.Drawing.Size(96, 32);
            this.btn_level3.TabIndex = 8;
            this.btn_level3.Text = "Level3";
            this.btn_level3.UseVisualStyleBackColor = false;
            this.btn_level3.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_level2
            // 
            this.btn_level2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_level2.Location = new System.Drawing.Point(725, 375);
            this.btn_level2.Name = "btn_level2";
            this.btn_level2.Size = new System.Drawing.Size(96, 31);
            this.btn_level2.TabIndex = 9;
            this.btn_level2.Text = "Level2";
            this.btn_level2.UseVisualStyleBackColor = false;
            this.btn_level2.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_history
            // 
            this.btn_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_history.Location = new System.Drawing.Point(525, 375);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(96, 31);
            this.btn_history.TabIndex = 12;
            this.btn_history.Text = "História";
            this.btn_history.UseVisualStyleBackColor = false;
            // 
            // btn_cinema
            // 
            this.btn_cinema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cinema.Location = new System.Drawing.Point(525, 425);
            this.btn_cinema.Name = "btn_cinema";
            this.btn_cinema.Size = new System.Drawing.Size(96, 32);
            this.btn_cinema.TabIndex = 11;
            this.btn_cinema.Text = "Cinema";
            this.btn_cinema.UseVisualStyleBackColor = false;
            // 
            // btn_sport
            // 
            this.btn_sport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_sport.Location = new System.Drawing.Point(525, 325);
            this.btn_sport.Name = "btn_sport";
            this.btn_sport.Size = new System.Drawing.Size(96, 32);
            this.btn_sport.TabIndex = 10;
            this.btn_sport.Text = "Desporto";
            this.btn_sport.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATECQuiZ.Properties.Resources.back1;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.btn_cinema);
            this.Controls.Add(this.btn_sport);
            this.Controls.Add(this.btn_level2);
            this.Controls.Add(this.btn_level3);
            this.Controls.Add(this.btn_level1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_difficulty);
            this.Controls.Add(this.lbl_games);
            this.Controls.Add(this.cbb_games);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_start);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cbb_games;
        private System.Windows.Forms.Label lbl_games;
        private System.Windows.Forms.ComboBox cbb_difficulty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_level1;
        private System.Windows.Forms.Button btn_level3;
        private System.Windows.Forms.Button btn_level2;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_cinema;
        private System.Windows.Forms.Button btn_sport;
    }
}

