using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _sbornik
{
    public partial class registration : Form
    {
        int theach_or_stud = 0;
        public registration()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
            SpecialTeacherPassword.Enabled = false;
            SpecialTeacherPassword.Visible = false;
        }

        private void registration_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter strStudent = new StreamWriter("password_student.txt", true);
            StreamWriter strStudentMark = new StreamWriter("marks.txt", true);
            StreamWriter strTeacher = new StreamWriter("password_teacher.txt", true);
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox2.Text == textBox3.Text)
                {
                    if (theach_or_stud == 1)
                    {
                        string[] line = new string[2];
                        string pass_log;
                        line[0] = textBox1.Text;
                        line[1] = textBox2.Text;
                        pass_log = line[0] + " " + line[1];
                        strStudent.WriteLine(pass_log);
                        strStudent.WriteLine("1 2 3 4 5 6 ");
                        strStudentMark.WriteLine(line[0]);
                        strStudentMark.WriteLine("");
                        strStudent.Close();
                        strTeacher.Close();
                        strStudentMark.Close();
                        button1.Enabled = false;
                    }

                    if (theach_or_stud == 2)
                    {
                        StreamReader reader = new StreamReader("special_password.txt");
                        if (reader.ReadLine() == SpecialTeacherPassword.Text)
                        {
                            string[] line1 = new string[2];
                            line1[0] = textBox1.Text;
                            line1[1] = textBox2.Text;
                            strTeacher.WriteLine(line1[0]);
                            strTeacher.WriteLine(line1[1]);
                            strTeacher.Close();
                            strStudent.Close();
                            strStudentMark.Close();
                            reader.Close();
                            button1.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Специальный пароль не совпадает", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            strStudent.Close(); strTeacher.Close(); reader.Close(); strStudentMark.Close();
                        }
                    }
                }
                else { MessageBox.Show("Пароли не совпадают", "", MessageBoxButtons.OK, MessageBoxIcon.Error); strStudent.Close(); strTeacher.Close(); }
            }
            else { MessageBox.Show("Пользователь не может быть без пароля", "", MessageBoxButtons.OK, MessageBoxIcon.Error); strStudent.Close(); strTeacher.Close(); }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            theach_or_stud = 1;         //выбрал ученика
            checkBox3.Enabled = false;
            if (checkBox2.Checked == false) checkBox3.Enabled = true;
            SpecialTeacherPassword.Enabled = false;
            SpecialTeacherPassword.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            theach_or_stud = 2;         //выбрал учителя
            checkBox2.Enabled = false;
            SpecialTeacherPassword.Enabled = true;
            SpecialTeacherPassword.Visible = true;
            if (checkBox3.Checked == false) 
            {
                checkBox2.Enabled = true;
                SpecialTeacherPassword.Enabled = false;
                SpecialTeacherPassword.Visible = false;
            }                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            password Password = new password();
            this.Hide();
            Password.ShowDialog();
        }

        private void SpecialTeacherPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
