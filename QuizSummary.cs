using System;
using System.Windows.Forms;

namespace AsCoursework
{
    public partial class QuizSummary : Form
    {
       
        public QuizSummary()
        {
            InitializeComponent();
        }

        private void QuizSummary_Load(object sender, EventArgs e)
        {
            User.UpdatePlayer(User.LoggedInUser());
            QuestionManager.position = 0;
            lblScore.Text = User.LoggedInUser().Score.ToString(); 
            if(Question.HighScore)
            {
                if(User.LoggedInUser() is Player)
                {
                    lblNewHighScore.Visible = true;
                    lblNewHighScore.Text = "Congratulations - That is a new high score!";
                }
                
            }
        }

        private void BtnTakeNewQuiz_Click(object sender, EventArgs e)
        {
            User.LoggedInUser().Score = 0;
            pnlQuizOptions.Visible = true;
            pnlSummary.Visible = false;

        }

        private void btnLeaderboards_Click(object sender, EventArgs e)
        {
            ((MainMenu)ActiveForm).LoadChildForm(new Leaderboards());

        }

        private void btnTrueFalse_Click(object sender, EventArgs e)
        {
            ((MainMenu)ActiveForm).LoadChildForm(new TrueFalse());

        }

        private void btnCapitalsQuiz_Click(object sender, EventArgs e)
        {
            ((MainMenu)ActiveForm).LoadChildForm(new Capitals());

        }

        private void btnGuessFlag_Click(object sender, EventArgs e)
        {
            ((MainMenu)ActiveForm).LoadChildForm(new GuessTheFlagInstructions());

        }

        private void btnMultipleCHoice_Click(object sender, EventArgs e)
        {
            ((MainMenu)ActiveForm).LoadChildForm(new MultipleChoice());

        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            ((MainMenu)ActiveForm).LoadChildForm(new MatchQuiz());

        }
    }
}
