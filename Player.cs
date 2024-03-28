using System;

namespace AsCoursework
{
    class Player : User
    {
        public int AHighScore { get; set; }
        public int AHighScoreTwo { get; set; }

        public int AHighScoreThree { get; set; }

        public int AHighScoreFour { get; set; }


        public int BHighScore { get; set; }
        public string bHighScore
        {
            get { return bHighScore; }

            set
            {
                if (bHighScore == null)
                {
                    bHighScore = "0";
                }
                else
                {
                    bHighScore = value;
                }
            }
        }
        public int CHighScore { get; set; }
        public int DHighScore { get; set; }
        public int EHighScore { get; set; }

        public static Player loggedInPlayer { get; set; }

        public Player()
        {

        }

        public Player(string firstname, string surname, string username, string password, string gender, DateTime DOB, string UserType, int answered, int correct, int incorrect) : base(firstname, surname, username, password, gender, DOB, UserType,answered,correct,incorrect)
        {
            
        }
        public Player(string firstname, string surname, string username, int _AHighScore) : base(firstname, surname, username)
        {
            this.AHighScore = _AHighScore;
        }

        
        public Player(string firstname, string surname, string username, string password, string gender, DateTime DOB, int avatar, int _AHighScore, int _AHighScoreTwo, int _AHighScoreThree, int _AHighScoreFour, int _BHighScore, int _CHighScore, int _DHighScore, int _EHighScore, int answered, int correct, int incorrect) : base(firstname, surname, username, password, gender, DOB, avatar,answered,correct,incorrect)
        {
            this.AHighScore =  _AHighScore;
            this.AHighScoreTwo = _AHighScoreTwo;
            this.AHighScoreThree = _AHighScoreThree;
            this.AHighScoreFour = _AHighScoreFour;
            this.BHighScore =  _BHighScore;
            this.CHighScore =  _CHighScore;
            this.DHighScore =  _DHighScore;
            this.EHighScore = _EHighScore;

        }
        public static Player LoggedInUser()
        {
            return player;
        }

        public override void AddUser(User user)
        {
            AllUsers.Add(user);
        }

        private void UpdateList(Player Updatedplayer)
        {
            int i = 0;
            foreach(Player player in AllUsers)
            {
                if(player.Username == User.LoggedInUser().Username)
                {
                    AllUsers.RemoveAt(i);
                    AllUsers.Add(Updatedplayer);
                    FileHandling.WriteToFile(AllUsers);
                }
                i++;
            }
        }         

        

    }
}
