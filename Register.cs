using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AsCoursework
{
    public partial class Register : Form
    {
        User ANewUser = new User();
        public Register()
        {
            InitializeComponent();
            CheckBoxTimer.Start();
            pnlPassStrengthIncrease.Width = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            DefaultFormatting();
            btnCancel.FlatAppearance.BorderSize = 0;

        }

        private void DefaultFormatting()
        {
            txtbUsername.ForeColor = Color.Black;
            txtbPassword2.ForeColor = Color.Black;
            txtbPassword.ForeColor = Color.Black;
            lblPassNoMatch.Visible = false;

            btnCancel.FlatAppearance.BorderSize = 0;
        }
        private void DefaultFormattingTwo()
        {
            cboxAdmin.ForeColor = Color.Black;
            cboxGender.ForeColor = Color.Black;
            lblDOB.ForeColor = Color.Black;
            btnRegister.FlatAppearance.BorderSize = 0;
            lblAgeError.Visible = false;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            List<char> sCharacters = new List<char>();
            List<bool> validate = new List<bool>();
            string username, password, passwordTwo, firstname, surname;

            try 
            { 
                int length;
                firstname = txtBoxFirstName.Text;
                surname = txtBoxSurname.Text;
                username = txtbUsername.Text;
                passwordTwo = txtbPassword2.Text;
                password = txtbPassword.Text;
                length = password.Length;

                Validation.ValidateNullorEmpty(firstname);

                if (string.IsNullOrEmpty(firstname)) 
                {
                    validate.Add(false); 
                    lblName.ForeColor = Color.Red; 
                }
                else 
                { 
                    lblName.ForeColor = Color.Black; 
                }

                if (!Validation.ValidateNullorEmpty(surname)) 
                {
                    validate.Add(false); 
                    lblSurname.ForeColor = Color.Red; 
                }
                else { lblSurname.ForeColor = Color.Black; }

                if (!Validation.ValidateNullorEmpty(username))
                {
                    validate.Add(false);
                    lblUsername.ForeColor = Color.Red;
                }
                else 
                { 
                    lblUsername.ForeColor = Color.Black;
                }

                if (!Validation.ValidateUnique(username)) 
                {
                    validate.Add(false); 
                    lblUniqueUser.Visible = true; 
                }

                if (!Validation.ValidateNullorEmpty(password)) 
                {
                    validate.Add(false); 
                    lblPassword.ForeColor = Color.Red; 
                } 

                else 
                { 
                    lblPassword.ForeColor = Color.Black; 
                }


                if (!Validation.ValidateNullorEmpty(passwordTwo)) 
                { 
                    lblPassword2.ForeColor = Color.Red;
                    lblReEnterPass.ForeColor = Color.Red; 
                    validate.Add(false); 
                }
                else 
                { 
                    lblPassword2.ForeColor = Color.Black; 
                    lblReEnterPass.ForeColor = Color.Black; 
                }

                if (!Validation.PassMatch(password, passwordTwo)) 
                { 
                    lblPasswordError.ForeColor = Color.Red; 
                    lblPassNoMatch.Visible = true;
                    validate.Add(false);
                }
            
           
                if (length < 8)
                {
                    validate.Add(false);
                    throw new CustomException("Password must be at least 8 characters long");
                }

                if (Validation.SpecialCharacter.Matches(password).Count == 0)
                {
                    validate.Add(false);
                }
                if (Validation.NumberCharacter.Matches(password).Count == 0)
                {
                    validate.Add(false);
                }
                if (Validation.UpperCaseCharacter.Matches(password).Count == 0)
                {
                    validate.Add(false);
                }

                if (validate.Count == 0)
                {
                    pnlRegisterTwo.Visible = true;
                    pnlRegisterTwo.BringToFront();
                    pnlRegisterOne.Visible = false;
                    ANewUser.Firstname = firstname;
                    ANewUser.Surname = surname;
                    ANewUser.Username = username;
                    ANewUser.Password = password;
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
        }

        private void pctBoxEye_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if(txtbPassword.UseSystemPasswordChar)
            {
                pctBoxEye.Image = Properties.Resources.eye_crossed;
                txtbPassword.UseSystemPasswordChar = false;
                txtbPassword2.UseSystemPasswordChar = false;
                counter++;

            }

            if ((!txtbPassword.UseSystemPasswordChar) && (counter == 0))
            {
                pctBoxEye.Image = Properties.Resources.eye;
                txtbPassword.UseSystemPasswordChar = true;
                txtbPassword2.UseSystemPasswordChar = true;
            }
        }

        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {
            CheckPassStrength();
        }

        private void CheckPassStrength()
        {
            string password = txtbPassword.Text;
            int MaxpnlWidth = 330;
            int pnlWidth = 0;
            int pnlWithStep = MaxpnlWidth / 4;


            if (Validation.MinLength(7, password))
            {
                pnlWidth += pnlWithStep;
                pctBoxLengthTick.Visible = true;
                pctBoxLength.Visible = false;

            }
            else
            {
                pctBoxLength.Visible = true;
                pctBoxLengthTick.Visible = false;
            }
            if (Validation.SpecialCharacter.Matches(password).Count > 0)
            {
                pnlWidth += pnlWithStep;
                pctBoxSpecialCharTick.Visible = true;
                pctBoxSpecialChar.Visible = false;

            }
            else
            {
                pctBoxSpecialChar.Visible = true;
                pctBoxSpecialCharTick.Visible = false;
            }
            if (Validation.NumberCharacter.Matches(password).Count > 0)
            {
                pnlWidth += pnlWithStep;
                pctBoxTickNumber.Visible = true;
                pctBoxNumber.Visible = false;
            }
            else
            {
                pctBoxTickNumber.Visible = false;
                pctBoxNumber.Visible = true;
            }
            if (Validation.UpperCaseCharacter.Matches(password).Count > 0)
            {
                pnlWidth += pnlWithStep;
                pctBoxUppercaseTick.Visible = true;
                pctBoxUpperCase.Visible = false;
            }
            else
            {
                pctBoxUppercaseTick.Visible = false;
                pctBoxUpperCase.Visible = true;
            }
            pnlPassStrengthIncrease.Size = new Size(pnlWidth, pnlPassStrengthIncrease.Height);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Player ANewPlayer = new Player();
            Admin ANewAdmin = new Admin();

            DefaultFormattingTwo();
             string gender;
             string usertype;
             DateTime DOB;
             List<bool> errors = new List<bool>();

             gender = cboxGender.Text;
             usertype = cboxAdmin.Text.ToLower();
             if (String.IsNullOrEmpty(gender))
             {
                 errors.Add(false);
                 lblGender.ForeColor = Color.Red;
             }
             else
             {
                 cboxGender.ForeColor = Color.Black;
             }

            if (String.IsNullOrEmpty(usertype))
            {
                errors.Add(false);
                lblAdmin.ForeColor = Color.Red;
            }  
            
            if((usertype != "player") && (usertype != "admin"))
            {
                errors.Add(false);
                lblAdmin.ForeColor = Color.Red;
                throw new CustomException("Not a valid usertype");
            }


            DateTime CurrentDate = DateTime.Now;
            
             DOB = dateTimePicker1.Value;
             TimeSpan dateDifference = CurrentDate.Subtract(DOB);
             const int days = 5844;
             TimeSpan RequiredAge = new TimeSpan(days, 0, 0, 0);

             if (dateDifference >= RequiredAge)
             {
                 DOB = dateTimePicker1.Value;
             }

             else
             {
                 lblAgeError.Visible = true;
                 lblDOB.ForeColor = Color.Red;
                 errors.Add(false);
             }

             if (errors.Count == 0)
             {
                 ANewUser.Gender = gender;
                 ANewUser.DateOfBirth = DOB;                  
                 ANewUser.UserType = usertype;
                if(usertype.ToLower() == "admin")
                {
                    ANewAdmin.Firstname = ANewUser.Firstname;
                    ANewAdmin.Surname = ANewUser.Surname;
                    ANewAdmin.Username = ANewUser.Username;
                    ANewAdmin.Password = ANewUser.Password;
                    ANewAdmin.Gender = gender;
                    ANewAdmin.UserType = ANewUser.UserType;
                    ANewAdmin.Avatar = ANewUser.Avatar;
                    ANewAdmin.DateOfBirth = DOB;
                    User.AllUsers.Add(ANewAdmin);
                    FileHandling.WriteToFile(User.AllUsers);
                    FileHandling.ReadInCsv();
                }
                if (usertype == "player")
                {

                    ANewPlayer.Firstname = ANewUser.Firstname;
                    ANewPlayer.Surname = ANewUser.Surname;
                    ANewPlayer.Username = ANewUser.Username;
                    ANewPlayer.Password = ANewUser.Password;
                    ANewPlayer.Gender = gender;
                    ANewPlayer.UserType = ANewUser.UserType;
                    ANewPlayer.Avatar = ANewUser.Avatar;
                    ANewPlayer.DateOfBirth = DOB;
                    ANewPlayer.AHighScore = 0;
                    ANewPlayer.AHighScoreTwo = 0;
                    ANewPlayer.AHighScoreThree = 0;
                    ANewPlayer.AHighScoreFour = 0;
                    ANewPlayer.BHighScore = 0;
                    ANewPlayer.CHighScore = 0;
                    ANewPlayer.DHighScore = 0;
                    ANewPlayer.EHighScore = 0;

                    User.AllUsers.Add(ANewPlayer);
                    FileHandling.WriteToFile(User.AllUsers);
                    FileHandling.ReadInCsv();
                }
                this.Hide();
                Login login = new Login();
                login.Show();
             }
        }

       
    }
}
