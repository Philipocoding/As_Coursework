using System;
using System.Linq;
using System.Windows.Forms;

namespace AsCoursework
{
    public partial class MultipleChoice : Form
    {
        public MultipleChoice()
        {
            InitializeComponent();
        }

        MultipleChoiceTest AQuestion = new MultipleChoiceTest();

        private void MultipleChoice_Load(object sender, EventArgs e)
        {
            QuestionManager.FirstEntry = true;
            AQuestion.QuestionList = AQuestion.FilterQuestion(AQuestion.QuestionList);
            AQuestion.QuestionList = AQuestion.RandomiseQuestions(AQuestion.QuestionList);
            populateObject(QuestionManager.FindNextQuestion());
            displayQuestion(QuestionManager.CurrentQuestPosition());
            MultipleChoiceTest.timeProvided = (AQuestion.QuestionList.Count() * 3);
            lblNumberofQuestions.Text = AQuestion.QuestionList.Count().ToString();
            lblTimeProvided.Text = MultipleChoiceTest.timeProvided.ToString();
            llblTimeRemaining.Text = MultipleChoiceTest.timeProvided.ToString();
        }

        private void btnAnsOne_Click(object sender, EventArgs e)
        {
            AQuestion.IsCorrect(btnAnsOne.Text, AQuestion.Answer);
            populateObject(QuestionManager.FindNextQuestion());
            displayQuestion(QuestionManager.CurrentQuestPosition());
        }

        private void btnAnsThree_Click(object sender, EventArgs e)
        {
            AQuestion.IsCorrect(btnAnsThree.Text, AQuestion.Answer);
            populateObject(QuestionManager.FindNextQuestion());
            displayQuestion(QuestionManager.CurrentQuestPosition());
        }

        private void btnAnsTwo_Click(object sender, EventArgs e)
        {
            AQuestion.IsCorrect(btnAnsTwo.Text, AQuestion.Answer);
            populateObject(QuestionManager.FindNextQuestion());
            displayQuestion(QuestionManager.CurrentQuestPosition());
        }

        private void btnAnsFour_Click(object sender, EventArgs e)
        {
            AQuestion.IsCorrect(btnAnsFour.Text, AQuestion.Answer);
            populateObject(QuestionManager.FindNextQuestion());
            displayQuestion(QuestionManager.CurrentQuestPosition());
        }

        private void displayQuestion(int i)
        {
            
            if (i <= AQuestion.QuestionList.Count)
            {
                Random random = new Random();
                AQuestion.Answer = AQuestion.QuestionList[i].Answer;
                AQuestion.aQuestion = AQuestion.QuestionList[i].aQuestion;
                lblQuestion.Text = AQuestion.aQuestion;
                int answerPosition = random.Next(1, 4);

                switch(answerPosition)
                {
                    case 1:
                        btnAnsOne.Text = AQuestion.Answer;
                        btnAnsTwo.Text = AQuestion.OptionOne;
                        btnAnsThree.Text = AQuestion.OptionTwo;
                        btnAnsFour.Text = AQuestion.OptionThree;
                        break;
                    case 2:
                        btnAnsOne.Text = AQuestion.OptionOne;
                        btnAnsTwo.Text = AQuestion.Answer;
                        btnAnsThree.Text = AQuestion.OptionTwo;
                        btnAnsFour.Text = AQuestion.OptionThree;
                        break;
                    case 3:
                        btnAnsOne.Text = AQuestion.OptionOne;
                        btnAnsTwo.Text = AQuestion.OptionTwo;
                        btnAnsThree.Text =  AQuestion.Answer;
                        btnAnsFour.Text = AQuestion.OptionThree;

                        break;
                    case 4:
                        btnAnsOne.Text = AQuestion.OptionOne;
                        btnAnsTwo.Text = AQuestion.OptionTwo;
                        btnAnsThree.Text = AQuestion.OptionThree;
                        btnAnsFour.Text = AQuestion.Answer;
                        break;

                    default:
                        Timer.Stop();
                        ((MainMenu)ActiveForm).LoadChildForm(new QuizSummary());
                        break;
                }
            }
            else
            {
                Timer.Stop();
                ((MainMenu)ActiveForm).LoadChildForm(new QuizSummary());

            }
        }

        private void populateObject(int i)
        {
            if(i < AQuestion.QuestionList.Count)
            {
                AQuestion.Answer = AQuestion.QuestionList[i].Answer;
                AQuestion.OptionOne = AQuestion.QuestionList[i].OptionOne;
                AQuestion.OptionTwo = AQuestion.QuestionList[i].OptionTwo;
                AQuestion.OptionThree = AQuestion.QuestionList[i].OptionThree;
                AQuestion.QuestionID = AQuestion.QuestionList[i].QuestionID;
                AQuestion.aQuestion = AQuestion.QuestionList[i].aQuestion;
            }

            else
            {
                QuestionManager.IsHighScore("C");
                Timer.Stop();
                ((MainMenu)ActiveForm).LoadChildForm(new QuizSummary());

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlInstructions.Visible = false;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MultipleChoiceTest.timeProvided = MultipleChoiceTest.timeProvided - 1;
            llblTimeRemaining.Text = MultipleChoiceTest.timeProvided.ToString();

            if (MultipleChoiceTest.timeProvided == 0)
            {
                QuestionManager.IsHighScore("C");
                ((MainMenu)ActiveForm).LoadChildForm(new QuizSummary());
                Timer.Stop();
            }
        }
    }
}
