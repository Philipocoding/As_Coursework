using System.Windows.Forms;
namespace AsCoursework
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            customiseDesign();
        }

        private void customiseDesign()
        {
            pnlSubMenuTakeQuiz.Visible = false;
        }

        private void hideSubMenu()
        {
            if(pnlSubMenuTakeQuiz.Visible)
            {
                pnlSubMenuTakeQuiz.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if(pnlSubMenuTakeQuiz.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }

            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        public void LoadChildForm(Form childForm)
        {
            activeForm = childForm;

            // Set the location before making it visible
            activeForm.Location = new System.Drawing.Point(0, 0);

            // Set other properties
            activeForm.TopLevel = false;
            activeForm.Enabled = true;
            activeForm.Visible = true;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;

            // Clear existing controls in pnlChildForm before adding a new one
            pnlChildForm.Controls.Clear();
            pnlChildForm.Controls.Add(activeForm);

            // Bring the child form to the front
            activeForm.BringToFront();
        }


        private void LoadProfile()
        {
            string usertype = User.LoggedInUser().UserType;
            lblUsername.Text = User.LoggedInUser().Username;
            lblUserType.Text = User.LoggedInUser().UserType;
            switch (User.LoggedInUser().Avatar)
            {
                case 0:
                    pcbProfileImage.Image = Properties.Resources.ProfileOne;
                    break;
               case 1:
                    pcbProfileImage.Image = Properties.Resources.ProfileTwo;
                    break;
               case 2:
                    pcbProfileImage.Image = Properties.Resources.ProfileThree;
                    break;
               case 3:
                    pcbProfileImage.Image = Properties.Resources.ProfileFour;
                    break;
               case 4:
                    pcbProfileImage.Image = Properties.Resources.ProfileFive;
                    break;
               
                default:
                    pcbProfileImage.Image = Properties.Resources.ProfileOne;
                    break;
            }
            
                
            
        }
        private void btn_Logout_Click_1(object sender, System.EventArgs e)
        {
            User.userType = 0;
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_Settings_Click_1(object sender, System.EventArgs e)
        {
            LoadChildForm(new pcbSpecialChar());
        }       

        private void btnTakeAQuiz_Click(object sender, System.EventArgs e)
        {
            ShowSubMenu(pnlSubMenuTakeQuiz);
            if(User.LoggedInUser().UserType == "admin")
            {
                MessageBox.Show("Admin highscores will not be recorded");
            }
        }

        private void pcbMenu_Click_1(object sender, System.EventArgs e)
        {

            if (pnlSideMenu.Width > 56)
            {
                pnlSideMenu.Width = 56;
                btn_Logout.Text = "";
                pcbProfileImage.Visible = false;
                lblUsername.Visible = false;
                lblTitle.Visible = false;
                lblUserType.Visible = false;
                lblTitles.Visible = false;
            }
            else
            {
                pnlSideMenu.Width = 300;
                btn_Logout.Text = "Logout";
                pcbProfileImage.Visible = true;
                lblUsername.Visible = true;
                lblTitle.Visible = true;
                lblUserType.Visible = true;
                lblTitles.Visible = true;
            }
        }
        private void MainMenu_Load(object sender, System.EventArgs e)
        {
            LoadProfile();
        }

        private void btnGuessFlag_Click(object sender, System.EventArgs e)
        {
            User.LoggedInUser().Score = 0;
            Question.HighScore = false;
            LoadChildForm(new GuessTheFlagInstructions());
            hideSubMenu();


        }

        private void btnCapitals_Click(object sender, System.EventArgs e)
        {
            User.LoggedInUser().Score = 0;
            Question.HighScore = false;
            LoadChildForm(new Capitals());
            hideSubMenu();

        }

        private void btnMultipleChoice_Click(object sender, System.EventArgs e)
        {
            User.LoggedInUser().Score = 0;
            Question.HighScore = false;
            LoadChildForm(new MultipleChoice());
            hideSubMenu();

        }

        private void btnLeaderboard_Click(object sender, System.EventArgs e)
        {
            LoadChildForm(new Leaderboards());
            hideSubMenu();

        }

        private void btnTrueFalse_Click(object sender, System.EventArgs e)
        {
            User.LoggedInUser().Score = 0;
            Question.HighScore = false;
            LoadChildForm(new TrueFalse());
            hideSubMenu();

        }

        private void btnMatch_Click(object sender, System.EventArgs e)
        {
            User.LoggedInUser().Score = 0;
            Question.HighScore = false;
            LoadChildForm(new MatchQuiz());
            hideSubMenu();
        }

        private void btnAdmin_Click(object sender, System.EventArgs e)
        {
            
            if (User.LoggedInUser().UserType != "admin")
            {
                MessageBox.Show("You are not an Admin");
            }
            else
            {
                LoadChildForm(new FrmAdmin());
            }
        }

        private void lblCollapse_Click(object sender, System.EventArgs e)
        {
            if (pnlSideMenu.Width > 56) 
            { 
                pnlSideMenu.Width = 56; 
                btn_Logout.Text = "";
                pcbProfileImage.Visible = false;
                lblUsername.Visible = false;
                lblTitle.Visible = false;
                lblUserType.Visible = false;
                lblTitles.Visible = false;
            }
            else 
            { 
                pnlSideMenu.Width = 300;
                btn_Logout.Text = "Logout"; 
                pcbProfileImage.Visible = true;
                lblUsername.Visible = true;
                lblTitle.Visible = true;
                lblUserType.Visible = true;
                lblTitles.Visible = true;
            }
        }

        private void pcbTakeQuiz_Click(object sender, System.EventArgs e)
        {
            pnlSideMenu.Width = 286; 
            btn_Logout.Text = "Logout";
            pcbProfileImage.Visible = true;
            lblUsername.Visible = true;
            lblUserType.Visible = true;
            lblTitles.Visible = true;
            lblTitle.Visible = true;
            ShowSubMenu(pnlSubMenuTakeQuiz);

        }

        private void pcbAdmin_CLick(object sender, System.EventArgs e)
        {
            if (User.LoggedInUser().UserType != "admin")
            {
                MessageBox.Show("You are not an Admin");
            }
            else
            {
                LoadChildForm(new FrmAdmin());
            }

        }

        private void pcbLeaderboards_Click(object sender, System.EventArgs e)
        {
            LoadChildForm(new Leaderboards());

        }

        private void pcbSettings_Click(object sender, System.EventArgs e)
        {
            LoadChildForm(new pcbSpecialChar());

        }
    }
}
