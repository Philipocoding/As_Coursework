using System;
using System.Linq;
using System.Windows.Forms;

namespace AsCoursework
{
    public partial class Capitals : Form
    {
        public Capitals()
        {
            InitializeComponent();
        }
        CapitalsTest TheQuestion = new CapitalsTest();
        private void txtbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            string userAns;
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                userAns = txtbAnswer.Text;
                string actualAns = TheQuestion.CapitalsExtended[QuestionManager.CurrentQuestPosition()].Answer;
                TheQuestion.IsCorrect(userAns, actualAns);
                displayQuestion(QuestionManager.FindNextQuestion());
                txtbAnswer.Clear();
            }
        }

        private void displayQuestion(int position)
        {
            for(int i = 0; i < TheQuestion.CapitalsExtended.Count(); i++)
            {
                if(i == position)
                {
                    lblQuestion.Text = TheQuestion.CapitalsExtended[i].aQuestion;
                }
            }

            if(position == TheQuestion.CapitalsExtended.Count())
            {
                Timer.Stop();
                QuestionManager.IsHighScore("B");
                ((MainMenu)ActiveForm).LoadChildForm(new QuizSummary());
            }
        }

        private void Capitals_Load(object sender, EventArgs e)
        {
            CapitalsTest.NumHintsLeft = 3;
            TheQuestion.CapitalsExtended.Clear();
            TheQuestion.FilterQuestion("B", TheQuestion.CapitalsExtended);
            TheQuestion.CapitalsExtended = TheQuestion.RandomiseQuestions(TheQuestion.CapitalsExtended);
            lblNumQuestions.Text = TheQuestion.CapitalsExtended.Count.ToString();
            lblTime.Text = (TheQuestion.CapitalsExtended.Count * 3).ToString();
            displayQuestion(QuestionManager.FindNextQuestion());
            CapitalsTest.timeProvided = Convert.ToInt32(lblTime.Text);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlInstructions.Visible = false;
            lblTimeRemaining.Text = CapitalsTest.timeProvided.ToString();
            Timer.Start();
            

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CapitalsTest.timeProvided = CapitalsTest.timeProvided - 1;
            lblTimeRemaining.Text = CapitalsTest.timeProvided.ToString();
            if(CapitalsTest.timeProvided == 0)
            {
                Timer.Stop();
                QuestionManager.IsHighScore("B");
                ((MainMenu)ActiveForm).LoadChildForm(new QuizSummary());
            }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            if(CapitalsTest.NumHintsLeft >= 0)
            {
                txtbAnswer.Text = (CapitalsTest.Hint(TheQuestion.CapitalsExtended).ToString());
                CapitalsTest.NumHintsLeft --;
                this.ActiveControl = txtbAnswer;

            }
            else
            {
                lblHints.Visible = true;
            }

        }
    }
}
