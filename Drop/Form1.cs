using Drop.Entity;

namespace Drop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(buttonHideShow.Text=="Show")
            {
                buttonHideShow.Text = "Hide";
                textPassword.PasswordChar= '\0';
            }
            else
            {
                buttonHideShow.Text = "Show";
                textPassword.PasswordChar = '*';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox.Checked==true)
            {
                buttonLogIn.Enabled = true;
            }
            else
            {
                buttonLogIn.Enabled = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonLogIn.Enabled = false;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if(textUserName.Text=="Ali" && textPassword.Text=="1111007")
            {
                Dashboard db = new Dashboard();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter valid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}