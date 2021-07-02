using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Designer
{
   
    public partial class Creator : Form
    {
        public Test test = new Test();
        public List<Question> questions = new List<Question>();
        Questions Q = new Questions();
        public Creator()
        {
            InitializeComponent();
            button4.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }

        //private Test test = new Test();
        //private List<Question> questions = new List<Question>();
        //Questions Q = new Questions();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;


            using (FileStream fs = new FileStream($"{textBox1.Text}_{textBox2.Text}.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Test));
                test.Author = textBox1.Text;
                test.Name = textBox2.Text;
                test.Number = textBox5.Text;

                formatter.Serialize(fs, test);
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = true;

            listBox1.Items.Add(textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            using (FileStream fs = new FileStream($"{textBox1.Text}_{textBox2.Text}.xml", FileMode.Append))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Test));

                Test test = new Test();

                var answers = new List<Answer>();

                Question question = new Question();


                question.Text = textBox4.Text;
                question.Difficulty = domainUpDown1.Text;

                Answer answer1 = new Answer();
                answer1.Ans = textBox3.Text;
                answer1.Correct = radioButton1.Checked;

                Answer answer2 = new Answer();
                answer2.Ans = textBox6.Text;
                answer2.Correct = radioButton2.Checked;

                Answer answer3 = new Answer();
                answer3.Ans = textBox7.Text;
                answer3.Correct = radioButton3.Checked;

                Answer answer4 = new Answer();
                answer4.Ans = textBox8.Text;
                answer4.Correct = radioButton4.Checked;

                answers.Add(answer1);
                answers.Add(answer2);
                answers.Add(answer3);
                answers.Add(answer4);


                questions.Add(question);
                //Q.Question.Add(question);
                //test.Questions.Question.Add(question);


                formatter.Serialize(fs, test);


                Console.WriteLine("Объект сериализован");

                button2.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text))
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text))
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text))
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text))
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }
    }
}
