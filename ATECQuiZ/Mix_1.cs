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
        private int counter = 1;
        private bool button1, button2, button3, button4;

        public Mix_1()
        {
            InitializeComponent();

            XmlDocument doc = new XmlDocument();
            doc.Load("quiz.xml");

            List<string> questions_sports = new List<string>();
            List<string> questions_history = new List<string>();
            List<string> questions_cinema = new List<string>();
            List<string> all_questions = new List<string>();
            List<int> random_numbers = new List<int>();

            RandomLists(questions_sports, questions_history, questions_cinema, random_numbers);

            all_questions.AddRange(questions_sports);
            all_questions.AddRange(questions_history);
            all_questions.AddRange(questions_cinema);
            int question_number = 0;
            LoadQuestion(all_questions, random_numbers, question_number);
        }

        private void LoadQuestion(List<string> all_questions, List<int> random_numbers, int question_number)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("quiz.xml");

            if (counter == 1)
            {
                /* WRITES TO THE LABEL THE FIRST RANDOM QUESTION */
                lbl_sport.Text = all_questions[random_numbers[1]];
                /*
                XElement doc  = XElement.Parse(XmlNodeList);




                MessageBox.Show(element1.OuterXml);


                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    lbl_first.Text = element1.ChildNodes[0].InnerText;
                    lbl_second.Text = element1.ChildNodes[1].InnerText;
                    lbl_third.Text = element1.ChildNodes[2].InnerText;
                    lbl_fourth.Text = element1.ChildNodes[3].InnerText;
                }
                */
            }
            if (counter == 2)
            {
                lbl_sport.Text = all_questions[random_numbers[2]];
                question_number = random_numbers[2];

                XmlElement element = doc.GetElementById(question_number.ToString());
                element.Attributes.Append(doc.CreateAttribute("id"));

                foreach (XmlNode node in element.ChildNodes)
                {
                    lbl_first.Text = element.ChildNodes[0].InnerText;
                    lbl_second.Text = element.ChildNodes[1].InnerText;
                    lbl_third.Text = element.ChildNodes[2].InnerText;
                    lbl_fourth.Text = element.ChildNodes[3].InnerText;
                }

            }
            if (counter == 3)
            {
                lbl_sport.Text = all_questions[random_numbers[3]];
                question_number = random_numbers[3];


                XmlElement element = doc.GetElementById(question_number.ToString());

                foreach (XmlNode node in element.ChildNodes)
                {
                    lbl_first.Text = element.ChildNodes[0].InnerText;
                    lbl_second.Text = element.ChildNodes[1].InnerText;
                    lbl_third.Text = element.ChildNodes[2].InnerText;
                    lbl_fourth.Text = element.ChildNodes[3].InnerText;
                }
            }
            if (counter == 4)
            {
                lbl_sport.Text = all_questions[random_numbers[4]];
                question_number = random_numbers[4];

                XmlElement element = doc.GetElementById(question_number.ToString());

                foreach (XmlNode node in element.ChildNodes)
                {
                    lbl_first.Text = element.ChildNodes[0].InnerText;
                    lbl_second.Text = element.ChildNodes[1].InnerText;
                    lbl_third.Text = element.ChildNodes[2].InnerText;
                    lbl_fourth.Text = element.ChildNodes[3].InnerText;
                }

            }
            if (counter == 5)
            {
                lbl_sport.Text = all_questions[random_numbers[5]];
                question_number = random_numbers[5];

                XmlElement element = doc.GetElementById(question_number.ToString());

                foreach (XmlNode node in element.ChildNodes)
                {
                    lbl_first.Text = element.ChildNodes[0].InnerText;
                    lbl_second.Text = element.ChildNodes[1].InnerText;
                    lbl_third.Text = element.ChildNodes[2].InnerText;
                    lbl_fourth.Text = element.ChildNodes[3].InnerText;
                }
            }
            if (counter == 6)
            {
                lbl_sport.Text = all_questions[random_numbers[6]];
                question_number = random_numbers[6];

                XmlElement element = doc.GetElementById(question_number.ToString());

                foreach (XmlNode node in element.ChildNodes)
                {
                    lbl_first.Text = element.ChildNodes[0].InnerText;
                    lbl_second.Text = element.ChildNodes[1].InnerText;
                    lbl_third.Text = element.ChildNodes[2].InnerText;
                    lbl_fourth.Text = element.ChildNodes[3].InnerText;
                }
            }
            if (counter == 7)
            {
                lbl_sport.Text = all_questions[random_numbers[7]];
                question_number = random_numbers[7];

                XmlElement element = doc.GetElementById(question_number.ToString());

                foreach (XmlNode node in element.ChildNodes)
                {
                    lbl_first.Text = element.ChildNodes[0].InnerText;
                    lbl_second.Text = element.ChildNodes[1].InnerText;
                    lbl_third.Text = element.ChildNodes[2].InnerText;
                    lbl_fourth.Text = element.ChildNodes[3].InnerText;
                }
            }
            if (counter == 8)
            {
                lbl_sport.Text = all_questions[random_numbers[8]];
                question_number = random_numbers[8];

                XmlElement element = doc.GetElementById(question_number.ToString());

                foreach (XmlNode node in element.ChildNodes)
                {
                    lbl_first.Text = element.ChildNodes[0].InnerText;
                    lbl_second.Text = element.ChildNodes[1].InnerText;
                    lbl_third.Text = element.ChildNodes[2].InnerText;
                    lbl_fourth.Text = element.ChildNodes[3].InnerText;
                }
            }
            if (counter == 9)
            {
                lbl_sport.Text = all_questions[random_numbers[9]];
                question_number = random_numbers[9];

                XmlElement element = doc.GetElementById(question_number.ToString());

                foreach (XmlNode node in element.ChildNodes)
                {
                    lbl_first.Text = element.ChildNodes[0].InnerText;
                    lbl_second.Text = element.ChildNodes[1].InnerText;
                    lbl_third.Text = element.ChildNodes[2].InnerText;
                    lbl_fourth.Text = element.ChildNodes[3].InnerText;
                }
            }
            if (counter == 10)
            {
                lbl_sport.Text = all_questions[random_numbers[10]];
                question_number = random_numbers[10];

                XmlElement element = doc.GetElementById(question_number.ToString());

                foreach (XmlNode node in element.ChildNodes)
                {
                    lbl_first.Text = element.ChildNodes[0].InnerText;
                    lbl_second.Text = element.ChildNodes[1].InnerText;
                    lbl_third.Text = element.ChildNodes[2].InnerText;
                    lbl_fourth.Text = element.ChildNodes[3].InnerText;
                }
            }
            if (counter == 11)
            {
                endingMenu();
            }
        }

        private void RandomLists(List<string> questions_sports, List<string> questions_history, List<string> questions_cinema, List<int> random_numbers)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("quiz.xml");


            /* CREATION OF ALL POSSIBLE QUESTIONS */

            for (int i = 1; i < 11; i++)
            {
                string nodeSport_1 = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_1/pergunta_{i}/texto").InnerText;
                string nodeSport_2 = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_2/pergunta_{i}/texto").InnerText;
                string nodeSport_3 = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_3/pergunta_{i}/texto").InnerText;

                questions_sports.Add(nodeSport_1);
                questions_sports.Add(nodeSport_2);
                questions_sports.Add(nodeSport_3);
            }

            for (int i = 1; i < 11; i++)
            {
                string nodeHistory_1 = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_1/pergunta_{i}/texto").InnerText;
                string nodeHistory_2 = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_2/pergunta_{i}/texto").InnerText;
                string nodeHistory_3 = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_3/pergunta_{i}/texto").InnerText;

                questions_history.Add(nodeHistory_1);
                questions_history.Add(nodeHistory_2);
                questions_history.Add(nodeHistory_3);
            }
            for (int i = 1; i < 11; i++)
            {
                string nodeCinema_1 = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_1/pergunta_{i}/texto").InnerText;
                string nodeCinema_2 = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_2/pergunta_{i}/texto").InnerText;
                string nodeCinema_3 = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_3/pergunta_{i}/texto").InnerText;

                questions_cinema.Add(nodeCinema_1);
                questions_cinema.Add(nodeCinema_2);
                questions_cinema.Add(nodeCinema_3);
            }

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

        private void CheckQuestion(int question_number)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("quiz.xml");
            if (question_number >= 1 && question_number <= 11)
            {


                string correct_answer = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_1/pergunta_{counter}/resposta_correta").InnerText;
                if (button1 == true && rb_first.Text == correct_answer)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }
            }
            if (question_number >= 11 && question_number <= 21)
            {
                string correct_answer = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_2/pergunta_{counter}/resposta_correta").InnerText;
                if (button1 == true && rb_first.Text == correct_answer)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }
            }
            if (question_number >= 21 && question_number <= 31)
            {
                string correct_answer = doc.SelectSingleNode($"/quiz/perguntas/tema_desporto/nivel_3/pergunta_{counter}/resposta_correta").InnerText;
                if (button1 == true && rb_first.Text == correct_answer)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }
            }
            if (question_number >= 31 && question_number <= 41)
            {
                string correct_answer = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_1/pergunta_{counter}/resposta_correta").InnerText;
                if (button1 == true && rb_first.Text == correct_answer)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }
            }
            if (question_number >= 41 && question_number <= 51)
            {
                string correct_answer = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_2/pergunta_{counter}/resposta_correta").InnerText;
                if (button1 == true && rb_first.Text == correct_answer)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }
            }
            if (question_number >= 51 && question_number <= 61)
            {
                string correct_answer = doc.SelectSingleNode($"/quiz/perguntas/tema_historia/nivel_3/pergunta_{counter}/resposta_correta").InnerText;
                if (button1 == true && rb_first.Text == correct_answer)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }
            }
            if (question_number >= 61 && question_number <= 71)
            {
                string correct_answer = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_1/pergunta_{counter}/resposta_correta").InnerText;
                if (button1 == true && rb_first.Text == correct_answer)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }
            }
            if (question_number >= 71 && question_number <= 81)
            {
                string correct_answer = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_2/pergunta_{counter}/resposta_correta").InnerText;
                if (button1 == true && rb_first.Text == correct_answer)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
                }
            }
            if (question_number >= 81 && question_number <= 91)
            {
                string correct_answer = doc.SelectSingleNode($"/quiz/perguntas/tema_cinema/nivel_3/pergunta_{counter}/resposta_correta").InnerText;
                if (button1 == true && rb_first.Text == correct_answer)
                {
                    correct = correct + 1;
                }
                else
                {
                    wrong = wrong + 1;
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
            counter = counter + 1;
        }
    }
}
