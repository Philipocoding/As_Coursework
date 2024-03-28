using System;

namespace AsCoursework
{
    class Admin : User
    {
        public static Player loggedInAdmin { get; set; }
     
        public Admin()
        {

        }

        public Admin(string firstname, string surname, string username, string password, string gender, DateTime DOB, string UserType, int answered, int correct, int incorrect) : base(firstname, surname, username, password, gender, DOB, UserType, answered, correct, incorrect)
        {

        }
        public Admin(string firstname, string surname, string username, string password, string gender, DateTime DOB, int avatar) : base(firstname, surname, username, password, gender, DOB, avatar)
        {


        }

        public override void AddUser(User user)
        {
            AllUsers.Add(user);
        }
        public static Admin LoggedInAdmin()
        {
            return User.admin;
        }

        public static void RemoveUser(string username)
        {
           

            int i = 0;
            foreach (User user in User.AllUsers)
            {
                if (user.Username == username)
                {
                    User.AllUsers.RemoveAt(i);
                    break;
                }
                i++;
            }

            FileHandling.WriteToFile(User.AllUsers);
            FileHandling.ReadInCsv();


        }

        public static void RemoveQuestion(string id)
        {

            int i = 0;

            foreach (Question question in QuestionManager.Questions)
            {
                if (question.QuestionID == id)
                {
                    QuestionManager.Questions.RemoveAt(i);
                    break;
                }
                i++;
            }

            FileHandling.WriteQuestions(QuestionManager.Questions);
            FileHandling.ReadInQuestions();

        }
        public static void updateUserDetails(string firstname, string surname, string username, string gender, string UserType, DateTime DOB)//, string password) /*int AHighScoreOne, int AHighScoreTwo, int AHighScoreThree, int AHighScoreFour, int BHighScore, int CHighScore, int DHighScore, int EHighScore)*/
        {
            Player UpdatedPlayer = new Player();
            Admin UpdatedAdmin = new Admin();
            if ((UserType.ToLower() != "admin") && (UserType.ToLower() != "player"))
            {
                throw new CustomException("Enter a valid usertype");
            }
            if (Validation.ValidGender(gender))
            {
                if (UserType == "admin")
                {
                    UpdatedAdmin.Username = username;
                    UpdatedAdmin.Firstname = firstname;
                    UpdatedAdmin.Surname = surname;
                    UpdatedAdmin.Gender = gender;
                    UpdatedAdmin.DateOfBirth = DOB;
                    UpdatedAdmin.UserType = UserType;
                }
                else
                {
                    foreach (User user in AllUsers)
                    {
                        if (user is Player _player)
                        {
                            if (_player.Username == username)
                            {
                                try
                                {
                                    UpdatedPlayer.Username = username;
                                    UpdatedPlayer.Firstname = firstname;
                                    UpdatedPlayer.Surname = surname;
                                    UpdatedPlayer.Gender = gender;
                                    UpdatedPlayer.DateOfBirth = DOB;
                                    UpdatedPlayer.UserType = UserType;
                                    UpdatedPlayer.AHighScore = _player.AHighScore;
                                    UpdatedPlayer.AHighScoreThree = _player.AHighScoreThree;
                                    UpdatedPlayer.AHighScoreThree = _player.AHighScoreThree;
                                    UpdatedPlayer.AHighScoreFour = _player.AHighScoreFour;
                                    UpdatedPlayer.BHighScore = _player.BHighScore;
                                    UpdatedPlayer.CHighScore = _player.CHighScore;
                                    UpdatedPlayer.DHighScore = _player.DHighScore;
                                    UpdatedPlayer.Password = _player.Password;
                                }
                                catch (Exception)
                                {

                                    throw new CustomException("An error occured when editing the user's details");

                                }

                            }
                        }
                    }
                }
                int i = 0;

                foreach (User _user in AllUsers)
                {
                    if (_user.Username == username)
                    {
                        AllUsers.RemoveAt(i);
                        break;
                    }
                    i++;
                }
                if (UpdatedAdmin.Username != null)
                {
                    AllUsers.Add(UpdatedAdmin);

                }
                if (UpdatedPlayer.Username != null)
                {
                    AllUsers.Add(UpdatedPlayer);

                }
                FileHandling.WriteToFile(AllUsers);
                FileHandling.ReadInCsv();
            }

        }
        public static void updateQuestionDetails(string aQuestion, string answer, string ID, string difficulty, string optionOne, string OptionTwo, string Optionthree)
        {
            CapitalsTest capitals = new CapitalsTest();
            TrueOrFalse truefalse = new TrueOrFalse();
            MultipleChoiceTest multiplechoice = new MultipleChoiceTest();
            MixAndMatch match = new MixAndMatch();
            GuessFlag guessFlag = new GuessFlag();

            if ((Validation.ValidateNullorEmpty(aQuestion)) && (Validation.ValidateNullorEmpty(answer)))
            {
                if ((difficulty != "-") && (!ID.Contains("A")))
                {
                    difficulty = "-";
                    throw new CustomException("This question doesn't support a difficulty rating");
                }
                if (ID.Contains("A"))
                {
                    guessFlag.QuestionID = ID;
                    guessFlag.aQuestion = aQuestion;
                    guessFlag.Answer = answer;
                    guessFlag.difficulty = Convert.ToInt32(difficulty);

                }
                if (ID.Contains("B"))
                {
                    capitals.QuestionID = ID;
                    capitals.Answer = answer;
                    capitals.aQuestion = aQuestion;
                }
                if (ID.Contains("C"))
                {
                    multiplechoice.QuestionID = ID;
                    multiplechoice.Answer = answer;
                    multiplechoice.aQuestion = aQuestion;
                    multiplechoice.OptionOne = optionOne;
                    multiplechoice.OptionTwo = OptionTwo;
                    multiplechoice.OptionThree = Optionthree;
                }

                if (ID.Contains("D"))
                {
                    truefalse.QuestionID = ID;
                    truefalse.Answer = answer;
                    truefalse.aQuestion = aQuestion;
                }
                if (ID.Contains("E"))
                {
                    match.QuestionID = ID;
                    match.Answer = answer;
                    match.aQuestion = aQuestion;
                }
                int j = 0;
                foreach (Question question in QuestionManager.Questions)
                {
                    if (question.QuestionID == ID)
                    {
                        QuestionManager.Questions.RemoveAt(j);
                        break;
                    }
                    j++;
                }

                if (guessFlag.QuestionID != null)
                {
                    QuestionManager.Questions.Add(guessFlag);
                }
                if (truefalse.QuestionID != null)
                {
                    QuestionManager.Questions.Add(truefalse);
                }
                if (multiplechoice.QuestionID != null)
                {
                    QuestionManager.Questions.Add(multiplechoice);
                }
                if (match.QuestionID != null)
                {
                    QuestionManager.Questions.Add(match);
                }
                if (capitals.QuestionID != null)
                {
                    QuestionManager.Questions.Add(capitals);
                }

                FileHandling.WriteQuestions(QuestionManager.Questions);
                FileHandling.ReadInQuestions();
            }
        }
    }   
}
