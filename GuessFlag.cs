using System;
using System.Collections.Generic;
using System.Linq;

namespace AsCoursework
{
    public class GuessFlag : Question
    {
        public List<GuessFlag> ListOfQuestions = new List<GuessFlag>();
        public static int timeProvided = 0;

        public int difficulty { get; set; }
        
        public GuessFlag()
        {

        }

        public GuessFlag(string _QuestionId, int Difficulty, string question, string answer) :base(_QuestionId, question, answer)
        {
            this.difficulty = Difficulty;
        }

        public void AddNewQuestion(string question, int difficulty, string ans )
        {
            int i = 0;
            int counter = 0;
            foreach (Question q in QuestionManager.Questions)
            {
                if (QuestionManager.Questions[i].QuestionID.Contains('A'))
                {
                    counter++;
                }
                i++;
            }

            string qID = "A" + counter.ToString();
            Question newQ = new Question(qID, difficulty, question,ans);
            QuestionManager.Questions.Add(newQ);
        }

        public List<GuessFlag> FilterQuestions(string set, int difficulty,List<GuessFlag> ListToPopulate)
        {
            ListToPopulate.Clear();
            foreach (Question question in QuestionManager.Questions)
            {
                if (question.QuestionID.Contains(set.ToUpper()))
                {
                    if(question is GuessFlag _question)
                    {
                        if(_question.difficulty == difficulty)
                        {
                            ListToPopulate.Add(_question);
                        }
                    }
                }
            }

            return ListToPopulate;
        }

        public int Flag(List<int> question, int position)
        {
            return question[position];
        }
    }
}
