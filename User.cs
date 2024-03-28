using System;
using System.Collections.Generic;

namespace AsCoursework
{
    class User 
    {
        public string Username { get; set; }
        public static bool isPlayer = false;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string UserType { get; set; }
        public int Avatar { get; set; }
        public string Password;
        public int Score = 0;
        static public List<User> AllUsers = new List<User>();
        public int Qanswered { get; set; }
        public int Qcorrect { get; set; }
        public int Qincorrect { get; set; }

        public User()
        {

        }
        public User(string firstname, string surname, string username, string password, string gender, DateTime DOB, string usertype, int answered, int correct, int incorrect)
        {
            this.Username = username;
            this.DateOfBirth = DOB;
            this.Gender = gender;
            this.Firstname = firstname;
            this.Surname = surname;
            this.Password = password;
            this.UserType = usertype;
            this.Qanswered = answered;
            this.Qcorrect = correct;
            this.Qincorrect = incorrect;

        }
        public User (string _firstname, string _surname, string _username)
        {
            this.Firstname = _firstname;
            this.Surname = _surname;
            this.Username = _username;
        }

        public User(string firstname, string surname, string username, string password, string gender, DateTime DOB, string usertype, int avatar,int answered, int correct,int incorrect)
        {
            this.Username = username;
            this.DateOfBirth = DOB;
            this.Gender = gender;
            this.Firstname = firstname;
            this.Surname = surname;
            this.Password = password;
            this.UserType = usertype;
            this.Avatar = avatar;
            this.Qanswered = answered;
            this.Qcorrect = correct;
            this.Qincorrect = incorrect;
        }
        public User(string firstname, string surname, string username, string password, string gender, DateTime DOB, int avatar, int answered, int correct, int incorrect)
        {
            this.Username = username;
            this.DateOfBirth = DOB;
            this.Gender = gender;
            this.Firstname = firstname;
            this.Surname = surname;
            this.Password = password;
            this.Avatar = avatar;
            this.Qanswered = answered;
            this.Qcorrect = correct;
            this.Qincorrect = incorrect;
        }
        public User(string firstname, string surname, string username, string password, string gender, DateTime DOB, int avatar)
        {
            this.Username = username;
            this.DateOfBirth = DOB;
            this.Gender = gender;
            this.Firstname = firstname;
            this.Surname = surname;
            this.Password = password;
            this.Avatar = avatar;
        }

        public virtual void AddUser(User user)
        {
            AllUsers.Add(user);
        }

        static public void AddAvatar(int value)
        {
            LoggedInUser().Avatar = value;

            for(int i = 0; i < AllUsers.Count; i++)
            {
                User Auser = new User();
                Auser = AllUsers[i];
                if (LoggedInUser().Username == Auser.Username)
                {
                    AllUsers.RemoveAt(i);
                    AllUsers.Add(LoggedInUser());
                    break;
                }
            }
            FileHandling.WriteToFile(AllUsers);
            FileHandling.ReadInCsv();
                
            
        }
        static public void DeleteUser()
        {
            for (int i = 0; i < AllUsers.Count; i++)
            {
                if (LoggedInUser().Username == AllUsers[i].Username)
                {
                    AllUsers.RemoveAt(i);
                    FileHandling.WriteToFile(AllUsers);
                    FileHandling.ReadInCsv();
                    break;
                }
            }
        }
        public static int userType = 0;
        public static Player player = new Player();
        public static Admin admin  = new Admin();

        public static void LoginAdmin(string firstname, string surname, string username, string password, string gender, DateTime DOB, string usertype, int avatar,int answered, int correct, int incorrect)
        {
            admin.Firstname = firstname;
            admin.Surname = surname;
            admin.Username = username;
            admin.Password = password;
            admin.Gender = gender;
            admin.DateOfBirth = DOB;
            admin.UserType = usertype;
            admin.Avatar = avatar;
            admin.Qanswered = answered;
            admin.Qcorrect = correct;
            admin.Qincorrect = incorrect;
        }

        public static void LoginPlayer(string firstname, string surname, string username, string password, string gender, DateTime DOB, string UserType, int avatar, int _AHighScore, int _AHighScoreTwo, int _AHighScoreThree, int _AHighScoreFour, int _BHighScore, int _CHighScore, int _DHighScore, int _EHighScore, int answered, int correct, int incorrect)
        {
            userType = 1;
            player.Firstname = firstname;
            player.Surname = surname;
            player.Username = username;
            player.Password = password;
            player.Gender = gender;
            player.DateOfBirth = DOB;
            player.Avatar = avatar;
            player.UserType = UserType;
            player.AHighScore = _AHighScore;
            player.AHighScoreTwo = _AHighScoreTwo;
            player.AHighScoreThree = _AHighScoreThree;
            player.AHighScoreFour = _AHighScoreFour;
            player.BHighScore = _BHighScore;
            player.CHighScore = _CHighScore;
            player.DHighScore = _DHighScore;
            player.EHighScore = _EHighScore;
            player.Qanswered = answered;
            player.Qcorrect = correct;
            player.Qincorrect = incorrect;

        }

        public static User LoggedInUser()
        {
            if(userType == 0)
            {
                return admin;
            }
            else
            {
                return player;
            }
        }

        public static void UpdatePlayer(User player)
        {
            for(int i = 0; i < AllUsers.Count; i++)
            {
                if(AllUsers[i].Username == player.Username)
                {
                    AllUsers.RemoveAt(i);
                    AllUsers.Add(player);
                }
            }
            FileHandling.WriteToFile(AllUsers);
            FileHandling.ReadInCsv();
        }
        public static void UpdatePlayer(User player,string oldUsername)
        {
            for (int i = 0; i < AllUsers.Count; i++)
            {
                if (AllUsers[i].Username == oldUsername)
                {
                    AllUsers.RemoveAt(i);
                    AllUsers.Add(player);
                }
            }
            FileHandling.WriteToFile(AllUsers);
            FileHandling.ReadInCsv();
        }
    }
}
