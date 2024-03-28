using System.Collections.Generic;

namespace AsCoursework
{
    public class CapitalsTest : Question
    {
        public List<Question> CapitalsExtended = new List<Question>();
        public static int timeProvided = 0;
        public static int NumHintsLeft = 3;

        public CapitalsTest(string _qID, string _Question, string _Answer) :base(_qID, _Question, _Answer)
        {
            
        }

        public CapitalsTest()
        {

        }

        public static char Hint(List<Question> questionList)
        {
            int position = QuestionManager.CurrentQuestPosition();
            string storedAnswer = questionList[position].Answer.Replace(" ", "").ToLower();
            char hint = storedAnswer[0];
            return hint;
        }
    }
}
