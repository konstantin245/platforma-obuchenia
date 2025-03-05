namespace _sbornik
{
    partial class win_student
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
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            marks = new Label();
            label1 = new Label();
            label2 = new Label();
            sred_ball = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(2, 37, 75);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(272, 12);
            button2.Name = "button2";
            button2.Size = new Size(186, 120);
            button2.TabIndex = 4;
            button2.Text = "Задание от учителя";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 37, 75);
            button1.ForeColor = Color.White;
            button1.Location = new Point(80, 12);
            button1.Name = "button1";
            button1.Size = new Size(186, 120);
            button1.TabIndex = 3;
            button1.Text = "Задание";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(2, 37, 75);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(464, 12);
            button3.Name = "button3";
            button3.Size = new Size(186, 120);
            button3.TabIndex = 5;
            button3.Text = "Тренировка счёта";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.arrow_back_white;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.arrow_back;
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 38);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // marks
            // 
            marks.AutoSize = true;
            marks.BackColor = Color.Transparent;
            marks.ForeColor = Color.White;
            marks.Location = new Point(138, 171);
            marks.Name = "marks";
            marks.Size = new Size(38, 15);
            marks.TabIndex = 16;
            marks.Text = "label1";
            marks.Click += marks_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(80, 171);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 17;
            label1.Text = "Оценки:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(80, 206);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 18;
            label2.Text = "Средний  балл:";
            // 
            // sred_ball
            // 
            sred_ball.AutoSize = true;
            sred_ball.BackColor = Color.Transparent;
            sred_ball.ForeColor = Color.White;
            sred_ball.Location = new Point(177, 206);
            sred_ball.Name = "sred_ball";
            sred_ball.Size = new Size(38, 15);
            sred_ball.TabIndex = 19;
            sred_ball.Text = "label1";
            // 
            // win_student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            BackgroundImage = Properties.Resources.background_win_student;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(662, 441);
            Controls.Add(sred_ball);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(marks);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "win_student";
            Text = "win_student";
            Load += win_student_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button1;
        private Button button3;
        private PictureBox pictureBox1;
        private Label marks;
        private Label label1;
        private Label label2;
        private Label sred_ball;
    }
}