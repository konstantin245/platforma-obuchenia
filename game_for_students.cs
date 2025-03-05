using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;


namespace _sbornik
{
    public partial class game_for_students : Form
    {
        int answ = 0;       //ответ но глобальный, можно сказать костыль
        int counter = -1;  //счетчик правильных ответов
        string student_login;
        n_teach_task t1 = new n_teach_task();
        public game_for_students(n_teach_task t2, string student_login)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.Text = "";
            this.StartPosition = FormStartPosition.CenterScreen;
            t1 = t2;
            this.student_login = student_login;
        }
        private void random_text()
        {
            Random random = new Random();      //создает объект для генерации случайных чисел

            int first_num_for_example = random.Next(0, 100);      //первое число для примера
            int second_num_for_example = random.Next(0, 100);      //второе число для примера

            int[] value = new int[12];                                    //массив значения на кнопках

            int answer_to_example = first_num_for_example + second_num_for_example;         //ответ на пример
            example.Text = first_num_for_example + " + " + second_num_for_example + " = ?";      //сам пример
            answ = answer_to_example;

            int array_section_number = random.Next(0, 11);                 //рандомайзер случайной ячейки массива          

            for (int i = 0; i < 12; i++)
            {
                value[i] = random.Next(0, 200);                           //рандомайзер значений кнопок                                            
            }

            value[array_section_number] = answer_to_example;           //помещает ответ в случайную ячейку

            answer_button1.Text = value[0].ToString();                  //запись этих значений на кнопки
            answer_button2.Text = value[1].ToString();
            answer_button3.Text = value[2].ToString();
            answer_button4.Text = value[3].ToString();
            answer_button5.Text = value[4].ToString();
            answer_button6.Text = value[5].ToString();
            answer_button7.Text = value[6].ToString();
            answer_button8.Text = value[7].ToString();
            answer_button9.Text = value[8].ToString();
            answer_button10.Text = value[9].ToString();
            answer_button11.Text = value[10].ToString();
            answer_button12.Text = value[11].ToString();

            counter = counter + 1;
            counter_label.Text = "Правильных ответов: " + counter.ToString();
        }
        private void game_for_students_Load(object sender, EventArgs e)
        {
            random_text();
        }

        private void answer_button1_Click(object sender, EventArgs e)
        {
            if (answer_button1.Text == answ.ToString())
            {
                //MessageBox.Show("молодец");
                random_text();
            }
            else
            {
                //MessageBox.Show("неправильно");
                counter = -1;
                random_text();
            }
        }

        private void answer_button2_Click(object sender, EventArgs e)
        {
            if (answer_button2.Text == answ.ToString())
            {
                //MessageBox.Show("молодец");
                random_text();
            }
            else
            {
                //MessageBox.Show("неправильно");
                counter = -1;
                random_text();
            }
        }

        private void answer_button3_Click(object sender, EventArgs e)
        {
            if (answer_button3.Text == answ.ToString())
            {
                //MessageBox.Show("молодец");
                random_text();

            }
            else
            {
                //MessageBox.Show("неправильно");
                counter = -1;
                random_text();
            }
        }

        private void answer_button4_Click(object sender, EventArgs e)
        {
            if (answer_button4.Text == answ.ToString())
            {
                //MessageBox.Show("молодец");
                random_text();
            }
            else
            {
                //MessageBox.Show("неправильно");
                counter = -1;
                random_text();
            }
        }

        private void answer_button5_Click(object sender, EventArgs e)
        {
            if (answer_button5.Text == answ.ToString())
            {
                //MessageBox.Show("молодец");
                random_text();
            }
            else
            {
                //MessageBox.Show("неправильно");
                counter = -1;
                random_text();
            }
        }

        private void answer_button6_Click(object sender, EventArgs e)
        {
            if (answer_button6.Text == answ.ToString())
            {
                //MessageBox.Show("молодец");
                random_text();
            }
            else
            {
                //MessageBox.Show("неправильно");
                counter = -1;
                random_text();
            }
        }
        private void answer_button7_Click(object sender, EventArgs e)
        {
            if (answer_button7.Text == answ.ToString())
            {
                //MessageBox.Show("молодец");
                random_text();
            }
            else
            {
                //MessageBox.Show("неправильно");
                counter = -1;
                random_text();
            }
        }

        private void answer_button8_Click(object sender, EventArgs e)
        {
            if (answer_button8.Text == answ.ToString())
            {
                //MessageBox.Show("молодец");
                random_text();
            }
            else
            {
                //MessageBox.Show("неправильно");
                counter = -1;
                random_text();
            }
        }

        private void answer_button9_Click(object sender, EventArgs e)
        {
            if (answer_button9.Text == answ.ToString())
            {
                //MessageBox.Show("молодец");
                random_text();
            }
            else
            {
                //MessageBox.Show("неправильно");
                counter = -1;
                random_text();
            }
        }

        private void answer_button10_Click(object sender, EventArgs e)
        {
            if (answer_button10.Text == answ.ToString())
            {
                //MessageBox.Show("молодец");
                random_text();
            }
            else
            {
                //MessageBox.Show("неправильно");
                counter = -1;
                random_text();
            }
        }

        private void answer_button11_Click(object sender, EventArgs e)
        {
            if (answer_button11.Text == answ.ToString())
            {
                //MessageBox.Show("молодец");
                random_text();
            }
            else
            {
                //MessageBox.Show("неправильно");
                counter = -1;
                random_text();
            }
        }

        private void answer_button12_Click(object sender, EventArgs e)
        {
            if (answer_button12.Text == answ.ToString())
            {
                //MessageBox.Show("молодец");
                random_text();
            }
            else
            {
                //MessageBox.Show("неправильно");
                counter = -1;
                random_text();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)          //выход назад
        {
            win_student win_Student = new win_student(t1, student_login);
            this.Hide();
            win_Student.ShowDialog();
        }
    }
}
