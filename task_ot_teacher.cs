namespace _sbornik
{
    public partial class task_ot_teacher : Form
    {
        int index_task = 0;
        int mark = 0;
        string student_login;
        List<tasks> task_list = new List<tasks>();    //список задач
        n_teach_task t1 = new n_teach_task();
        //  int x = 0;                                      //меняеться если правильно ответил
        tasks Task = new tasks();
        System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
        double rightTask = 0;
        int Task_number;
        public task_ot_teacher(n_teach_task t2, string student_login)
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
        private void CloseForm(object sender, EventArgs e)
        {
            win_student win_Student = new win_student(t1, student_login);
            this.Hide();
            win_Student.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Поле для ответа не должно быть пустым", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (textBox1.Text == Task.answer)                                            //5
                {
                    if (index_task == t1.num_teach_task.Count - 1)
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
                        button2.Click += new EventHandler(CloseForm);
                        pictureBox1.Image = Image.FromFile("picture/" + task_list[Task_number].ok_picture);

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
                        label1.Text = "Ты молодец!";              //ты модлодец! Нажми на картинку чтобы выйти)
                        pictureBox1.Image = Image.FromFile("picture/" + task_list[Task_number].ok_picture);               //mudri dub kachok.png
                        button1.Enabled = false;
                    }
                }
                else
                {
                    if (index_task == t1.num_teach_task.Count - 1)
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
                        }
                    }
                    else
                    {
                        index_task = index_task + 1;
                        label1.Text = "Неверно! Попробуй еще раз!";              //неверно! Нажми на картинку чтобы попробывать еще)
                        pictureBox1.Image = Image.FromFile("picture/" + task_list[Task_number].wrong_picture);            //mudri dub ghoul.png
                        button1.Enabled = false;
                    }//(sender as Button).Enabled = false;

                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Чтобы перейти к следующей задаче сначала заполните поле для ответов", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                for (int i = 0; i < task_list.Count; i++)
                {
                    if (index_task < t1.num_teach_task.Count)
                    {
                        if (t1.num_teach_task[index_task] == task_list[i].number_task) { Task_number = i; }
                    }
                }
                Task.answer = task_list[Task_number].answer;
                label1.Text = perenos_words(task_list[Task_number].text);
                pictureBox1.Image = Image.FromFile("picture/" + task_list[Task_number].base_picture);
                this.BackgroundImage = Image.FromFile("picture/" + task_list[Task_number].background);
                textBox1.Text = "";
                button1.Enabled = true;
            }
        }

        private void task_ot_teacher_Load(object sender, EventArgs e)
        {
            read_line_from_file();
            for (int i = 0; i < task_list.Count; i++)
            {
                if (t1.num_teach_task[index_task] == task_list[i].number_task)
                    Task_number = i;
                // if (index_task == t1.num_teach_task.Count) { i = 0; index_task = 0; }
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
            double num = t1.num_teach_task.Count;
            double ocenka = (rightTask / num) * 100;
            //MessageBox.Show(ocenka.ToString());
            if (ocenka >= 0 && ocenka <= 50) { label2.Text = "Ваша оценка: 2"; mark = 2; }
            if (ocenka > 50 && ocenka <= 65) { label2.Text = "Ваша оценка: 3"; mark = 3; }
            if (ocenka > 65 && ocenka <= 75) { label2.Text = "Ваша оценка: 4"; mark = 4; }
            if (ocenka > 75 && ocenka <= 100) { label2.Text = "Ваша оценка: 5"; mark = 5; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
