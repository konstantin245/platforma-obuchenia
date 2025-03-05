using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _sbornik
{
    public partial class win_student : Form
    {
        n_teach_task t2 = new n_teach_task();
        string student_login;
        public win_student()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.Text = "";
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        public win_student(n_teach_task t1, string student_log)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.Text = "";
            this.StartPosition = FormStartPosition.CenterScreen;
            t2 = t1;
            student_login = student_log;
            //MessageBox.Show(t1.num_teach_task[0].ToString());
        }

        private void win_student_Load(object sender, EventArgs e)
        {
            double sum = 0;

            string[] str = System.IO.File.ReadAllLines("marks.txt");
            for (int i = 0; i < str.Length; i=i+2)
            {
                if (str[i] == student_login)
                {
                    marks.Text = str[i + 1];

                    int[] strokaVInt = str[i + 1].Split(' ').
                    Where(x => !string.IsNullOrWhiteSpace(x)).              //преобразовывает массив string в int
                    Select(x => int.Parse(x)).ToArray();

                    for (int j = 0; j < strokaVInt.Length; j++)             //сумма всех оценок ученика
                    { sum += strokaVInt[j]; }

                    if (sum == 0) { sred_ball.Text = ""; }
                    else sred_ball.Text = (Math.Round((sum / strokaVInt.Length), 2)).ToString();
                    
                }              
            
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            task_student task_Student = new task_student(t2, student_login);
            this.Hide();
            task_Student.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            task_ot_teacher task_Ot_Teacher = new task_ot_teacher(t2, student_login);
            this.Hide();
            task_Ot_Teacher.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            game_for_students game_For_Students = new game_for_students(t2, student_login);
            this.Hide();
            game_For_Students.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            password Password = new password();
            this.Hide();
            Password.ShowDialog();
        }

        private void marks_Click(object sender, EventArgs e)
        {
            
        }
    }
}
