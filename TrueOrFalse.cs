using System.Collections.Generic;

namespace AsCoursework
{
    public class TrueOrFalse : Question
    {
        public List<Question> QuestionList = new List<Question>();

        public TrueOrFalse()
        {

        }

        public TrueOrFalse(string QId, string question, string answer):base(QId, question, answer)
        {

       
        }
    }
}
