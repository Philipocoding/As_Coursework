using System;
using System.Windows.Forms;

namespace AsCoursework
{
    public partial class AddQuestion : Form
    {
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string question = txtbQuestion.Text;
            string tempAnswer = txtbAnswer.Text;
            string QuestionType = cBoxQuestionType.Text;
            string answer = tempAnswer.Replace(" ", "");

            try
            {
                AddAQuestion.ValidateQuestion(question, tempAnswer, answer, QuestionType);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }           

            if (AddAQuestion.Entry)
            {
                QuestionManager.AddNewQuestion(question, QuestionType, answer.ToLower());
                pnlQuestionAdded.Visible = true;
                txtbAnswer.Clear();
                txtbQuestion.Clear();
                ((MainMenu)ActiveForm).LoadChildForm(new FrmAdmin());

            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            Timer.Start();
            pnlQuestionAdded.Visible = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (cBoxQuestionType.Text == "Multiple Choice")
            {
                pnlMultiChoice.Visible = true;
                pnlMultiChoice.BringToFront();
            }
            if (cBoxQuestionType.Text != "Multiple Choice")
            {
                pnlMultiChoice.Visible = false;
            }
        }

        private void btnConfirmMultiChoice_Click(object sender, EventArgs e)
        {
            string question = txtbQuestion.Text;
            string answer = txtbAnswerMultiChoice.Text;
            string QuestionType = cBoxQuestionType.Text;
            string optionOne = txtbOptionOne.Text;
            string optionTwo = txtbOptionTwo.Text;
            string optionThree = txtbOptionThree.Text;

            try
            {
                if (AddAQuestion.ValidateQuestion(question, answer, QuestionType, optionOne, optionTwo, optionThree))
                {
                    QuestionManager.AddNewQuestion(question, QuestionType, answer, optionOne, optionTwo, optionThree);
                    pnlMultiChoiceAdded.Visible = true;
                    txtbAnswer.Clear();
                    txtbAnswerMultiChoice.Clear();
                    txtbOptionOne.Clear();
                    txtbOptionTwo.Clear();
                    txtbOptionThree.Clear();
                    cBoxQuestionType.Text = "";
                    txtbQuestion.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }           
        }
    }

}
