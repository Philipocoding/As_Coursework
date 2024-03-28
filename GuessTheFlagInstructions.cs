using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AsCoursework
{
    public partial class GuessTheFlagInstructions : Form
    {
        GuessFlag guesstheflag = new GuessFlag();
        List<GuessFlag> questions = new List<GuessFlag>();
        public GuessTheFlagInstructions()
        {
            InitializeComponent();
        }
        private void btnEasy_Click(object sender, EventArgs e)
        {
            GuessTheFlag.AQuestion.difficulty = 1;
            pnlEasySelect.Visible = true;
            pnlMediumSelect.Visible = false;
            pnlHardSelect.Visible = false;
            pnlExpertSelect.Visible = false;
            questions = guesstheflag.FilterQuestions("A", 1, questions);
            lblAmountofTime.Text = (questions.Count * 4).ToString();
            GuessFlag.timeProvided = Convert.ToInt32(lblAmountofTime.Text);
            lblNumQuestions.Text = questions.Count().ToString();

        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            GuessTheFlag.AQuestion.difficulty = 2;
            pnlEasySelect.Visible = false;
            pnlMediumSelect.Visible = true;
            pnlHardSelect.Visible = false;
            pnlExpertSelect.Visible = false;
            questions = guesstheflag.FilterQuestions("A", 2, questions);
            lblAmountofTime.Text = (questions.Count * 4).ToString();
            GuessFlag.timeProvided = Convert.ToInt32(lblAmountofTime.Text);
            lblNumQuestions.Text = questions.Count().ToString();

        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            GuessTheFlag.AQuestion.difficulty = 3;
            pnlEasySelect.Visible = false;
            pnlMediumSelect.Visible = false;
            pnlHardSelect.Visible = true;
            pnlExpertSelect.Visible = false;
            questions = guesstheflag.FilterQuestions("A", 3, questions);
            lblAmountofTime.Text = (questions.Count * 4).ToString();
            GuessFlag.timeProvided = Convert.ToInt32(lblAmountofTime.Text);
            lblNumQuestions.Text = questions.Count().ToString();


        }

        private void btnExpert_Click(object sender, EventArgs e)
        {
            GuessTheFlag.AQuestion.difficulty = 4;
            pnlEasySelect.Visible = false;
            pnlMediumSelect.Visible = false;
            pnlHardSelect.Visible = false;
            pnlExpertSelect.Visible = true;
            questions = guesstheflag.FilterQuestions("A", 4, questions);
            lblAmountofTime.Text = (questions.Count * 4).ToString();
            GuessFlag.timeProvided = Convert.ToInt32(lblAmountofTime.Text);
            lblNumQuestions.Text = questions.Count().ToString();


        }

        private void GuessTheFlagInstructions_Load(object sender, EventArgs e)
        {
            FileHandling.ReadInQuestions();
            GuessTheFlag.AQuestion.difficulty = 0;
            Timer.Start();

        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (GuessTheFlag.AQuestion.difficulty != 0)
            {
                if(lblAmountofTime.Text != "0")
                {
                    QuestionManager.position = 0;
                    QuestionManager.FirstEntry = true;
                    ((MainMenu)ActiveForm).LoadChildForm(new GuessTheFlag());
                }
                else
                {
                    MessageBox.Show("There are no questions classed under this difficulty level");
                }
            }

            else
            {
                MessageBox.Show("Select a difficulty");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            pnlInstructions.Visible = false;
            pnlSelectDifficulty.Visible = true;
        }
    }
}
