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
        public Score(int correct, int wrong)
        {
            InitializeComponent();
            lbl_correct.Text = "Certas: " + correct.ToString();
            lbl_wrong.Text = "Erradas: " + wrong.ToString();
            lbl_result.Text = "Total: " + correct + " / 10";
        }

        private void lbl_correct_Click(object sender, EventArgs e)
        {
        }

        private void lbl_result_Click(object sender, EventArgs e)
        {

        }
    }
}
