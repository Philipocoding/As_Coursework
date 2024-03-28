namespace AsCoursework
{
    class AddAQuestion
    {

        public static bool Entry = true;
        public static bool ValidateQuestion(string question, string TempAnswer, string answer, string QuestionType)
        {
                if ((QuestionType != "Guess The Capital") && (QuestionType != "Multiple Choice") && (QuestionType != "True/False") && (QuestionType != "Guess The Capital"))
                {
                    Entry = false;
                    throw new CustomException("Error: Select a valid Question type");
                }
                if (answer == null)
                {
                    Entry = false;
                    throw new CustomException("Error: Enter an answer");
                }
                if (!question.Contains("?"))
                {
                    question = question + "?";
                }
                if (!Validation.ValidateNullorEmpty(TempAnswer))
                {
                     Entry = false;
                    throw new CustomException("Error: All options must be filled");
                }
                if (!Validation.ValidateNullorEmpty(question))
                {
                    Entry = false;
                    throw new CustomException("Error: All options must be filled");

                }

                if (QuestionType == "True/False")
                {
                    if ((answer.ToLower() != "true") && (answer.ToLower() != "false"))
                    {
                        Entry = false;
                        throw new CustomException("Error: Enter 'True' or 'False'");
                    }

                }

            return Entry;
        }

        public static bool ValidateQuestion(string question, string answer, string QuestionType, string optionOne, string optionTwo, string optionThree)
        {
            bool entry = true;
            if (QuestionType != "Multiple Choice")
            {
                entry = false;
                throw new CustomException("Select a valid Question type");
            }
            if (QuestionType == "Multiple Choice")
            {
                QuestionType = "C";
            }
            if ((!Validation.ValidateNullorEmpty(optionOne)) || (!Validation.ValidateNullorEmpty(optionTwo)) || (!Validation.ValidateNullorEmpty(optionThree)))
            {
                entry = false;
                throw new CustomException("All options must be filled");
            }

            if (!question.Contains("?"))
            {
                question = question + "?";
            }
            if (!Validation.ValidateNullorEmpty(answer))
            {
                entry = false;
                throw new CustomException("All options must be filled");

            }
            if (!Validation.ValidateNullorEmpty(question))
            {
                entry = false;
                throw new CustomException("All options must be filled");

            }

            return entry;
        }


    }
}
