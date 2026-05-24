using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATECQuiZ
{
    public partial class Score : Form
    {
        public int local_correct;
        public int local_score;
        public int score_before;

        public Score(int correct, int wrong)
        {
            InitializeComponent();
            lbl_correct.Text = "Certas: " + correct.ToString();
            lbl_wrong.Text = "Erradas: " + wrong.ToString();
            lbl_result.Text = "Total: " + correct + " / 10";
            local_correct = correct;
            local_score = local_correct * 10;
        }

        private void lbl_correct_Click(object sender, EventArgs e)
        {

        }

        private void lbl_result_Click(object sender, EventArgs e)
        {

        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            Menu form1 = new Menu();
            Program.global_score = Program.global_score + local_score;
            form1.UpdateScore(Program.global_score);    
            form1.Show();
            this.Hide();
        }
    }
}
