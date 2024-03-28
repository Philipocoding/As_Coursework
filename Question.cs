using System;
using System.Collections.Generic;

namespace AsCoursework
{
    public class Question
    {
        public string aQuestion { get; set; }
        public string QuestionID { get; set; }
        public string Answer { get; set; }
        public static int NumberOfQuestions { get; set; }
        public static bool HighScore { get; set; }
        public Question()
        {

        }

        public Question(string _Question)
        {
            this.aQuestion = _Question;
        }

        public Question(string _QuestionID , int _Difficulty, string _Question, string _Answer)
        {  
            this.QuestionID = _QuestionID;
            this.aQuestion = _Question;
            this.Answer = _Answer;
        }

        public Question(string _QuestionID, string _Question, string _Answer)
        {
            this.QuestionID = _QuestionID;
            this.aQuestion = _Question;
            this.Answer = _Answer;
        }

        public virtual void IsCorrect(string userAns, string ans)
        {
            string storedAnswer = ans.Replace(" ", "").ToLower();
            string user_answer = userAns.Replace(" ", "").ToLower();


           if (user_answer == storedAnswer)
           {
                User.LoggedInUser().Score++;
                User.LoggedInUser().Qanswered++;
                User.LoggedInUser().Qcorrect++;
           }
            else
            {
                User.LoggedInUser().Qanswered++;
                User.LoggedInUser().Qincorrect++;
            }
        }

        public virtual List<MultipleChoiceTest> FilterQuestion(List<MultipleChoiceTest> ListToPopulate)
        {
            ListToPopulate.Clear();
            foreach (Question question in QuestionManager.Questions)
            {
                if (question is MultipleChoiceTest _question)
                {
                    ListToPopulate.Add(_question);
                }
            }

            return ListToPopulate;
        }

        public virtual List<Question> FilterQuestion(string set, List<Question> questions) 
        {
            foreach(Question question in QuestionManager.Questions)
            {
                if(question.QuestionID.Contains(set))
                {
                    questions.Add(question);
                }
            }
            return questions;
        }
        
        public virtual List<Question> RandomiseQuestions(List<Question> _questions)
        {
            List<Question> randomList = new List<Question>(_questions);
            int length = randomList.Count;
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(i, length);
                Question temp = randomList[i];
                randomList[i] = randomList[randomIndex];
                randomList[randomIndex] = temp;
            }

            return randomList;
        }
        public List<GuessFlag> RandomiseQuestions(List<GuessFlag> _questions)
        {
            List<GuessFlag> randomList = new List<GuessFlag>(_questions);
            int length = randomList.Count;
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(i, length);
                GuessFlag temp = randomList[i];
                randomList[i] = randomList[randomIndex];
                randomList[randomIndex] = temp;
            }

            return randomList;
        }

        public virtual List<MultipleChoiceTest> RandomiseQuestions(List<MultipleChoiceTest> _questions)
        {
            List<MultipleChoiceTest> randomList = new List<MultipleChoiceTest>(_questions);
            int length = randomList.Count;
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(i, length);
                MultipleChoiceTest temp = randomList[i];
                randomList[i] = randomList[randomIndex];
                randomList[randomIndex] = temp;
            }

            return randomList;
        }
    }
}
