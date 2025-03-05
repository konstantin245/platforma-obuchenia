namespace _sbornik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.Text = "";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("picture/" + "background zastavka.jpg");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(77, 124, 202);
            button1.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            password Password = new password();
            this.Hide();
            Password.ShowDialog();     //правильный код      

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}