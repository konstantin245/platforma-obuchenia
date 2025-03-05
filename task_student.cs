using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _sbornik
{
    public partial class task_student : Form
    {
        int index_task = 0;
        int mark = 0;
        string student_login;
        List<tasks> task_list = new List<tasks>();    //список задач
        List<Etask> task_easy = new List<Etask>();            //список легких задач
        double rightTask = 0;
        n_teach_task t1 = new n_teach_task();
        Etask etask = new Etask();
        tasks Task = new tasks();
        System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();

        int Task_number;                            //задача которую должны вывести
        public task_student(n_teach_task t2, string student_login)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.Text = "";
            this.StartPosition = FormStartPosition.CenterScreen;
            t1 = t2;
            this.student_login = student_login;
        }
        public void read_line_from_file()
        {
            StreamReader str = new StreamReader("tasks/task.txt");
            string line0 = str.ReadLine();
            while (line0 != null)
            {
                string line1 = str.ReadLine();
                string line2 = str.ReadLine();
                string line3 = str.ReadLine();
                string line4 = str.ReadLine();
                string line5 = str.ReadLine();
                string line6 = str.ReadLine();
                tasks task1 = new tasks();
                task1.number_task = Int32.Parse(line0);
                task1.text = line1;
                task1.background = line2;
                task1.answer = line3;
                task1.base_picture = line4;
                task1.ok_picture = line5;
                task1.wrong_picture = line6;
                task_list.Add(task1);
                line0 = str.ReadLine();
            }
            str.Close();
        }
        private void number_task_from_file()
        {
            StreamReader str = new StreamReader("tasks/level_easy.txt");

            string line;
            int i = 0;

            while ((line = str.ReadLine()) != null)
            {
                etask.number_easy_task[i] = Int32.Parse(line);
                i++;
                task_easy.Add(etask);
            }

        }
        private void CloseForm(object sender, EventArgs e)
        {
            win_student win_Student = new win_student(t1, student_login);
            this.Hide();
            win_Student.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Поле для ответа не должно быть пустым", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (textBox1.Text == task_list[Task_number].answer)                                            //5
                {
                    if (index_task == task_easy.Count - 1)
                    {
                        label2.Size = new Size(200, 50);
                        label2.BackColor = Color.Transparent;
                        rightTask++;
                        vistavlenie_mark();
                        label2.Location = new Point(40, 200);
                        label2.Font = new Font(label2.Font.FontFamily, 18);
                        this.Controls.Add(label2);
                        label1.Font = new Font(label1.Font.FontFamily, 52);
                        label1.Text = "Задачи закончились";
                        button2.Location = new Point(27, 324);
                        button2.Text = "Нажмите чтобы выйти";
                        button1.Enabled = false;
                        button1.Visible = false;
                        textBox1.Visible = false;
                        textBox1.Enabled = false;
                        button2.Width = 289;
                        pictureBox1.Image = Image.FromFile("picture/" + task_list[Task_number].ok_picture);
                        button2.Click += new EventHandler(CloseForm);

                        string[] strMarks = System.IO.File.ReadAllLines("marks.txt");
                        StreamWriter StudentMarks = new StreamWriter("marks.txt", false);
                        for (int i = 0; i < strMarks.Length; i++)
                        {
                            if (strMarks[i] == student_login)
                            {
                                if (strMarks[i + 1] == "") strMarks[i + 1] = strMarks[i + 1] + mark;
                                else strMarks[i + 1] = strMarks[i + 1] + " " + mark;
                                foreach (string s in strMarks)
                                {
                                    StudentMarks.WriteLine(s);
                                }
                                StudentMarks.Close();
                                break;
                            }
                        }
                    }
                    else
                    {
                        index_task = index_task + 1;
                        rightTask++;
                        label1.Text = "Ты молодец!";
                        pictureBox1.Image = Image.FromFile("picture/" + task_list[Task_number].ok_picture);
                        button1.Enabled = false;

                    }
                }
                else
                {
                    if (index_task == task_easy.Count - 1)
                    {
                        label2.Size = new Size(200, 50);
                        label2.BackColor = Color.Transparent;
                        vistavlenie_mark();
                        label2.Location = new Point(40, 200);
                        label2.Font = new Font(label2.Font.FontFamily, 18);
                        this.Controls.Add(label2);
                        label1.Font = new Font(label1.Font.FontFamily, 52);
                        label1.Text = "Задачи закончились";
                        button2.Location = new Point(27, 324);
                        button2.Text = "Нажмите чтобы выйти";
                        button1.Enabled = false;
                        button1.Visible = false;
                        textBox1.Visible = false;
                        textBox1.Enabled = false;
                        button2.Width = 289;
                        pictureBox1.Image = Image.FromFile("picture/" + task_list[Task_number].wrong_picture);

                        button2.Click += new EventHandler(CloseForm);

                        string[] strMarks = System.IO.File.ReadAllLines("marks.txt");
                        StreamWriter StudentMarks = new StreamWriter("marks.txt", false);
                        for (int i = 0; i < strMarks.Length; i++)
                        {
                            if (strMarks[i] == student_login)
                            {
                                if (strMarks[i + 1] == "") strMarks[i + 1] = strMarks[i + 1] + mark;
                                else strMarks[i + 1] = strMarks[i + 1] + " " + mark;
                                foreach (string s in strMarks)
                                {
                                    StudentMarks.WriteLine(s);
                                }
                                StudentMarks.Close();
                                break;
                            }
                            /*else
                            {
                                foreach (string s in strMarks)
                                {
                                    StudentMarks.WriteLine(s);
                                }
                                StudentMarks.WriteLine(student_login);
                                StudentMarks.WriteLine(mark);
                                StudentMarks.Close();
                                break;
                            }*/
                        }
                    }
                    else
                    {
                        index_task = index_task + 1;
                        label1.Text = "Неверно! Попробуй еще раз!";
                        pictureBox1.Image = Image.FromFile("picture/" + task_list[Task_number].wrong_picture);
                        button1.Enabled = false;
                    }//(sender as Button).Enabled = false;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Чтобы перейти к следующей задаче сначала заполните поле для ответов", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                for (int i = 0; i < task_list.Count; i++)
                {
                    if (etask.number_easy_task[index_task] == task_list[i].number_task)
                        Task_number = i;
                }
                Task.answer = task_list[Task_number].answer;
                label1.Text = perenos_words(task_list[Task_number].text);
                pictureBox1.Image = Image.FromFile("picture/" + task_list[Task_number].base_picture);
                this.BackgroundImage = Image.FromFile("picture/" + task_list[Task_number].background);
                textBox1.Text = "";
                button1.Enabled = true;

            }
        }

        private void task_student_Load(object sender, EventArgs e)
        {
            number_task_from_file();
            read_line_from_file();
            for (int i = 0; i < task_list.Count; i++)
            {
                if (etask.number_easy_task[index_task] == task_list[i].number_task)
                    Task_number = i;
            }
            Task.number_task = Task_number;
            Task.answer = task_list[Task_number].answer;
            label1.Text = perenos_words(task_list[Task_number].text);
            pictureBox1.Image = Image.FromFile("picture/" + task_list[Task_number].base_picture);
            this.BackgroundImage = Image.FromFile("picture/" + task_list[Task_number].background);
        }
        private string perenos_words(string str)
        {
            string simbol = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 50 == 0 && i != 0)
                {
                    if (str[i] == ' ')
                        simbol = simbol + str[i] + "\n";
                    else
                        simbol = simbol + str[i] + "-\n";
                }
                else
                    simbol = simbol + str[i];
            }                                                //45
            return simbol;
        }
        private void vistavlenie_mark()
        {
            //MessageBox.Show(rightTask.ToString());
            double num = task_easy.Count;
            double ocenka = (rightTask / num) * 100;
            //MessageBox.Show(ocenka.ToString());
            if (ocenka >= 0 && ocenka <= 50) { label2.Text = "Ваша оценка: 2"; mark = 2; }
            if (ocenka > 50 && ocenka <= 65) { label2.Text = "Ваша оценка: 3"; mark = 3; }
            if (ocenka > 65 && ocenka <= 75) { label2.Text = "Ваша оценка: 4"; mark = 4; }
            if (ocenka > 75 && ocenka <= 100) { label2.Text = "Ваша оценка: 5"; mark = 5; }
            /*int quaterNum = (num / 4);
            if (rightTask >= 0 && rightTask < quaterNum) {label2.Text =  "Ваша оценка: 2"; mark = 2; }
            if (rightTask >= quaterNum && rightTask < 2 * quaterNum) { label2.Text = "Ваша оценка: 3"; mark = 3; }
            if (rightTask >= quaterNum * 2 && rightTask < 3 * quaterNum) { label2.Text = "Ваша оценка: 4"; mark = 4; }
            if (rightTask >= quaterNum * 3 && rightTask <= 4 * quaterNum) { label2.Text = "Ваша оценка: 5"; mark = 5; }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
