using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsCoursework
{
    static class QuestionManager
    {
        public static List<Question> AnsweredQuestions = new List<Question>();
        public static List<Question> Questions = new List<Question>();

        public static void AddNewQuestion(string question, string qType, int ans)
        {
            int i = 0;
            int counter = 0;
            foreach (Question q in Questions)
            {
                if (Questions[i].QuestionID.Contains(qType))
                {
                    counter++;
                }
                i++;
            }

            string qID = qType + counter.ToString();
            if(qType == "B")
            {
                CapitalsTest Newquestion = new CapitalsTest(qID, question, ans.ToString());
                Questions.Add(Newquestion);
                FileHandling.WriteQuestions(Questions);
            }
            FileHandling.WriteQuestions(Questions);
        }
        public static void AddNewQuestion(string question, string qType, string ans)
        {
            int i = 0;
            int counter = 0;

            try
            {
                switch (qType)
                {
                    //Bades on the question type the user selects the question ID can begin to be formed
                    case "Guess The Capital":
                        qType = "B";
                        break;
                    case "Multiple Choice":
                        qType = "C";
                        break;
                    case "True/False":
                        qType = "D";
                        break;
                    case "Match":
                        qType = "E";
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured with that question type.  Please Try again");
            }

            foreach (Question q in Questions)
            {
                //Calculates how any questions of the same question type exist
                if (Questions[i].QuestionID.Contains(qType))
                {
                    counter++;
                }
                i++;
            }

            //THe question ID is formed by combining the letter assigned from the question type annd the number of questions that already exist
            string qID = qType + counter.ToString();

            //Now the question object is created based on the 'qtype' cariabel it was assigned. 
            if (qType == "B")
            {
                CapitalsTest Newquestion = new CapitalsTest(qID, question, ans.ToString());
                Questions.Add(Newquestion);
                FileHandling.WriteQuestions(Questions);
                FileHandling.ReadInQuestions();
            }

            if (qType == "D")
            {
                TrueOrFalse Newquestion = new TrueOrFalse(qID, question, ans.ToString());
                Questions.Add(Newquestion);
                FileHandling.WriteQuestions(Questions);
                FileHandling.ReadInQuestions();
            }

            if (qType == "E")
            {
                MixAndMatch Newquestion = new MixAndMatch(qID, question, ans.ToString());
                Questions.Add(Newquestion);
                FileHandling.WriteQuestions(Questions);
                FileHandling.ReadInQuestions();
            }
        }

        public static void AddNewQuestion(string question, string qID, string ans, string OptionOne, string OptionTwo, string OptionThree)
        {
            int i = 0;
            int counter = 1;

            foreach (Question q in Questions)
            {
                if (Questions[i].QuestionID.Contains(qID))
                {
                    counter++;
                }
                i++;
            }

            string QID = "C" + counter.ToString();
            MultipleChoiceTest Newquestion = new MultipleChoiceTest(QID, question, ans, OptionOne, OptionTwo, OptionThree);
            Questions.Add(Newquestion);
            FileHandling.WriteQuestions(Questions);
            FileHandling.ReadInQuestions();
           
        }

        public static bool FirstEntry = true;
        public static int position = 0;
        public static int FindNextQuestion()
        {
            if (FirstEntry)
            {
                FirstEntry = false;
                return 0;
            }
            position++;
            return position;
        }
        public static int CurrentQuestPosition()
        {
            return position;
        }

        public static void Answered_Questions(Question question)
        {
            AnsweredQuestions.Add(question);
        }
        public static void IsighScore(string QuestionSet, int difficulty)
        {
            if(QuestionSet == "A")
            {
                switch(difficulty)
                {
                    case 1:
                        if (Player.LoggedInUser().Score > (Convert.ToInt32(Player.LoggedInUser().AHighScore)))
                        {
                            Player.LoggedInUser().AHighScore = Player.LoggedInUser().Score;
                            User.UpdatePlayer(Player.LoggedInUser());
                            Question.HighScore = true;
                        }
                        break;
                    case 2:
                        if (Player.LoggedInUser().Score > (Convert.ToInt32(Player.LoggedInUser().AHighScoreTwo)))
                        {
                            Player.LoggedInUser().AHighScoreTwo = Player.LoggedInUser().Score;
                            User.UpdatePlayer(Player.LoggedInUser());
                            Question.HighScore = true;
                        }
                        break;
                    case 3:
                        if (Player.LoggedInUser().Score > (Convert.ToInt32(Player.LoggedInUser().AHighScoreThree)))
                        {
                            Player.LoggedInUser().AHighScoreThree = Player.LoggedInUser().Score;
                            User.UpdatePlayer(Player.LoggedInUser());
                            Question.HighScore = true;
                        }
                        break;
                    case 4:
                        if (Player.LoggedInUser().Score > (Convert.ToInt32(Player.LoggedInUser().AHighScoreFour)))
                        {
                            Player.LoggedInUser().AHighScoreFour = Player.LoggedInUser().Score;
                            User.UpdatePlayer(Player.LoggedInUser());
                            Question.HighScore = true;
                        }
                        break;
                }
            }
        }
        public static void IsHighScore(string Questionset)
        {
            switch (Questionset)
                {
                    case "A":
                        if (Player.LoggedInUser().Score > (Convert.ToInt32(Player.LoggedInUser().AHighScore))) 
                        {
                            Player.LoggedInUser().AHighScore = Player.LoggedInUser().Score;
                            User.UpdatePlayer(Player.LoggedInUser());
                            Question.HighScore = true;
                        }
                        break;

                    case "B":
                        if (User.LoggedInUser().Score > (Convert.ToInt32(Player.LoggedInUser().BHighScore)))
                        {
                            Player.LoggedInUser().BHighScore = Player.LoggedInUser().Score;
                            Player.UpdatePlayer(Player.LoggedInUser());
                            Question.HighScore = true;
                        }
                        break;
                    case "C":
                        if (Player.LoggedInUser().Score > (Convert.ToInt32(Player.LoggedInUser().CHighScore)))
                        {
                            Player.LoggedInUser().CHighScore = Player.LoggedInUser().Score;
                            User.UpdatePlayer(Player.LoggedInUser());
                            Question.HighScore = true;
                        }
                        break;
                    case "D":
                        if (User.LoggedInUser().Score > (Convert.ToInt32(Player.LoggedInUser().DHighScore)))
                        {
                            Player.LoggedInUser().DHighScore = Player.LoggedInUser().Score;
                            User.UpdatePlayer(Player.LoggedInUser());
                            Question.HighScore = true;
                        }
                        break;
                    case "E":
                        if (User.LoggedInUser().Score > (Convert.ToInt32(Player.LoggedInUser().EHighScore)))
                        {
                            Player.LoggedInUser().DHighScore = Player.LoggedInUser().Score;
                            User.UpdatePlayer(Player.LoggedInUser());
                            Question.HighScore = true;
                        }
                        break;

                default:
                        Question.HighScore = false;
                        break;

                
            }
        }
    }
}
