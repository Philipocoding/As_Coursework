using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsCoursework
{
    public class MultipleChoiceTest : Question
    {
        public List<MultipleChoiceTest> QuestionList = new List<MultipleChoiceTest>();
        public static int timeProvided = 0;


        public string OptionOne { get; set; }
        public string OptionTwo { get; set; }
        public string OptionThree { get; set; }
        public MultipleChoiceTest(string _QuestionID, string _Question, string answer, string _OptionOne, string _OptionTwo, string _OptionThree) : base(_QuestionID, _Question, answer)
        {
            this.OptionOne = _OptionOne;
            this.OptionTwo = _OptionTwo;
            this.OptionThree = _OptionThree;
        }
        public MultipleChoiceTest()
        {

        }
    }

}
