namespace AsCoursework
{
    static class _Login
    {
        public static bool CheckUsername(string username, string enteredUsername)
        {
            bool match = false;
            if(username == enteredUsername)
            {
                match = true;
            }
            return match;
        }

        public static bool CheckPassword(string password, string enteredPassword)
        {
            bool match = false;
            if (password == enteredPassword)
            {
                match = true;
            }
            return match;
        }

        public static void Login(User user)
        {
            if (user is Player _player)
            {
                User.LoginPlayer(_player.Firstname, _player.Surname, _player.Username, _player.Password, _player.Gender, _player.DateOfBirth, _player.UserType, _player.Avatar, _player.AHighScore, _player.AHighScoreTwo, _player.AHighScoreThree, _player.AHighScoreFour, _player.BHighScore, _player.CHighScore, _player.DHighScore, _player.EHighScore, _player.Qanswered, _player.Qcorrect, _player.Qincorrect);
            }
            if (user is Admin _Admin)
            {
                User.LoginAdmin(_Admin.Firstname, _Admin.Surname, _Admin.Username, _Admin.Password, _Admin.Gender, _Admin.DateOfBirth, _Admin.UserType, _Admin.Avatar, _Admin.Qanswered, _Admin.Qcorrect, _Admin.Qincorrect);
            }
        }

    }
}
