namespace _sbornik
{
    partial class win_teacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button_dnevnik = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(5, 77, 149);
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(206, 229);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(382, 28);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "логин";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(382, 88);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "пароль";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(248, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 23);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(382, 152);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "задания";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(92, 28);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "ученики";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.background_dnevnik;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = Color.White;
            button1.Location = new Point(248, 225);
            button1.Name = "button1";
            button1.Size = new Size(147, 111);
            button1.TabIndex = 8;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = Properties.Resources.background_dnevnik;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = Color.White;
            button2.Location = new Point(401, 224);
            button2.Name = "button2";
            button2.Size = new Size(147, 112);
            button2.TabIndex = 9;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImage = Properties.Resources.background_dnevnik;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 281);
            button3.Name = "button3";
            button3.Size = new Size(100, 55);
            button3.TabIndex = 10;
            button3.Text = "Выйти";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button_dnevnik
            // 
            button_dnevnik.BackColor = Color.White;
            button_dnevnik.BackgroundImage = Properties.Resources.background_dnevnik;
            button_dnevnik.BackgroundImageLayout = ImageLayout.Stretch;
            button_dnevnik.ForeColor = Color.White;
            button_dnevnik.Location = new Point(118, 281);
            button_dnevnik.Name = "button_dnevnik";
            button_dnevnik.Size = new Size(100, 55);
            button_dnevnik.TabIndex = 11;
            button_dnevnik.Text = "Посмотреть оценки учеников";
            button_dnevnik.UseVisualStyleBackColor = false;
            button_dnevnik.Click += button_dnevnik_Click;
            // 
            // win_teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_dnevnik;
            ClientSize = new Size(577, 348);
            Controls.Add(button_dnevnik);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "win_teacher";
            Text = "win_teacher";
            Load += win_teacher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button_dnevnik;
    }
}