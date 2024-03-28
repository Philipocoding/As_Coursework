using System;
using System.Collections.Generic;

namespace AsCoursework
{
    public class MixAndMatch : Question
    {
        public List<Question> QuestionList = new List<Question>();
        public static bool RePopulateNeeded = true;
        public static int entries = 0;
        public static int startingPosition { get; set; }
        public static int terminatePosition { get; set; }
        public static List<int> numbers = new List<int>();
        public static int numOfQuestions { get; set; }


        public MixAndMatch()
        {

        }

        public MixAndMatch(string Qid, string _Question, string _Answer) :base(Qid,_Question, _Answer)
        {

        }
        public override void IsCorrect(string userAns, string ans)
        {
            foreach (Question q in QuestionList)
            {
                if (q.aQuestion == userAns)
                {
                    if (q.Answer == ans)
                    {
                        User.LoggedInUser().Score++;
                    }
                }
            }
        }

        public void RandomisePositions()
        {
           
            Random random = new Random();
            numbers.Clear();
            for (int i = startingPosition; i <= terminatePosition; i++)
            {
                numbers.Add(i);
            }


            while (numOfQuestions > 1)
            {
                numOfQuestions--;
                int k = random.Next(numOfQuestions + 1);
                int value = numbers[k];
                numbers[k] = numbers[numOfQuestions];
                numbers[numOfQuestions] = value;
            }
        }

        
    }
}
