namespace _sbornik
{
    partial class registration
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
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button2 = new Button();
            SpecialTeacherPassword = new TextBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(262, 23);
            textBox2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(331, 167);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 11;
            label2.Text = "придумайте пароль";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 23);
            textBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(329, 123);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 9;
            label1.Text = "придумайте свой логин";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(261, 236);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(262, 23);
            textBox3.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(261, 212);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 13;
            label3.Text = "подтвердите пароль";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(99, 111, 123);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(261, 265);
            button1.Name = "button1";
            button1.Size = new Size(262, 54);
            button1.TabIndex = 15;
            button1.Text = "зарегистрироваться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(406, 211);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(117, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "показать пароль";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(261, 63);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(199, 19);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "зарегистрироваться как ученик";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Transparent;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.ForeColor = Color.White;
            checkBox3.Location = new Point(261, 88);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(204, 19);
            checkBox3.TabIndex = 18;
            checkBox3.Text = "зарегистрироваться как учитель";
            checkBox3.UseVisualStyleBackColor = false;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(99, 111, 123);
            button2.Location = new Point(261, 325);
            button2.Name = "button2";
            button2.Size = new Size(262, 54);
            button2.TabIndex = 19;
            button2.Text = "выйти";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // SpecialTeacherPassword
            // 
            SpecialTeacherPassword.Location = new Point(465, 86);
            SpecialTeacherPassword.Name = "SpecialTeacherPassword";
            SpecialTeacherPassword.Size = new Size(58, 23);
            SpecialTeacherPassword.TabIndex = 20;
            SpecialTeacherPassword.TextChanged += SpecialTeacherPassword_TextChanged;
            // 
            // registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_registration;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(SpecialTeacherPassword);
            Controls.Add(button2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "registration";
            StartPosition = FormStartPosition.CenterScreen;
            Load += registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button2;
        private TextBox SpecialTeacherPassword;
    }
}