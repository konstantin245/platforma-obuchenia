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
using static System.Windows.Forms.DataFormats;

namespace _sbornik
{
    
    public partial class password : Form
    {
        n_teach_task t1 = new n_teach_task();
        int theach_or_stud = 0;
        public password()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.Text = "";
            this.StartPosition= FormStartPosition.CenterScreen;
        }

        private void password_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (theach_or_stud == 2)
            {

                string[] str = System.IO.File.ReadAllLines("password_teacher.txt");
                for (int i = 0; i < str.Length; i = i + 2)
                {
                    user u2 = read_passlog_teacher(str[i], str[i+1]);
                    if (textBox1.Text == u2.UserName && textBox2.Text == u2.Password)
                    {
                        win_teacher win_Teacher = new win_teacher();
                        this.Hide();
                        win_Teacher.ShowDialog();
                    }
                }
            }

            if (theach_or_stud == 1)
            {
                string[] str1 = System.IO.File.ReadAllLines("password_student.txt");
                for (int i = 0; i < str1.Length; i = i + 2)
                {
                    user u1 = read_log_password(str1[i]);

                    if (textBox1.Text == u1.UserName && textBox2.Text == u1.Password)
                    {
                        read_n_task(str1[i + 1]);
                        //n_teach_task t1= new n_teach_task();
                        //t1.num_teach_task.Add(1);
                        string login = u1.UserName;
                        win_student win_Student = new win_student(t1,login);
                        this.Hide();
                        win_Student.ShowDialog();
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            registration Registration= new registration();
            this.Hide();
            Registration.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            theach_or_stud = 1;         //выбрал ученика
            checkBox3.Enabled = false;
            if (checkBox2.Checked == false) checkBox3.Enabled = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            theach_or_stud = 2;         //выбрал учителя
            checkBox2.Enabled = false;
            if (checkBox3.Checked == false) checkBox2.Enabled = true;
        }
        private user read_log_password(string s)
        {
            string pass = "";
            string log = "";

            int i = 0;
            while (s[i]!=' ')
            {
                log = log + s[i];
                i++;
            }

            for (int j=i+1; j < s.Length; j++)
            {
                pass = pass + s[j];
            }
            user u1=new user();
            u1.Password = pass;
            u1.UserName = log;
            return u1;

        }
        private user read_passlog_teacher(string s, string strPass)
        {
            string pass = "";
            string log = "";
            
            for (int i = 0; i<s.Length;i++)
            {
                log = log+s[i];
            }
            for (int i=0; i < strPass.Length; i++)
            {
                pass = pass + strPass[i];
            }
            
            user u2 = new user();
            u2.Password = pass;
            u2.UserName = log;
            return u2;
        }
        private n_teach_task read_n_task(string s)
        {
            int i = 0;
            //n_teach_task t1 = new n_teach_task();


            while (i < s.Length)
            {
                string num = "";
                int num_int;
                while (s[i] != ' '&&i < s.Length)
                {
                    num = num + s[i];
                    i++;
                }
                i++;
                num_int = int.Parse(num);
                t1.num_teach_task.Add(num_int);
            }
            return t1;
        }
    }
}
