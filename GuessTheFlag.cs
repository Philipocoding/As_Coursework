using System;
using System.Linq;
using System.Windows.Forms;

namespace AsCoursework
{
    public partial class GuessTheFlag : Form
    {
        int counter;
        public static GuessFlag AQuestion = new GuessFlag();

        public GuessTheFlag()
        {
            InitializeComponent();
        }

        private void PopulateObject(int i)
        {
            if (i > 0) { i--; }
            if (i < AQuestion.ListOfQuestions.Count)
            {
                AQuestion.Answer = AQuestion.ListOfQuestions[i].Answer;
                AQuestion.difficulty = AQuestion.ListOfQuestions[i].difficulty;
                AQuestion.QuestionID = AQuestion.ListOfQuestions[i].QuestionID;
                AQuestion.aQuestion = AQuestion.ListOfQuestions[i].aQuestion;
            }

            else
            {
                QuestionManager.IsighScore("A", AQuestion.difficulty);
                ((MainMenu)ActiveForm).LoadChildForm(new QuizSummary());

            }
        }
        private void GuessTheFlag_Load(object sender, EventArgs e)
        {
            QuestionManager.position = 1;
            AQuestion.ListOfQuestions = AQuestion.FilterQuestions("A", AQuestion.difficulty, AQuestion.ListOfQuestions);
            AQuestion.ListOfQuestions = AQuestion.RandomiseQuestions(AQuestion.ListOfQuestions);
            PopulateObject(QuestionManager.FindNextQuestion());
            counter = 0;
            Timer.Start();
            lblTimer.Text = GuessFlag.timeProvided.ToString();
            DisplayFlag(Convert.ToInt32(AQuestion.aQuestion));
       }

        private void txtbAnswer_KeyDown(object sender, KeyEventArgs e)
        {            
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                AQuestion.IsCorrect(txtbAnswer.Text.ToLower(), AQuestion.Answer);
                PopulateObject(QuestionManager.FindNextQuestion());
                DisplayFlag(Convert.ToInt32(AQuestion.aQuestion));
            }
        }

        private void DisplayFlag(int i)
        {
            counter++;
            txtbAnswer.Clear();

            if (counter <= AQuestion.ListOfQuestions.Count())
            {
                try
                {
                    if (AQuestion.difficulty == 1)
                    {
                        switch (i)      
                        {
                            case 1:
                                pcbFlag.Image = Properties.Resources.EasyImageONE;
                                break;
                            case 2:
                                pcbFlag.Image = Properties.Resources.EasyFlagTWO;
                                break;
                            case 3:
                                pcbFlag.Image = Properties.Resources.EasyImageTHREE;
                                break;
                            case 4:
                                pcbFlag.Image = Properties.Resources.EasyFlagFOUR;
                                break;
                            case 5:
                                pcbFlag.Image = Properties.Resources.EasyFlagFive;
                                break;
                            case 6:
                                pcbFlag.Image = Properties.Resources.EasyImageSIX;
                                break;
                            case 7:
                                pcbFlag.Image = Properties.Resources.EasyImageSEVEN;
                                break;
                            case 8:
                                pcbFlag.Image = Properties.Resources.EasyFlagEIGHT;
                                break;
                            case 9:
                                pcbFlag.Image = Properties.Resources.EasyFlagNINE;
                                break;
                            case 10:
                                pcbFlag.Image = Properties.Resources.EasyImageTEN;
                                break;
                            case 11:
                                pcbFlag.Image = Properties.Resources.EasyFlagELEVEN;
                                break;
                            case 12:
                                pcbFlag.Image = Properties.Resources.EasyFlagTWELVE;
                                break;
                            case 13:
                                pcbFlag.Image = Properties.Resources.EasyFlagTHIRTEEN;
                                break;
                            case 14:
                                pcbFlag.Image = Properties.Resources.EasyImageFOURTEEN;
                                break;
                            case 15:
                                pcbFlag.Image = Properties.Resources.EasyImageFIFTEEN;
                                break;
                            case 16:
                                pcbFlag.Image = Properties.Resources.EasyFlagSIXTEEN;
                                break;
                            case 17:
                                pcbFlag.Image = Properties.Resources.EasyFlagSEVENTEEN;
                                break;
                            case 18:
                                pcbFlag.Image = Properties.Resources.EasyFlagEIGHTEEN;
                                break;
                        }

                    }
                
                    if (AQuestion.difficulty == 2)
                    {
                        switch (i)
                        {
                            case 1:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagONE;
                                break;
                            case 2:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagTWO;
                                break;
                            case 3:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagTHREE;
                                break;
                            case 4:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagFOUR;
                                break;
                            case 5:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagFIVE;
                                break;
                            case 6:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagSIX;
                                break;
                            case 7:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagSEVEN;
                                break;
                            case 8:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagEIGHT;
                                break;
                            case 9:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagNINE;
                                break;
                            case 10:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagTEN;
                                break;
                            case 11:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagELEVEN;
                                break;
                            case 12:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagTWELEVE;
                                break;
                            case 13:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagTHIRTEEN;
                                break;
                            case 14:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagFOURTEEN;
                                break;
                            case 15:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagFIFTEEN;
                                break;
                            case 16:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagSIXTEEN;
                                break;
                            case 17:
                                pcbFlag.Image = Properties.Resources.IntermediateFlagSEVENTEEN;
                                break;
                        }

                    }

                    if (AQuestion.difficulty == 3)
                    {
                        switch (i)
                        {
                            case 1:
                                pcbFlag.Image = Properties.Resources.HarduzbekistanONE;
                                break;
                            case 2:
                                pcbFlag.Image = Properties.Resources.HardSriLankaTWO;
                                break;
                            case 3:
                                pcbFlag.Image = Properties.Resources.HardIndonesiaTHREE;
                                break;
                            case 4:
                                pcbFlag.Image = Properties.Resources.HardMaliFOUR;
                                break;
                            case 5:
                                pcbFlag.Image = Properties.Resources.HardAngolaFIVE;
                                break;
                            case 6:
                                pcbFlag.Image = Properties.Resources.HardZambiaSIX;
                                break;
                            case 7:
                                pcbFlag.Image = Properties.Resources.HardCubaSEVEN;
                                break;
                            case 8:
                                pcbFlag.Image = Properties.Resources.HardBoliviaEIGHT;
                                break;
                            case 9:
                                pcbFlag.Image = Properties.Resources.HardHatiNINE;
                                break;
                            case 10:
                                pcbFlag.Image = Properties.Resources.HardTaiwanTEN;
                                break;
                            case 11:
                                pcbFlag.Image = Properties.Resources.HardGuyanaELEVEN;
                                break;
                            case 12:
                                pcbFlag.Image = Properties.Resources.HardSudanTWELEVE;
                                break;
                            case 13:
                                pcbFlag.Image = Properties.Resources.HardSyriaTHIRTEEN;
                                break;
                            case 14:
                                pcbFlag.Image = Properties.Resources.HardYemanFOURTEEN;
                                break;
                            case 15:
                                pcbFlag.Image = Properties.Resources.HardEthiopiaFIFTEEN;
                                break;
                            case 16:
                                pcbFlag.Image = Properties.Resources.HardCambodiaSIXTEEN;
                                break;
                        }
                    }
                    if (AQuestion.difficulty == 4)
                    {
                        switch (i)
                        {
                            case 1:
                                pcbFlag.Image = Properties.Resources.ExpertMongoliaONE;
                                break;
                            case 2:
                                pcbFlag.Image = Properties.Resources.ExpertLaosTWO;
                                break;
                            case 3:
                                pcbFlag.Image = Properties.Resources.ExpertFijiTHREE;
                                break;
                            case 4:
                                pcbFlag.Image = Properties.Resources.ExpertstLuciaFour;
                                break;
                            case 5:
                                pcbFlag.Image = Properties.Resources.ExpertMAdagascarFIVE;
                                break;
                            case 6:
                                pcbFlag.Image = Properties.Resources.ExpertFlagWesternSaharaSIX;
                                break;
                            case 7:
                                pcbFlag.Image = Properties.Resources.ExpertFlagPhilippinesSEVEN;
                                break;
                            case 8:
                                pcbFlag.Image = Properties.Resources.ExpertFlagVanuatuEIght;
                                break;
                            case 9:
                                pcbFlag.Image = Properties.Resources.ExpertFlagBelizeNine;
                                break;
                            case 10:
                                pcbFlag.Image = Properties.Resources.ExpertFlagBarbadosTEN;
                                break;
                            
                        }
                    }
                }
                catch (Exception)
                {
                    Timer.Stop();
                    MessageBox.Show("An Error occured.  This test will be cancelled and not recorded");
                    ((MainMenu)ActiveForm).LoadChildForm(new MainMenu());
                }
            }

            else
            {
                Timer.Stop();
                QuestionManager.IsighScore("A", AQuestion.difficulty);
                ((MainMenu)ActiveForm).LoadChildForm(new QuizSummary());

            }
        }

        int tick = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            tick  += 1000;
            string Tick = tick.ToString();
            lblTimer.Text = ((GuessFlag.timeProvided) - (tick / 1000)).ToString();
            if(tick == GuessFlag.timeProvided * 1000)
            {
                Timer.Stop();
                ((MainMenu)ActiveForm).LoadChildForm(new QuizSummary());

            }
        }
    }
}
