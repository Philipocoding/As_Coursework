using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AsCoursework
{
    static class FileHandling
    {
        static string path = "Users.csv";
        static string Qpath = "Questions.csv";

        static public void WriteToFile(List<User> data)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    foreach (User user in data)
                    {
                        if (user is Player player)
                        {
                            sw.WriteLine($"{player.Firstname},{player.Surname},{player.Username},{player.Gender},{player.DateOfBirth.ToShortDateString()},{player.Password},{player.UserType},{player.Avatar},{player.AHighScore},{player.AHighScoreTwo},{player.AHighScoreThree},{player.AHighScoreFour},{player.BHighScore},{player.CHighScore},{player.DHighScore},{player.EHighScore},{player.Qanswered},{player.Qcorrect},{player.Qincorrect}");
                        }
                        if (user is Admin admin)
                        {
                            sw.WriteLine($"{admin.Firstname},{admin.Surname},{admin.Username},{admin.Gender},{admin.DateOfBirth.ToShortDateString()},{admin.Password},{admin.UserType},{admin.Avatar},{admin.Qanswered},{admin.Qcorrect},{admin.Qincorrect}");
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new CustomException("An error occurred when sending the user data to the file");
            }

        }

        static public void WriteQuestions(List<Question> data)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Qpath, false))
                {
                    for (int i = 0; i < data.Count(); i++)
                    {
                        if(data[i] is  MultipleChoiceTest _data)
                        {
                            sw.WriteLine($"{_data.QuestionID},{_data.aQuestion},{_data.Answer},{_data.OptionOne},{_data.OptionTwo},{_data.OptionThree}");

                        }

                        if (data[i] is GuessFlag guessflag)
                        {
                            sw.WriteLine($"{guessflag.QuestionID},{guessflag.difficulty},{guessflag.aQuestion},{guessflag.Answer}");

                        }

                        if (data[i] is CapitalsTest capitals)
                        {
                            sw.WriteLine($"{capitals.QuestionID},{capitals.aQuestion},{capitals.Answer}");

                        }

                        if (data[i] is TrueOrFalse True_false)
                        {
                            sw.WriteLine($"{True_false.QuestionID},{True_false.aQuestion},{True_false.Answer}");

                        }
                        if (data[i] is MixAndMatch Match)
                        {
                            sw.WriteLine($"{Match.QuestionID},{Match.aQuestion},{Match.Answer}");

                        }
                    }
                }

            }
            catch (Exception)
            {
                throw new CustomException("An error occured trying to send the question data to the file");
            }

        }

        static public void ReadInQuestions()
        {
            
                QuestionManager.Questions.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(Qpath))
                {
                    int NumLines = File.ReadAllLines(Qpath).Count();
                    int NumMultiChoiceElements = 7;
                    string[] QuestionArray = new string[NumLines];
                    string[] TempArray = new string[NumMultiChoiceElements];
                    QuestionArray = File.ReadAllLines(Qpath);

                    for (int i = 0; i < NumLines; i++)
                    {
                        List<string> tempQuestion = new List<string>(QuestionArray[i].Split(','));

                        TempArray = QuestionArray[i].Split(',');

                        if (tempQuestion[0].Contains("A"))
                        {
                            GuessFlag question = new GuessFlag();
                            question.QuestionID = tempQuestion[0];
                            question.difficulty = Convert.ToInt32(tempQuestion[1]);
                            question.aQuestion = tempQuestion[2];
                            question.Answer = tempQuestion[3];
                            QuestionManager.Questions.Add(question);
                        }

                        if (tempQuestion[0].Contains("B"))
                        {
                            CapitalsTest question = new CapitalsTest();
                            question.QuestionID = tempQuestion[0];
                            question.aQuestion = tempQuestion[1];
                            question.Answer = tempQuestion[2];
                            QuestionManager.Questions.Add(question);
                        }
                        if (tempQuestion[0].Contains("C"))
                        {
                            MultipleChoiceTest question = new MultipleChoiceTest();
                            question.QuestionID = tempQuestion[0];
                            question.aQuestion = tempQuestion[1];
                            question.Answer = tempQuestion[2];
                            question.OptionOne = tempQuestion[3];
                            question.OptionTwo = tempQuestion[4];
                            question.OptionThree = tempQuestion[5];
                            QuestionManager.Questions.Add(question);
                        }

                        if (tempQuestion[0].Contains("D"))
                        {
                            TrueOrFalse question = new TrueOrFalse();
                            question.QuestionID = tempQuestion[0];
                            question.aQuestion = tempQuestion[1];
                            question.Answer = tempQuestion[2];
                            QuestionManager.Questions.Add(question);
                        }
                        if (tempQuestion[0].Contains("E"))
                        {
                            MixAndMatch question = new MixAndMatch();
                            question.QuestionID = tempQuestion[0];
                            question.aQuestion = tempQuestion[1];
                            question.Answer = tempQuestion[2];
                            QuestionManager.Questions.Add(question);
                        }
                    }
                }
            }
            catch(Exception)
            {
               
            }      
        }

        static public void ReadInCsv()
        {
            try
            {
                User.AllUsers.Clear();
                User user = new User();
                using (StreamReader sr = new StreamReader(path))
                {
                    int NumLines = File.ReadAllLines(path).Count();
                    int NumberOfPlayerElements = 18;
                    string[] UserArray = new string[NumLines];
                    string[] TempArray = new string[NumberOfPlayerElements];
                    UserArray = File.ReadAllLines(path);

                    for (int i = 0; i < NumLines; i++)
                    {
                        List<string> tempuser = new List<string>(UserArray[i].Split(','));

                        if (tempuser[6] == "player")
                        {
                            Player player = new Player();
                            player.Firstname = tempuser[0];
                            player.Surname = tempuser[1];
                            player.Username = tempuser[2];
                            player.Gender = tempuser[3];
                            player.DateOfBirth = DateTime.Parse(tempuser[4]);
                            player.Password = tempuser[5];
                            player.UserType = tempuser[6];
                            player.Avatar = Convert.ToInt32(tempuser[7]);
                            player.AHighScore = Convert.ToInt32(tempuser[8]);
                            player.AHighScoreTwo = Convert.ToInt32(tempuser[9]);
                            player.AHighScoreThree = Convert.ToInt32(tempuser[10]);
                            player.AHighScoreFour = Convert.ToInt32(tempuser[11]);
                            player.BHighScore = Convert.ToInt32(tempuser[12]);
                            player.CHighScore = Convert.ToInt32(tempuser[13]);
                            player.DHighScore = Convert.ToInt32(tempuser[14]);
                            player.EHighScore = Convert.ToInt32(tempuser[15]);
                            player.Qanswered = Convert.ToInt32(tempuser[16]);
                            player.Qcorrect = Convert.ToInt32(tempuser[17]);
                            player.Qincorrect = Convert.ToInt32(tempuser[18]);

                            User.AllUsers.Add(player);
                        }
                        else
                        {
                            Admin admin = new Admin();
                            admin.Firstname = tempuser[0];
                            admin.Surname = tempuser[1];
                            admin.Username = tempuser[2];
                            admin.Gender = tempuser[3];
                            admin.DateOfBirth = DateTime.Parse(tempuser[4]);
                            admin.Password = tempuser[5];
                            admin.UserType = tempuser[6];
                            admin.Avatar = Convert.ToInt32(tempuser[7]);
                            admin.Qanswered = Convert.ToInt32(tempuser[8]);
                            admin.Qcorrect = Convert.ToInt32(tempuser[9]);
                            admin.Qincorrect = Convert.ToInt32(tempuser[10]);
                            User.AllUsers.Add(admin);
                        }
                    }

                }

            }
            catch(Exception)
            {

            }
        }
    }
}
