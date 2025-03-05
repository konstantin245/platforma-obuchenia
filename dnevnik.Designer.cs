namespace _sbornik
{
    partial class dnevnik
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
            all_marks = new TextBox();
            label1 = new Label();
            listBox_students = new ListBox();
            label2 = new Label();
            label3 = new Label();
            srednia_mark = new Label();
            accept = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // all_marks
            // 
            all_marks.ForeColor = Color.FromArgb(3, 36, 103);
            all_marks.Location = new Point(175, 39);
            all_marks.Name = "all_marks";
            all_marks.Size = new Size(206, 23);
            all_marks.TabIndex = 0;
            all_marks.TextChanged += all_marks_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 9;
            label1.Text = "ученики";
            // 
            // listBox_students
            // 
            listBox_students.BackColor = Color.FromArgb(3, 36, 103);
            listBox_students.ForeColor = Color.White;
            listBox_students.FormattingEnabled = true;
            listBox_students.ItemHeight = 15;
            listBox_students.Location = new Point(12, 39);
            listBox_students.Name = "listBox_students";
            listBox_students.Size = new Size(157, 214);
            listBox_students.TabIndex = 8;
            listBox_students.SelectedIndexChanged += listBox_students_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(175, 9);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 10;
            label2.Text = "все оценки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(335, 9);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 11;
            label3.Text = "средняя оценка";
            // 
            // srednia_mark
            // 
            srednia_mark.AutoSize = true;
            srednia_mark.BackColor = Color.Transparent;
            srednia_mark.ForeColor = Color.White;
            srednia_mark.Location = new Point(397, 42);
            srednia_mark.Name = "srednia_mark";
            srednia_mark.Size = new Size(0, 15);
            srednia_mark.TabIndex = 12;
            // 
            // accept
            // 
            accept.BackColor = Color.Transparent;
            accept.BackgroundImage = Properties.Resources.background_dnevnik;
            accept.ForeColor = Color.White;
            accept.Location = new Point(175, 68);
            accept.Name = "accept";
            accept.Size = new Size(100, 185);
            accept.TabIndex = 13;
            accept.Text = "Подтвердить изменения";
            accept.UseVisualStyleBackColor = false;
            accept.Click += accept_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.background_dnevnik;
            button1.ForeColor = Color.White;
            button1.Location = new Point(281, 68);
            button1.Name = "button1";
            button1.Size = new Size(100, 185);
            button1.TabIndex = 14;
            button1.Text = "выйти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.arrow_back_white;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.arrow_back;
            pictureBox1.Location = new Point(12, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 29);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dnevnik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_dnevnik;
            ClientSize = new Size(431, 266);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(accept);
            Controls.Add(srednia_mark);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox_students);
            Controls.Add(all_marks);
            Name = "dnevnik";
            Text = "dnevnik";
            Load += dnevnik_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox all_marks;
        private Label label1;
        private ListBox listBox_students;
        private Label label2;
        private Label label3;
        private Label srednia_mark;
        private Button accept;
        private Button button1;
        private PictureBox pictureBox1;
    }
}