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
    public partial class win_teacher : Form
    {
        List<user> user_list = new List<user>();
        public win_teacher()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.Text = "";
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.BackgroundImage = Image.FromFile("picture/background dnevnik.jpg");
        }
        private void read_user()
        {
            string[] str = System.IO.File.ReadAllLines("password_student.txt");
            for (int z = 0; z < str.Length; z = z + 2)
            {
                user u1 = new user();
                string pass = "";
                string log = "";
                int i = 0;
                string sz = str[z];
                while (sz[i] != ' ')
                {
                    log = log + sz[i];
                    i++;
                }

                for (int j = i + 1; j < sz.Length; j++)
                {
                    pass = pass + sz[j];
                }
                u1.Task = str[z + 1];
                u1.Password = pass;
                u1.UserName = log;
                listBox1.Items.Add(u1.UserName);
                user_list.Add(u1);
            }

        }
        private void win_teacher_Load(object sender, EventArgs e)
        {
            read_user();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            textBox1.Text = user_list[i].UserName;
            textBox2.Text = user_list[i].Password;
            textBox3.Text = user_list[i].Task;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            user_list[i].UserName = textBox1.Text;
            user_list[i].Password = textBox2.Text;
            user_list[i].Task = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = listBox1.SelectedIndex;
            if (user_list[a].Task.Length > 6)
            {
                StreamWriter writer = new StreamWriter("password_student.txt");
                for (int i = 0; i < user_list.Count; i++)
                {
                    writer.WriteLine(user_list[i].UserName + " " + user_list[i].Password);
                    if (user_list[i].Task[user_list[i].Task.Length - 1] != ' ')
                        user_list[i].Task = user_list[i].Task + " ";
                    writer.WriteLine(user_list[i].Task);

                }
                writer.Close();
            }
            else MessageBox.Show("Задач должно быть больше чем 3", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            password Password = new password();
            this.Hide();
            Password.ShowDialog();
        }

        private void button_dnevnik_Click(object sender, EventArgs e)
        {
            dnevnik Dnevnik = new dnevnik();
            this.Hide();
            Dnevnik.ShowDialog();
        }
    }
}
