using System;
using System.Windows.Forms;

namespace AsCoursework
{
    public partial class pcbSpecialChar : Form
    {
        string newpass;

        public pcbSpecialChar()
        {
            InitializeComponent();
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            lblPassError.Visible = false;
            lbl_UserDelete.Text = User.LoggedInUser().Username;
            txtbFirstname.Text = User.LoggedInUser().Firstname;
            txtbSurname.Text = User.LoggedInUser().Surname;
            txtbUsername.Text = User.LoggedInUser().Username;
            lblAnswered.Text = User.LoggedInUser().Qanswered.ToString();
            lblCorrect.Text = User.LoggedInUser().Qcorrect.ToString();
            lblIncorrect.Text = User.LoggedInUser().Qincorrect.ToString();
            txtbPassword.Text = User.LoggedInUser().Password;
            cBoxGender.Text = User.LoggedInUser().Gender;


            switch (Profile_Settings.CurrentPosition)
            {
                case 0:
                    pcbProfile.Image = Properties.Resources.ProfileOne;
                    break;
                case 1:
                    pcbProfile.Image = Properties.Resources.ProfileTwo;
                    break;
                case 2:
                    pcbProfile.Image = Properties.Resources.ProfileThree;
                    break;
                case 3:
                    pcbProfile.Image = Properties.Resources.ProfileFour;
                    break;
                case 4:
                    pcbProfile.Image = Properties.Resources.ProfileFive;
                    break;
            }
        }




        private void btnLeft_Click(object sender, EventArgs e)
        {
            int value = Profile_Settings.OnLeftClick(Profile_Settings.CurrentPosition);
            pnlGreenSelect.Visible = false;

            if (value == 0)
            {
                pcbProfile.Image = Properties.Resources.ProfileOne;
            }
            if (value == 1)
            {
                pcbProfile.Image = Properties.Resources.ProfileTwo;
            }
            if (value == 2)
            {
                pcbProfile.Image = Properties.Resources.ProfileThree;
            }
            if (value == 3)
            {
                pcbProfile.Image = Properties.Resources.ProfileFour;
            }
            if (value == 4)
            {
                pcbProfile.Image = Properties.Resources.ProfileFive;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            pnlGreenSelect.Visible = true;
            User.LoggedInUser().Avatar = Profile_Settings.CurrentPosition;
            User.AddAvatar(User.LoggedInUser().Avatar);
            MessageBox.Show("Logout for avater change to occur");
        }

        private void btnRight_Click_1(object sender, EventArgs e)
        {
            int value = Profile_Settings.OnRightCLick(Profile_Settings.CurrentPosition);
            pnlGreenSelect.Visible = false;

            if (value == 0)
            {
                pcbProfile.Image = Properties.Resources.ProfileOne;
            }
            if (value == 1)
            {
                pcbProfile.Image = Properties.Resources.ProfileTwo;
            }
            if (value == 2)
            {
                pcbProfile.Image = Properties.Resources.ProfileThree;
            }
            if (value == 3)
            {
                pcbProfile.Image = Properties.Resources.ProfileFour;
            }
            if (value == 4)
            {
                pcbProfile.Image = Properties.Resources.ProfileFive;
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            ((MainMenu)ActiveForm).LoadChildForm(new ConfirmDelete());
        }

        string password;

        private void txtbNewPass_TextChanged(object sender, EventArgs e)
        {
            password = txtbNewPass.Text;
            if(Validation.SpecialCharacter.Matches(password).Count > 0)
            {
                pcbSpecialCharacter.Image = Properties.Resources.check_circle_1_;
            }
            else
            {
                pcbSpecialCharacter.Image = Properties.Resources.cross_circle_1_;
            }
            if (Validation.MinLength(7,password))
            {
                pcbLength.Image = Properties.Resources.check_circle_1_;

            }
            else
            {
                pcbLength.Image = Properties.Resources.cross_circle_1_;
            }
            if (Validation.UpperCaseCharacter.Matches(password).Count > 0)
            {
                pcbUppercase.Image = Properties.Resources.check_circle_1_;
            }
            else
            {
                pcbUppercase.Image = Properties.Resources.cross_circle_1_;
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string firstname, surname, gender, username;
            username = txtbUsername.Text;
            firstname = txtbFirstname.Text;
            surname = txtbSurname.Text;
            gender = cBoxGender.Text.ToLower();

            try
            {
                if (!Profile_Settings.UpdateDetails(firstname, surname, gender, username))
                {
                    User.LoggedInUser().Surname = surname;
                    User.LoggedInUser().Firstname = firstname;
                    User.LoggedInUser().Gender = gender;
                    User.LoggedInUser().Username = username;
                    User.UpdatePlayer(User.LoggedInUser(), username);
                    lblDetailsChanged.Visible = true;
                    MessageBox.Show("Logout for changes to be confirmed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void btnChangePass_Click_1(object sender, EventArgs e)
        {
            string password, confirmpass;
            password = txtbPassword.Text;
            newpass = txtbNewPass.Text;
            confirmpass = txtbConfirmPass.Text;      

            if (Profile_Settings.UpdatePassword(newpass, confirmpass, password, User.LoggedInUser().Username))
            {
                User.LoggedInUser().Password = newpass;
                User.UpdatePlayer(User.LoggedInUser());
                lblPassChanged.Visible = true;
                lblPassError.Visible = false;
                txtbNewPass.Clear();
                txtbPassword.Clear();
                txtbConfirmPass.Clear();
                lblPassChanged.Visible = true;
            }
        
            else
            {
                lblPassError.Visible = true;
            }
        }

        private void pcbEye_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (txtbPassword.UseSystemPasswordChar)
            {
                pcbEye.Image = Properties.Resources.eye_crossed;
                txtbPassword.UseSystemPasswordChar = false;
                txtbNewPass.UseSystemPasswordChar = false;
                txtbConfirmPass.UseSystemPasswordChar = false;
                counter++;
            }

            if ((!txtbPassword.UseSystemPasswordChar) && (counter == 0))
            {
                pcbEye.Image = Properties.Resources.eye;
                txtbPassword.UseSystemPasswordChar = true;
                txtbNewPass.UseSystemPasswordChar = true;
                txtbConfirmPass.UseSystemPasswordChar = true;
            }
        }
    }
}
