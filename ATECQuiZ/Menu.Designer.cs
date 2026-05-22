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
            this.lbl_games = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_level1 = new System.Windows.Forms.Button();
            this.btn_level3 = new System.Windows.Forms.Button();
            this.btn_level2 = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_cinema = new System.Windows.Forms.Button();
            this.btn_sport = new System.Windows.Forms.Button();
            this.btn_mix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_start.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_start.Location = new System.Drawing.Point(250, 350);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(200, 100);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Começar jogo!";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_exit.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_exit.Location = new System.Drawing.Point(850, 350);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(200, 100);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Sair";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_games
            // 
            this.lbl_games.AutoSize = true;
            this.lbl_games.BackColor = System.Drawing.Color.Transparent;
            this.lbl_games.Font = new System.Drawing.Font("Ravie", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_games.ForeColor = System.Drawing.Color.White;
            this.lbl_games.Location = new System.Drawing.Point(292, 45);
            this.lbl_games.Name = "lbl_games";
            this.lbl_games.Size = new System.Drawing.Size(701, 129);
            this.lbl_games.TabIndex = 3;
            this.lbl_games.Text = "ATECQuiz!";
            this.lbl_games.Click += new System.EventHandler(this.lbl_games_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(458, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de Jogo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(676, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dificuldade";
            // 
            // btn_level1
            // 
            this.btn_level1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_level1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_level1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_level1.Location = new System.Drawing.Point(700, 325);
            this.btn_level1.Name = "btn_level1";
            this.btn_level1.Size = new System.Drawing.Size(100, 50);
            this.btn_level1.TabIndex = 7;
            this.btn_level1.Text = "Level1";
            this.btn_level1.UseVisualStyleBackColor = false;
            this.btn_level1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_level3
            // 
            this.btn_level3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_level3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_level3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_level3.Location = new System.Drawing.Point(700, 425);
            this.btn_level3.Name = "btn_level3";
            this.btn_level3.Size = new System.Drawing.Size(100, 50);
            this.btn_level3.TabIndex = 8;
            this.btn_level3.Text = "Level3";
            this.btn_level3.UseVisualStyleBackColor = false;
            this.btn_level3.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_level2
            // 
            this.btn_level2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_level2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_level2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_level2.Location = new System.Drawing.Point(700, 375);
            this.btn_level2.Name = "btn_level2";
            this.btn_level2.Size = new System.Drawing.Size(100, 50);
            this.btn_level2.TabIndex = 9;
            this.btn_level2.Text = "Level2";
            this.btn_level2.UseVisualStyleBackColor = false;
            this.btn_level2.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_history
            // 
            this.btn_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_history.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_history.ForeColor = System.Drawing.Color.White;
            this.btn_history.Location = new System.Drawing.Point(500, 375);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(100, 50);
            this.btn_history.TabIndex = 12;
            this.btn_history.Text = "História";
            this.btn_history.UseVisualStyleBackColor = false;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_cinema
            // 
            this.btn_cinema.BackColor = System.Drawing.Color.Indigo;
            this.btn_cinema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cinema.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cinema.ForeColor = System.Drawing.Color.White;
            this.btn_cinema.Location = new System.Drawing.Point(500, 425);
            this.btn_cinema.Name = "btn_cinema";
            this.btn_cinema.Size = new System.Drawing.Size(100, 50);
            this.btn_cinema.TabIndex = 11;
            this.btn_cinema.Text = "Cinema";
            this.btn_cinema.UseVisualStyleBackColor = false;
            this.btn_cinema.Click += new System.EventHandler(this.btn_cinema_Click);
            // 
            // btn_sport
            // 
            this.btn_sport.BackColor = System.Drawing.Color.White;
            this.btn_sport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sport.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sport.Location = new System.Drawing.Point(500, 325);
            this.btn_sport.Name = "btn_sport";
            this.btn_sport.Size = new System.Drawing.Size(100, 50);
            this.btn_sport.TabIndex = 10;
            this.btn_sport.Text = "Desporto";
            this.btn_sport.UseVisualStyleBackColor = false;
            this.btn_sport.Click += new System.EventHandler(this.btn_sport_Click);
            // 
            // btn_mix
            // 
            this.btn_mix.BackColor = System.Drawing.Color.Gold;
            this.btn_mix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mix.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mix.ForeColor = System.Drawing.Color.Black;
            this.btn_mix.Location = new System.Drawing.Point(548, 481);
            this.btn_mix.Name = "btn_mix";
            this.btn_mix.Size = new System.Drawing.Size(211, 106);
            this.btn_mix.TabIndex = 13;
            this.btn_mix.Text = "Mix ATEC! (Incompleto)";
            this.btn_mix.UseVisualStyleBackColor = false;
            this.btn_mix.Click += new System.EventHandler(this.btn_mix_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATECQuiZ.Properties.Resources.back1;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_mix);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.btn_cinema);
            this.Controls.Add(this.btn_sport);
            this.Controls.Add(this.btn_level2);
            this.Controls.Add(this.btn_level3);
            this.Controls.Add(this.btn_level1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_games);
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
        private System.Windows.Forms.Label lbl_games;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_level1;
        private System.Windows.Forms.Button btn_level3;
        private System.Windows.Forms.Button btn_level2;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_cinema;
        private System.Windows.Forms.Button btn_sport;
        private System.Windows.Forms.Button btn_mix;
    }
}

