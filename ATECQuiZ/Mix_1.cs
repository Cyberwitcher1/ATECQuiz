using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ATECQuiZ
{
    public partial class Mix_1 : Form
    {
        private int correct = 0;
        private int wrong = 0;
        private int counter = 0;
        private bool button1, button2, button3, button4;
        List<int> random_numbers = new List<int>();
        List<string> all_questions = new List<string>();
        public Mix_1()
        {
            InitializeComponent();

            XmlDocument doc = new XmlDocument();
            doc.Load("quiz.xml");

            RandomLists(random_numbers);

            LoadQuestion();
            int question_check = random_numbers[counter];

        }

        private void LoadQuestion()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("quiz.xml");


            int question_number = random_numbers[counter];


            if (question_number >= 1 && question_number <= 10)
            {
                lbl_mix.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_1/pergunta_{question_number}/texto").InnerText;

                lbl_first.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_1/pergunta_{question_number}/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_1/pergunta_{question_number}/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_1/pergunta_{question_number}/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_1/pergunta_{question_number}/respostas/resposta_4").InnerText;

            }
            else if (question_number >= 11 && question_number <= 20)
            {

                question_number = question_number - 10;

                lbl_mix.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_2/pergunta_{question_number}/texto").InnerText;

                lbl_first.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_2/pergunta_{question_number}/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_2/pergunta_{question_number}/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_2/pergunta_{question_number}/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_2/pergunta_{question_number}/respostas/resposta_4").InnerText;

            }
            else if (question_number >= 21 && question_number <= 30)
            {
                question_number = question_number - 20;

                lbl_mix.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_3/pergunta_{question_number}/texto").InnerText;

                lbl_first.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_3/pergunta_{question_number}/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_3/pergunta_{question_number}/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_3/pergunta_{question_number}/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_3/pergunta_{question_number}/respostas/resposta_4").InnerText;

            }
            else if (question_number >= 31 && question_number <= 40)
            {
                question_number = question_number - 30;

                lbl_mix.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_1/pergunta_{question_number}/texto").InnerText;

                lbl_first.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_1/pergunta_{question_number}/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_1/pergunta_{question_number}/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_1/pergunta_{question_number}/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_1/pergunta_{question_number}/respostas/resposta_4").InnerText;

            }
            else if (question_number >= 41 && question_number <= 50)
            {
                question_number = question_number - 40;

                lbl_mix.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_2/pergunta_{question_number}/texto").InnerText;

                lbl_first.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_2/pergunta_{question_number}/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_2/pergunta_{question_number}/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_2/pergunta_{question_number}/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_2/pergunta_{question_number}/respostas/resposta_4").InnerText;


            }
            else if (question_number >= 51 && question_number <= 60)
            {
                question_number = question_number - 50;

                lbl_mix.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_3/pergunta_{question_number}/texto").InnerText;

                lbl_first.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_3/pergunta_{question_number}/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_3/pergunta_{question_number}/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_3/pergunta_{question_number}/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_3/pergunta_{question_number}/respostas/resposta_4").InnerText;

            }
            else if (question_number >= 61 && question_number <= 70)
            {
                question_number = question_number - 60;

                lbl_mix.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_1/pergunta_{question_number}/texto").InnerText;

                lbl_first.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_1/pergunta_{question_number}/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_1/pergunta_{question_number}/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_1/pergunta_{question_number}/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_1/pergunta_{question_number}/respostas/resposta_4").InnerText;

            }
            else if (question_number >= 71 && question_number <= 80)
            {
                question_number = question_number - 70;

                lbl_mix.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_2/pergunta_{question_number}/texto").InnerText;

                lbl_first.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_2/pergunta_{question_number}/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_2/pergunta_{question_number}/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_2/pergunta_{question_number}/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_2/pergunta_{question_number}/respostas/resposta_4").InnerText;

            }
            else if (question_number >= 81 && question_number <= 90)
            {
                question_number = question_number - 80;

                lbl_mix.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_3/pergunta_{question_number}/texto").InnerText;

                lbl_first.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_3/pergunta_{question_number}/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_3/pergunta_{question_number}/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_3/pergunta_{question_number}/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_3/pergunta_{question_number}/respostas/resposta_4").InnerText;

            }

        }
        private void RandomLists(List<int> random_numbers)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("quiz.xml");


            /* CREATING OF RANDOM NUMBERS FOR THE LISTS SO ITS ALWAYS SHUFFLED WHEN LOADED */
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int num = random.Next(1, 91);
                random_numbers.Add(num);

            }
        }
        private void rb_first_CheckedChanged(object sender, EventArgs e)
        {
            button1 = true;
            button2 = false;
            button3 = false;
            button4 = false;
        }

        private void rb_second_CheckedChanged(object sender, EventArgs e)
        {
            button2 = true;
            button1 = false;
            button3 = false;
            button4 = false;
        }

        private void rb_third_CheckedChanged(object sender, EventArgs e)
        {
            button3 = true;
            button1 = false;
            button2 = false;
            button4 = false;
        }

        private void rb_fourth_CheckedChanged(object sender, EventArgs e)
        {
            button4 = true;
            button1 = false;
            button2 = false;
            button3 = false;
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            rb_first.Checked = true;
            btn_first.BackColor = Color.FromArgb(0, 255, 0);
            btn_second.BackColor = Color.FromArgb(255, 255, 255);
            btn_third.BackColor = Color.FromArgb(255, 255, 255);
            btn_fourth.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_second_Click(object sender, EventArgs e)
        {
            rb_second.Checked = true;
            btn_second.BackColor = Color.FromArgb(0, 255, 0);
            btn_third.BackColor = Color.FromArgb(255, 255, 255);
            btn_first.BackColor = Color.FromArgb(255, 255, 255);
            btn_fourth.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_third_Click(object sender, EventArgs e)
        {
            rb_third.Checked = true;
            btn_third.BackColor = Color.FromArgb(0, 255, 0);
            btn_fourth.BackColor = Color.FromArgb(255, 255, 255);
            btn_first.BackColor = Color.FromArgb(255, 255, 255);
            btn_second.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_fourth_Click(object sender, EventArgs e)
        {
            rb_fourth.Checked = true;
            btn_fourth.BackColor = Color.FromArgb(0, 255, 0);
            btn_first.BackColor = Color.FromArgb(255, 255, 255);
            btn_second.BackColor = Color.FromArgb(255, 255, 255);
            btn_third.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void CheckQuestion()
        {
            int question_number = random_numbers[counter];

            if (button1 == true)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("quiz.xml");

                if (question_number >= 1 && question_number <= 10)
                {
                    if (lbl_first.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_1/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 11 && question_number <= 20)
                {
                    question_number = question_number - 10;
                    if (lbl_first.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_2/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 21 && question_number <= 30)
                {
                    question_number = question_number - 20;
                    if (lbl_first.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_3/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 31 && question_number <= 40)
                {
                    question_number = question_number - 30;
                    if (lbl_first.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_1/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }

                }
                else if (question_number >= 41 && question_number <= 50)
                {
                    question_number = question_number - 40;
                    if (lbl_first.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_2/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }

                }
                else if (question_number >= 51 && question_number <= 60)
                {
                    question_number = question_number - 50;
                    if (lbl_first.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_3/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 61 && question_number <= 70)
                {
                    question_number = question_number - 60;
                    if (lbl_first.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_1/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 71 && question_number <= 80)
                {
                    question_number = question_number - 70;

                    if (lbl_first.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_2/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }


                }
                else if (question_number >= 81 && question_number <= 90)
                {
                    question_number = question_number - 80;

                    if (lbl_first.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_3/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }

                }
            }
            else if (button2 == true)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("quiz.xml");
                if (question_number >= 1 && question_number <= 10)
                {
                    if (lbl_second.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_1/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }

                }
                else if (question_number >= 11 && question_number <= 20)
                {
                    question_number = question_number - 10;
                    if (lbl_second.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_2/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 21 && question_number <= 30)
                {
                    question_number = question_number - 20;
                    if (lbl_second.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_3/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 31 && question_number <= 40)
                {
                    question_number = question_number - 30;
                    if (lbl_second.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_1/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }

                }
                else if (question_number >= 41 && question_number <= 50)
                {
                    question_number = question_number - 40;
                    if (lbl_second.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_2/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }

                }
                else if (question_number >= 51 && question_number <= 60)
                {
                    question_number = question_number - 50;
                    if (lbl_second.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_3/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 61 && question_number <= 70)
                {
                    question_number = question_number - 60;
                    if (lbl_second.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_1/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 71 && question_number <= 80)
                {
                    question_number = question_number - 70;

                    if (lbl_second.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_2/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }


                }
                else if (question_number >= 81 && question_number <= 90)
                {
                    question_number = question_number - 80;

                    if (lbl_second.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_3/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }

                }
            }
            else if (button3 == true)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("quiz.xml");
                if (question_number >= 1 && question_number <= 10)
                {
                    if (lbl_third.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_1/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }

                }
                else if (question_number >= 11 && question_number <= 20)
                {
                    question_number = question_number - 10;
                    if (lbl_third.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_2/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 21 && question_number <= 30)
                {
                    question_number = question_number - 20;
                    if (lbl_third.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_3/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 31 && question_number <= 40)
                {
                    question_number = question_number - 30;
                    if (lbl_third.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_1/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }

                }
                else if (question_number >= 41 && question_number <= 50)
                {
                    question_number = question_number - 40;
                    if (lbl_third.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_2/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }

                }
                else if (question_number >= 51 && question_number <= 60)
                {
                    question_number = question_number - 50;
                    if (lbl_third.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_3/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 61 && question_number <= 70)
                {
                    question_number = question_number - 60;
                    if (lbl_third.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_1/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 71 && question_number <= 80)
                {
                    question_number = question_number - 70;

                    if (lbl_third.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_2/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }


                }
                else if (question_number >= 81 && question_number <= 90)
                {
                    question_number = question_number - 80;

                    if (lbl_third.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_3/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }

                }

            }
            else if (button4 == true)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("quiz.xml");
                if (question_number >= 1 && question_number <= 10)
                {
                    if (lbl_fourth.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_1/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }

                }
                else if (question_number >= 11 && question_number <= 20)
                {
                    question_number = question_number - 10;
                    if (lbl_fourth.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_2/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 21 && question_number <= 30)
                {
                    question_number = question_number - 20;
                    if (lbl_fourth.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_3/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 31 && question_number <= 40)
                {
                    question_number = question_number - 30;
                    if (lbl_fourth.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_1/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }


                }
                else if (question_number >= 41 && question_number <= 50)
                {
                    question_number = question_number - 40;
                    if (lbl_fourth.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_2/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }

                }
                else if (question_number >= 51 && question_number <= 60)
                {
                    question_number = question_number - 50;
                    if (lbl_fourth.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_3/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                }
                else if (question_number >= 61 && question_number <= 70)
                {
                    question_number = question_number - 60;
                    if (lbl_fourth.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_1/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 71 && question_number <= 80)
                {
                    question_number = question_number - 70;

                    if (lbl_fourth.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_2/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                else if (question_number >= 81 && question_number <= 90)
                {
                    question_number = question_number - 80;

                    if(lbl_fourth.Text == doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_3/pergunta_{question_number}/respostacerta").InnerText)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
            }
        }

        private void endingMenu()
        {
            this.Hide();
            Score form2 = new Score(correct, wrong);
            form2.ShowDialog();
        }

        private void btn_answer_Click(object sender, EventArgs e)
        {
            if (rb_first.Checked == false && rb_second.Checked == false && rb_third.Checked == false && rb_fourth.Checked == false)
            {
                MessageBox.Show("Por favor escolha uma opção!");
                return;
            }
            else
            {

            }

            CheckQuestion();

            if (counter == 8)
            {
                btn_answer.Text = "Acabar o jogo";
            }
            if (counter == 9)
            {
                endingMenu();
            }
            else
            {
                counter = counter + 1;
                LoadQuestion();
            }

            rb_first.Checked = false;
            rb_second.Checked = false;
            rb_third.Checked = false;
            rb_fourth.Checked = false;

            btn_first.BackColor = Color.FromArgb(255, 255, 255);
            btn_second.BackColor = Color.FromArgb(255, 255, 255);
            btn_third.BackColor = Color.FromArgb(255, 255, 255);
            btn_fourth.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}