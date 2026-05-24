namespace ATECQuiZ
{
    partial class Score
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
            this.lbl_games = new System.Windows.Forms.Label();
            this.lbl_congrats = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_correct = new System.Windows.Forms.Label();
            this.lbl_wrong = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.lbl_games.TabIndex = 4;
            this.lbl_games.Text = "ATECQuiz!";
            // 
            // lbl_congrats
            // 
            this.lbl_congrats.AutoSize = true;
            this.lbl_congrats.BackColor = System.Drawing.Color.Transparent;
            this.lbl_congrats.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_congrats.ForeColor = System.Drawing.Color.White;
            this.lbl_congrats.Location = new System.Drawing.Point(294, 196);
            this.lbl_congrats.Name = "lbl_congrats";
            this.lbl_congrats.Size = new System.Drawing.Size(699, 50);
            this.lbl_congrats.TabIndex = 5;
            this.lbl_congrats.Text = "Parabéns! Acabaste o Quiz!";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.BackColor = System.Drawing.Color.Transparent;
            this.lbl_result.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.ForeColor = System.Drawing.Color.White;
            this.lbl_result.Location = new System.Drawing.Point(356, 342);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(211, 36);
            this.lbl_result.TabIndex = 6;
            this.lbl_result.Text = "Resultado:";
            this.lbl_result.Click += new System.EventHandler(this.lbl_result_Click);
            // 
            // lbl_correct
            // 
            this.lbl_correct.AutoSize = true;
            this.lbl_correct.BackColor = System.Drawing.Color.Transparent;
            this.lbl_correct.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correct.ForeColor = System.Drawing.Color.White;
            this.lbl_correct.Location = new System.Drawing.Point(702, 291);
            this.lbl_correct.Name = "lbl_correct";
            this.lbl_correct.Size = new System.Drawing.Size(140, 36);
            this.lbl_correct.TabIndex = 8;
            this.lbl_correct.Text = "Certas";
            this.lbl_correct.Click += new System.EventHandler(this.lbl_correct_Click);
            // 
            // lbl_wrong
            // 
            this.lbl_wrong.AutoSize = true;
            this.lbl_wrong.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wrong.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wrong.ForeColor = System.Drawing.Color.White;
            this.lbl_wrong.Location = new System.Drawing.Point(702, 428);
            this.lbl_wrong.Name = "lbl_wrong";
            this.lbl_wrong.Size = new System.Drawing.Size(167, 36);
            this.lbl_wrong.TabIndex = 9;
            this.lbl_wrong.Text = "Erradas";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(326, 542);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(188, 72);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "button1";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATECQuiZ.Properties.Resources.back1;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_wrong);
            this.Controls.Add(this.lbl_correct);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_congrats);
            this.Controls.Add(this.lbl_games);
            this.Name = "Score";
            this.Text = "Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_games;
        private System.Windows.Forms.Label lbl_congrats;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_correct;
        private System.Windows.Forms.Label lbl_wrong;
        private System.Windows.Forms.Button btn_back;
    }
}