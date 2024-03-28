using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AsCoursework
{
    public partial class MatchQuiz : Form
    {
        public MixAndMatch AQuestion = new MixAndMatch();
        static List<Question>  shuffledQuestions = new List<Question>();

        public MatchQuiz()
        {
            InitializeComponent();
        }
        

        public void DisplayBoxes(int number)
        {
            switch(number)
            {
                case 1:
                    cboxAnsOne.Visible = true;
                    cBoxAnsTwo.Visible = false;
                    cBoxAnsThree.Visible = false;
                    cBoxAnsFour.Visible = false;
                    cBoxAnsFive.Visible = false;
                    pnlLines.Size = new System.Drawing.Size(200, (int)Math.Round((double)(number * (450 / 6))));

                    cBoxQuestOne.Visible = true;
                    cBoxQuestTwo.Visible = false;
                    cBoxQuestThree.Visible = false;
                    cBoxQuestFour.Visible = false;
                    cBoxQuestFive.Visible = false; 
                    cBoxQuestSix.Visible = false;
                    break;
                case 2:
                    cboxAnsOne.Visible = true;
                    cBoxAnsTwo.Visible = true;
                    cBoxAnsThree.Visible = false;
                    cBoxAnsFour.Visible = false;
                    cBoxAnsFive.Visible = false;
                    cBoxAnsSix.Visible = false;
                    pnlLines.Size = new System.Drawing.Size(200, (int)Math.Round((double)(number * (450 / 6))));

                    cBoxQuestOne.Visible = true;
                    cBoxQuestTwo.Visible = true;
                    cBoxQuestThree.Visible = false;
                    cBoxQuestFour.Visible = false;
                    cBoxQuestFive.Visible = false;
                    cBoxQuestSix.Visible = false;
                    break;
                case 3:
                    cboxAnsOne.Visible = true;
                    cBoxAnsTwo.Visible = true;
                    cBoxAnsThree.Visible = true;
                    cBoxAnsFour.Visible = false;
                    cBoxAnsFive.Visible = false;
                    cBoxAnsSix.Visible = false;
                    pnlLines.Size = new System.Drawing.Size(200, (int)Math.Round((double)(number * (450 / 6))));

                    cBoxQuestOne.Visible = true;
                    cBoxQuestTwo.Visible = true;
                    cBoxQuestThree.Visible = true;
                    cBoxQuestFour.Visible = false;
                    cBoxQuestFive.Visible = false;
                    cBoxQuestSix.Visible = false;
                    break;
                case 4:
                    cboxAnsOne.Visible = true;
                    cBoxAnsTwo.Visible = true;
                    cBoxAnsThree.Visible = true;
                    cBoxAnsFour.Visible = true;
                    cBoxAnsFive.Visible = false;
                    cBoxAnsSix.Visible = false;
                    pnlLines.Size = new System.Drawing.Size(200, (int)Math.Round((double)(number * (450 / 6))));

                    cBoxQuestOne.Visible = true;
                    cBoxQuestTwo.Visible = true;
                    cBoxQuestThree.Visible = true;
                    cBoxQuestFour.Visible = true;
                    cBoxQuestFive.Visible = false;
                    cBoxQuestSix.Visible = false;
                    break;
                case 5:
                    cboxAnsOne.Visible = true;
                    cBoxAnsTwo.Visible = true;
                    cBoxAnsThree.Visible = true;
                    cBoxAnsFour.Visible = true;
                    cBoxAnsFive.Visible = true;
                    cBoxAnsSix.Visible = false;
                    int x = number * (200 / 6);
                    pnlLines.Size = new System.Drawing.Size(200, (int)Math.Round((double)(number * (450 / 6))));

                    cBoxQuestOne.Visible = true;
                    cBoxQuestTwo.Visible = true;
                    cBoxQuestThree.Visible = true;
                    cBoxQuestFour.Visible = true;
                    cBoxQuestFive.Visible = true;
                    cBoxQuestSix.Visible = false;
                    break;
                case 6:
                    cboxAnsOne.Visible = true;
                    cBoxAnsTwo.Visible = true;
                    cBoxAnsThree.Visible = true;
                    cBoxAnsFour.Visible = true;
                    cBoxAnsFive.Visible = true;
                    cBoxAnsSix.Visible = true;
                    pnlLines.Size = new System.Drawing.Size(200, (int)Math.Round((double)(number * (450 / 6))));

                    cBoxQuestOne.Visible = true;
                    cBoxQuestTwo.Visible = true;
                    cBoxQuestThree.Visible = true;
                    cBoxQuestFour.Visible = true;
                    cBoxQuestFive.Visible = true;
                    cBoxQuestSix.Visible = true;
                    break;
                default:
                    cboxAnsOne.Visible = true;
                    cBoxAnsTwo.Visible = true;
                    cBoxAnsThree.Visible = true;
                    cBoxAnsFour.Visible = true;
                    cBoxAnsFive.Visible = true;
                    cBoxAnsSix.Visible = true;

                    cBoxQuestOne.Visible = true;
                    cBoxQuestTwo.Visible = true;
                    cBoxQuestThree.Visible = true;
                    cBoxQuestFour.Visible = true;
                    cBoxQuestFive.Visible = true;
                    cBoxQuestSix.Visible = true;
                    pnlLines.Size = new System.Drawing.Size(200, (int)Math.Round((double)(number * (450 / 6))));

                    break;

            }
        }

        private void PopulateQuestions(int startingPosition)
        {
            MixAndMatch.numOfQuestions = AQuestion.QuestionList.Count;


            try
            {
                //Resetting all the comboboxes 
                cboxAnsOne.Items.Clear(); cboxAnsOne.Text = "";
                cBoxAnsTwo.Items.Clear(); cBoxAnsTwo.Text = "";
                cBoxAnsThree.Items.Clear(); cBoxAnsThree.Text = "";
                cBoxAnsFour.Items.Clear(); cBoxAnsFour.Text = "";
                cBoxAnsFive.Items.Clear(); cBoxAnsFive.Text = "";
                cBoxAnsSix.Items.Clear(); cBoxAnsSix.Text = "";

                cBoxQuestOne.Items.Clear(); cBoxQuestOne.Text = "";
                cBoxQuestTwo.Items.Clear(); cBoxQuestTwo.Text = "";
                cBoxQuestThree.Items.Clear(); cBoxQuestThree.Text = "";
                cBoxQuestFour.Items.Clear(); cBoxQuestFour.Text = "";
                cBoxQuestFive.Items.Clear(); cBoxQuestFive.Text = "";
                cBoxQuestSix.Items.Clear(); cBoxQuestSix.Text = "";

                if ((startingPosition + 6) > AQuestion.QuestionList.Count)
                {
                    MixAndMatch.terminatePosition = AQuestion.QuestionList.Count;
                    MixAndMatch.numOfQuestions = MixAndMatch.terminatePosition - startingPosition;
                    MixAndMatch.RePopulateNeeded = false;
                    btnContinue.Text = "Finish";
                    DisplayBoxes(MixAndMatch.terminatePosition - startingPosition);
                }
                else
                {
                    MixAndMatch.numOfQuestions = MixAndMatch.terminatePosition = startingPosition + 6;
                    DisplayBoxes(MixAndMatch.terminatePosition - startingPosition);

                }
                for (int j = startingPosition; j < MixAndMatch.terminatePosition; j++)
                {
                    cboxAnsOne.Items.Add(AQuestion.QuestionList[j].Answer);
                    cBoxAnsTwo.Items.Add(AQuestion.QuestionList[j].Answer);
                    cBoxAnsThree.Items.Add(AQuestion.QuestionList[j].Answer);
                    cBoxAnsFour.Items.Add(AQuestion.QuestionList[j].Answer);
                    cBoxAnsFive.Items.Add(AQuestion.QuestionList[j].Answer);
                    cBoxAnsSix.Items.Add(AQuestion.QuestionList[j].Answer);

                }

                 AQuestion.RandomisePositions();
                

                int p = 0;
                for (int i = startingPosition; i < MixAndMatch.terminatePosition; i++)
                {
                   cBoxQuestOne.Items.Add(AQuestion.QuestionList[MixAndMatch.numbers[p]].aQuestion);
                   cBoxQuestTwo.Items.Add(AQuestion.QuestionList[MixAndMatch.numbers[p]].aQuestion);
                   cBoxQuestThree.Items.Add(AQuestion.QuestionList[MixAndMatch.numbers[p]].aQuestion);
                   cBoxQuestFour.Items.Add(AQuestion.QuestionList[MixAndMatch.numbers[p]].aQuestion);
                   cBoxQuestFive.Items.Add(AQuestion.QuestionList[MixAndMatch.numbers[p]].aQuestion);
                   cBoxQuestSix.Items.Add(AQuestion.QuestionList[MixAndMatch.numbers[p]].aQuestion);
                   p++;
                }
                    MixAndMatch.entries++;
            }
            catch(Exception ex)
            {
                MessageBox.Show("The following error occurred - " + ex.ToString());
            }
        }

        private void MatchQuiz_Load(object sender, EventArgs e)
        {
            MixAndMatch.startingPosition = 0;
            AQuestion.QuestionList = AQuestion.FilterQuestion("E", AQuestion.QuestionList);
            AQuestion.QuestionList = AQuestion.RandomiseQuestions(AQuestion.QuestionList);

            if (AQuestion.QuestionList.Count <= 6)
            {
                btnContinue.Text = "Finish";
            }
            PopulateQuestions(MixAndMatch.startingPosition);
            MixAndMatch.startingPosition = MixAndMatch.entries * 6;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] answers = new string[AQuestion.QuestionList.Count, 2];
                answers[0, 0] = cBoxQuestOne.Text; answers[0, 1] = cboxAnsOne.Text;
                answers[1, 0] = cBoxQuestTwo.Text; answers[1, 1] = cBoxAnsTwo.Text;
                answers[2, 0] = cBoxQuestThree.Text; answers[2, 1] = cBoxAnsThree.Text;
                answers[3, 0] = cBoxQuestFour.Text; answers[3, 1] = cBoxAnsFour.Text;
                answers[4, 0] = cBoxQuestFive.Text; answers[4, 1] = cBoxAnsFive.Text;
                answers[5, 0] = cBoxQuestSix.Text; answers[5, 1] = cBoxAnsSix.Text;

                for (int i = 0; i < 6; i++)
                {
                    if (answers[i, 0] != null)
                    {
                        AQuestion.IsCorrect(answers[i, 0], answers[i, 1]);
                    }
                }

                if (MixAndMatch.RePopulateNeeded)
                {
                    PopulateQuestions(MixAndMatch.startingPosition);
                }
                else
                {
                    QuestionManager.IsHighScore("E");
                    ((MainMenu)ActiveForm).LoadChildForm(new QuizSummary());

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured");
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlInstructions.Visible = false;
        }

    }
}
