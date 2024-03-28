using System;
using System.Windows.Forms;

namespace AsCoursework
{
    public partial class TrueFalse : Form
    {
        TrueOrFalse AQuestion = new TrueOrFalse();
        public TrueFalse()
        {
            InitializeComponent();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            AQuestion.IsCorrect("true",AQuestion.Answer.ToLower());
            PopulateObject(QuestionManager.FindNextQuestion());
            DisplayQuestion();
        }


        private void btnFalse_Click(object sender, EventArgs e)
        {
            AQuestion.IsCorrect("false", AQuestion.Answer);
            PopulateObject(QuestionManager.FindNextQuestion());
            DisplayQuestion();
        }


        private void TrueFalse_Load(object sender, EventArgs e)
        {
            AQuestion.QuestionList.Clear();
            QuestionManager.position = 0;
            AQuestion.QuestionList = AQuestion.FilterQuestion("D", AQuestion.QuestionList);
            AQuestion.QuestionList = AQuestion.RandomiseQuestions(AQuestion.QuestionList);
            PopulateObject(QuestionManager.FindNextQuestion());
            DisplayQuestion();
        }

        private void PopulateObject(int i)
        {
            if (i < AQuestion.QuestionList.Count)
            {
                AQuestion.Answer = AQuestion.QuestionList[i].Answer;
                AQuestion.QuestionID = AQuestion.QuestionList[i].QuestionID;
                AQuestion.aQuestion = AQuestion.QuestionList[i].aQuestion;
            }

            else
            {
                QuestionManager.IsHighScore("D");
                ((MainMenu)ActiveForm).LoadChildForm(new QuizSummary());

            }
        }

        private void DisplayQuestion()
        {
            lblQuestion.Text = AQuestion.aQuestion;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlInstructions.Visible = false;
        }
    }
}
