using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ATECQuiZ
{
    public partial class History_3 : Form
    {
        private int correct = 0;
        private int wrong = 0;
        private int counter = 1;
        private bool button1, button2, button3, button4;

        public History_3()
        {
            InitializeComponent();
            XmlDocument doc = new XmlDocument();
            doc.Load("quiz.xml");

            XmlNodeList nodelist = doc.SelectNodes("/quiz/perguntas/tema_historia/nivel_3/pergunta_1/texto");

            foreach (XmlNode node in nodelist)
            {
                lbl_sport.Text = node.InnerText;
            }

            XmlNodeList firstNode = doc.SelectNodes("/quiz/perguntas/tema_historia/nivel_3/pergunta_1/respostas/resposta_1");

            foreach (XmlNode node in firstNode)
            {
                lbl_first.Text = node.InnerText;
            }

            XmlNodeList secondNode = doc.SelectNodes("/quiz/perguntas/tema_historia/nivel_3/pergunta_1/respostas/resposta_2");


            foreach (XmlNode node in secondNode)
            {
                lbl_second.Text = node.InnerText;
            }

            XmlNodeList thirdNode = doc.SelectNodes("/quiz/perguntas/tema_historia/nivel_3/pergunta_1/respostas/resposta_3");

            foreach (XmlNode node in thirdNode)
            {
                lbl_third.Text = node.InnerText;
            }

            XmlNodeList fourthNode = doc.SelectNodes("/quiz/perguntas/tema_historia/nivel_3/pergunta_1/respostas/resposta_4");

            foreach (XmlNode node in fourthNode)
            {
                lbl_fourth.Text = node.InnerText;
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

        private void LoadQuestion()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("quiz.xml");
            if (counter == 2)
            {
                lbl_sport.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_2/texto").InnerText;
                lbl_first.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_2/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_2/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_2/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_2/respostas/resposta_4").InnerText;
            }
            if (counter == 3)
            {
                lbl_sport.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_3/texto").InnerText;
                lbl_first.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_3/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_3/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_3/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_3/respostas/resposta_4").InnerText;
            }
            if (counter == 4)
            {
                lbl_sport.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_4/texto").InnerText;
                lbl_first.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_4/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_4/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_4/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_4/respostas/resposta_4").InnerText;
            }
            if (counter == 5)
            {
                lbl_sport.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_5/texto").InnerText;
                lbl_first.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_5/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_5/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_5/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_5/respostas/resposta_4").InnerText;
            }
            if (counter == 6)
            {
                lbl_sport.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_6/texto").InnerText;
                lbl_first.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_6/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_6/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_6/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_6/respostas/resposta_4").InnerText;
            }
            if (counter == 7)
            {
                lbl_sport.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_7/texto").InnerText;
                lbl_first.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_7/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_7/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_7/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_7/respostas/resposta_4").InnerText;
            }
            if (counter == 8)
            {
                lbl_sport.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_8/texto").InnerText;
                lbl_first.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_8/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_8/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_8/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_8/respostas/resposta_4").InnerText;
            }
            if (counter == 9)
            {
                lbl_sport.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_9/texto").InnerText;
                lbl_first.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_9/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_9/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_9/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_9/respostas/resposta_4").InnerText;
            }
            if (counter == 10)
            {
                lbl_sport.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_10/texto").InnerText;
                lbl_first.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_10/respostas/resposta_1").InnerText;
                lbl_second.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_10/respostas/resposta_2").InnerText;
                lbl_third.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_10/respostas/resposta_3").InnerText;
                lbl_fourth.Text = doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_10/respostas/resposta_4").InnerText;

            }
            if (counter == 11)
            {
                endingMenu();
            }

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
            XmlDocument doc = new XmlDocument();
            doc.Load("quiz.xml");


            if (button1 == true)
            {

                if (doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_" + counter + "/respostacerta").InnerText == lbl_first.Text)
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }
            }
            else if (button2 == true)
            {
                if (doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_" + counter + "/respostacerta").InnerText == lbl_second.Text)
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }
            }
            else if (button3 == true)
            {
                if (doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_" + counter + "/respostacerta").InnerText == lbl_third.Text)
                {
                    correct++;
                }
                else
                {
                    wrong++;
                }
            }
            else if (button4 == true)
            {
                if (doc.SelectSingleNode("/quiz/perguntas/tema_historia/nivel_3/pergunta_" + counter + "/respostacerta").InnerText == lbl_fourth.Text)
                {
                    correct++;
                }
                else
                {
                    wrong++;
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
            counter = counter + 1;
            LoadQuestion();
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
