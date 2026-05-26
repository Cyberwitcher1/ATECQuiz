using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using NAudio.Wave;

namespace ATECQuiZ
{
    public partial class Menu : Form
    {
        bool button1Clicked = false;
        bool button2Clicked = false;
        bool button3Clicked = false;
        bool btnSportClicked = false, btnHistoryClicked = false, btnCinemaClicked = false, btnMixClicked = false;

        public Menu()
        {
            InitializeComponent();
            tb_name.Visible = false;
            btn_name.Visible = false;

            if (Program.name == "")
            {
                lbl_name.Text = "Insira o nome do jogador/a";
                tb_name.Visible = true;
                btn_name.Visible = true;
            }
            else
            {
                lbl_name.Text = "Nome do jogador/a " + Program.name;
            }
            UpdateScore(Program.global_score);

            /*SoundPlayer player = new SoundPlayer(@"audio\tumtum.wav");
            player.Load();
            player.Play();*/
        }
        public void UpdateScore(int score)
        {
            lbl_score_updated.Text = "Pontuação atual: " + score.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_games_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (!File.Exists("SCOREBOARD.txt")) 
            {
                File.Create("SCOREBOARD.txt").Close(); 
            }
            else if(Program.global_score != 0 && File.Exists("SCOREBOARD.txt")) {
                using (StreamWriter sw = File.AppendText("SCOREBOARD.txt"))
                {
                    sw.WriteLine(Program.global_score + " " + Program.name); 
                }
            }
            else
            {
            }
            Application.Exit();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (btnSportClicked)
            {
                if (button1Clicked)
                {
                    this.Hide();
                    Sports_1 form2 = new Sports_1();
                    form2.ShowDialog();
                }
                else if (button2Clicked)
                {
                    this.Hide();
                    Sports_2 form3 = new Sports_2();
                    form3.ShowDialog();
                }
                else if (button3Clicked)
                {
                    this.Hide();
                    Sports_3 form4 = new Sports_3();
                    form4.ShowDialog();
                }
            }
            else if (btnHistoryClicked)
            {
                if (button1Clicked)
                {
                    this.Hide();
                    History_1 form5 = new History_1();
                    form5.ShowDialog();
                }
                else if (button2Clicked)
                {
                    this.Hide();
                    History_2 form6 = new History_2();
                    form6.ShowDialog();
                }
                else if (button3Clicked)
                {
                    this.Hide();
                    History_3 form7 = new History_3();
                    form7.ShowDialog();
                }
            }
            else if (btnCinemaClicked)
            {
                if (button1Clicked)
                {
                    this.Hide();
                    Cinema_1 form8 = new Cinema_1();
                    form8.ShowDialog();
                }
                else if (button2Clicked)
                {
                    this.Hide();
                    Cinema_2 form9 = new Cinema_2();
                    form9.ShowDialog();
                }
                else if (button3Clicked)
                {
                    this.Hide();
                    Cinema_3 form10 = new Cinema_3();
                    form10.ShowDialog();
                }
            }
            else if (btnMixClicked)
            {
                if (button1Clicked)
                {
                    this.Hide();
                    Mix_1 form11 = new Mix_1();
                    form11.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            button2Clicked = false;
            button3Clicked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2Clicked = true;
            button1Clicked = false;
            button3Clicked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3Clicked = true;
            button2Clicked = false;
            button1Clicked = false;
        }

        private void btn_sport_Click(object sender, EventArgs e)
        {
            btnSportClicked = true;
            btnHistoryClicked = false;
            btnCinemaClicked = false;
        }

        private void btn_nome_Click(object sender, EventArgs e)
        {
            Program.name = tb_name.Text;
            lbl_name.Text = "Bem vindo/a ao ATECQuiz " + Program.name + "!";
            tb_name.Visible = false;
            btn_name.Visible = false;
        }

        private void lbl_score_updated_Click(object sender, EventArgs e)
        {

        }

        private void btn_leaderboard_Click(object sender, EventArgs e)
        {
            if (!File.Exists("SCOREBOARD.txt"))
            {
                MessageBox.Show("Ainda não existem pontuações registadas! Jogue para aparecerem aqui!");
            }
            else
            {
                {
                    List<string> scoreList = new List<string>();
                    for (int i = 0; i < File.ReadAllLines("SCOREBOARD.txt").Length; i++)
                    {
                        string line = File.ReadAllLines("SCOREBOARD.txt")[i];
                        scoreList.Add(line);
                    }
                    scoreList.Sort();
                    scoreList.Reverse();
                    MessageBox.Show("Top " + (1) + " : " + scoreList[0] + "\nTop " + (2) + " : " + scoreList[1] + "\nTop " + (3) + " : " + scoreList[2]);
                }
            }
        }

        private void btn_mix_Click(object sender, EventArgs e)
        {
            btnMixClicked = true;
            btnHistoryClicked = false;
            btnCinemaClicked = false;
            btnSportClicked = false;
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            btnHistoryClicked = true;
            btnSportClicked = false;
            btnCinemaClicked = false;
        }

        private void btn_cinema_Click(object sender, EventArgs e)
        {
            btnCinemaClicked = true;
            btnSportClicked = false;
            btnHistoryClicked = false;
        }
    }
}