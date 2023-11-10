using System;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 :  Form
    {
        public Form1()
        {
            InitializeComponent();
            resetval();
        }

        private void materialButton_login_Click(object sender, EventArgs e)
        {
            if (textBox_userid.Text == "userid" && textBox_password.Text == "pass")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("UserID or password is incorrect.");
                resetval();
            }
        }

        private void resetval()
        {
            textBox_userid.Clear();
            textBox_password.Clear();
            textBox_userid.Focus();
        }

        private void linkLabelEdit_clear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            resetval();
        }

        private void linkLabelEdit_Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
