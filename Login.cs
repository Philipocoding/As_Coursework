using System;
using System.Windows.Forms;

namespace AsCoursework
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.BringToFront();
        }

        private void linklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtboxUsername.Clear();
            txtboxPassword.Clear();
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void txtboxUsername_Click(object sender, EventArgs e)
        {
            if (txtboxUsername.Text == "Username")
            {
                txtboxUsername.Clear();
            }
        }

        private void txtboxUsername_Leave(object sender, EventArgs e)
        {
            if (txtboxUsername.Text.Equals(""))
            {
                txtboxUsername.Text = "Username";
            }
        }

        private void txtboxPassword_Leave(object sender, EventArgs e)
        {
            if (txtboxPassword.Text.Equals(""))
            {
                txtboxPassword.Text = "Password";
                txtboxPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtboxPassword_Click(object sender, EventArgs e)
        {
            if (txtboxPassword.Text != "Password")
            {
                txtboxPassword.UseSystemPasswordChar = true;
                return;
            }
            txtboxPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtboxUsername.Text;
            string password = txtboxPassword.Text;

            foreach (User user in User.AllUsers)
            {
                if (_Login.CheckUsername(username, user.Username))
                {
                    if (_Login.CheckPassword(password, user.Password))
                    {
                        _Login.Login(user);
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Show();
                        this.Hide();
                        break;
                    }

                    else
                    {
                        lblIncorrectDetails.Visible = true;
                        txtboxPassword.Clear();
                        this.ActiveControl = txtboxPassword;
                    }
                }

                else
                {
                    lblIncorrectDetails.Visible = true;
                    txtboxPassword.Clear();
                    this.ActiveControl = txtboxPassword;
                }
            }
        }

        private void pcbEye_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (txtboxPassword.UseSystemPasswordChar)
            {
                pcbEye.Image = Properties.Resources.eye_crossed;
                txtboxPassword.UseSystemPasswordChar = false;
                counter++;

            }

            if ((!txtboxPassword.UseSystemPasswordChar) && (counter == 0))
            {
                pcbEye.Image = Properties.Resources.eye;
                txtboxPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {
            txtboxPassword.UseSystemPasswordChar = true;
        }
    }
}
