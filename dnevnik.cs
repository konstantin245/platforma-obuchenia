using Microsoft.VisualBasic.Logging;
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

    public partial class dnevnik : Form
    {
        List<user> users = new List<user>();
        public dnevnik()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.Text = "";
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.BackgroundImage = Image.FromFile("picture/backgroundWinTeacher.jpg");
        }
        private void read_user()
        {
            string[] str = System.IO.File.ReadAllLines("marks.txt");
            for (int i = 0; i < str.Length; i = i + 2)
            {
                user u1 = new user();
                string login = "";
                string mark;
                login = str[i];
                mark = str[i + 1];

                u1.UserName = login;
                u1.Mark = mark;

                listBox_students.Items.Add(u1.UserName);
                users.Add(u1);
            }
        }
        private void dnevnik_Load(object sender, EventArgs e)
        {
            read_user();
        }

        private void all_marks_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox_students_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedStudent = listBox_students.SelectedIndex;
            all_marks.Text = users[selectedStudent].Mark;
            averageMark();
        }
        private void averageMark()
        {
            double sum = 0;
            int selectedStudent = listBox_students.SelectedIndex;
            string[] str = System.IO.File.ReadAllLines("marks.txt");
            string log = users[selectedStudent].UserName;

            for (int i = 0; i < str.Length; i++)
            {
                if (log == str[i])
                {
                    //mark = users[selectedStudent].Mark;
                    int[] strokaVInt = str[i + 1].Split(' ').
                    Where(x => !string.IsNullOrWhiteSpace(x)).              //преобразовывает массив string в int
                    Select(x => int.Parse(x)).ToArray();

                    for (int j = 0; j < strokaVInt.Length; j++)             //сумма всех оценок ученика
                    { sum += strokaVInt[j]; }

                    srednia_mark.Text = (Math.Round((sum / strokaVInt.Length), 2)).ToString();
                }
            }

        }
        private void accept_Click(object sender, EventArgs e)
        {
            //MessageBox.Show((all_marks.Text.Length - 1).ToString());
            string[] str = System.IO.File.ReadAllLines("marks.txt");
            StreamWriter writer = new StreamWriter("marks.txt", false);
            string mark = all_marks.Text;
            string log = users[listBox_students.SelectedIndex].UserName;
            for (int i = 0; i < str.Length; i++)
            {
                /*int[] strokaVInt = str[i + 1].Split(' ').
                Where(x => !string.IsNullOrWhiteSpace(x)).              //преобразовывает массив string в int
                Select(x => int.Parse(x)).ToArray();

                for (int j = 0; j < strokaVInt.Length; j++)             //сумма всех оценок ученика
                { sum += strokaVInt[j]; }*/

                if (log == str[i])
                {
                    //srednia_mark.Text = (sum/ strokaVInt.Length).ToString();            
                    if (all_marks.Text.Substring(all_marks.Text.Length - 1) == " ")
                        MessageBox.Show("Строка не может заканчиваться пробелом!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else str[i + 1] = mark;

                    foreach (string s in str)
                    {
                        writer.WriteLine(s);
                    }
                    writer.Close();
                    averageMark();
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            password Password = new password();
            this.Hide();
            Password.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            win_teacher win_Teacher = new win_teacher();
            this.Hide();
            win_Teacher.Show();
        }
    }
}
