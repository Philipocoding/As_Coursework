//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace AsCoursework
//{
//    public partial class formSettings : Form
//    {

//        public formSettings()
//        {
//            InitializeComponent();
//        }

//        private void formSettings_Load(object sender, EventArgs e)
//        {
//            lblPassError.Visible = false;
//            lbl_USerDelete.Text = User.LoggedInUser().Username;
//            txtbFirstname.Text = User.LoggedInUser().Firstname;            
//            txtbSurname.Text = User.LoggedInUser().Surname;
//            txtbUsername.Text = User.LoggedInUser().Username;

            
//            switch (ProfileSettings.CurrentPosition)
//            {
//                case 0:
//                    pcbProfile.Image = Properties.Resources.ProfileOne;
//                    break;
//                case 1:
//                    pcbProfile.Image = Properties.Resources.ProfileTwo;
//                    break;
//                case 2:
//                    pcbProfile.Image = Properties.Resources.ProfileThree;
//                    break;
//                case 3:
//                    pcbProfile.Image = Properties.Resources.ProfileFour;
//                    break;
//                case 4:
//                    pcbProfile.Image = Properties.Resources.ProfileFive;
//                    break;
//            }
//        }

//        private void btnDelete_Click(object sender, EventArgs e)
//        {
//            ((MainMenu)ActiveForm).LoadChildForm(new ConfirmDelete());
//        }

       
//        private void btnLeft_Click_1(object sender, EventArgs e)
//        {
//            int value = ProfileSettings.OnLeftClick(ProfileSettings.CurrentPosition);
//            pnlGreenSelect.Visible = false;

//            if (value == 0)
//            {
//                pcbProfile.Image = Properties.Resources.ProfileOne;
//            }
//            if (value == 1)
//            {
//                pcbProfile.Image = Properties.Resources.ProfileTwo;
//            }
//            if (value == 2)
//            {
//                pcbProfile.Image = Properties.Resources.ProfileThree;
//            }
//            if (value == 3)
//            {
//                pcbProfile.Image = Properties.Resources.ProfileFour;
//            }
//            if (value == 4)
//            {
//                pcbProfile.Image = Properties.Resources.ProfileFive;
//            }
//        }

//        private void btnRight_Click(object sender, EventArgs e)
//        {
//            int value = ProfileSettings.OnRightCLick(ProfileSettings.CurrentPosition);
//            pnlGreenSelect.Visible = false;

//            if (value == 0)
//            {
//                pcbProfile.Image = Properties.Resources.ProfileOne;
//            }
//            if (value == 1)
//            {
//                pcbProfile.Image = Properties.Resources.ProfileTwo;
//            }
//            if (value == 2)
//            {
//                pcbProfile.Image = Properties.Resources.ProfileThree;
//            }
//            if (value == 3)
//            {
//                pcbProfile.Image = Properties.Resources.ProfileFour;
//            }
//            if (value == 4)
//            {
//                pcbProfile.Image = Properties.Resources.ProfileFive;
//            }
//        }

//        private void btnSelect_Click_1(object sender, EventArgs e)
//        {
//            pnlGreenSelect.Visible = true;
//            User.LoggedInUser().Avatar = ProfileSettings.CurrentPosition;
//            User.AddAvatar(User.LoggedInUser().Avatar);
//        }

//        private void btnChangePass_Click(object sender, EventArgs e)
//        {
//            string password, newpass, confirmpass;
//            password = txtbPassword.Text;
//            newpass = txtbNewPass.Text;
//            confirmpass = txtConfirmPass.Text;

//            foreach (User user in User.AllUsers)
//            {
//                if ((user.Password == password) && (user.Username == User.LoggedInUser().Username))
//                {
//                    if ((Validation.PassMatch(newpass, confirmpass)) && (Validation.PassChange(newpass)))
//                    {
//                        ProfileSettings.ExecutePasswordChange(newpass);
//                        lblPassChanged. Visible = true;
//                        lblPassError.Visible = false;
//                        txtbNewPass.Clear();
//                        txtbPassword.Clear();
//                        txtConfirmPass.Clear();
//                        break;
//                    }
//                    else
//                    {
//                        lblPassError.Visible = true;
//                        break;
//                    }
//                }
//                else
//                {
//                    lblPassError.Visible = true;
//                    break;
//                }
//            }
//        }

//        private void btnConfirm_Click(object sender, EventArgs e)
//        {
//            string firstname, surname, gender, username;
//            username = txtbUsername.Text;
//            firstname = txtbFirstname.Text;
//            surname = txtbSurname.Text;
//            gender = cBoxGender.Text;                

//            if (Validation.ValidateNullorEmpty(firstname))
//            {
//                lblFirstnameError.Visible = false;
//            }
//            else
//            {
//                lblFirstnameError.Visible = true;
//            }


//            if (Validation.ValidateNullorEmpty(surname))
//            {
//                lblSurnameError.Visible = false;
//            }
//            else
//            {
//                lblSurnameError.Visible = true;
//            }
//            if (Validation.ValidateNullorEmpty(gender))
//            {
//                lblGenderError.Visible = false;
//            }
//            else
//            {
//                lblGenderError.Visible = true;
//            }

//            if (Validation.UsernameType(username))
//            {
//                lblUSernameError.Visible = false;
//            }
//            else
//            {
//                lblUSernameError.Text = "Username must conatin numbers and letters";
//                lblUSernameError.Visible = true;
//            }

//            if(Validation.ValidateNullorEmpty(username))
//            {
//                lblUSernameError.Visible = false;
//            }
//            else
//            {
//                lblUSernameError.Visible = true;
//            }


//        }

//    }
//}
