namespace AsCoursework
{
    class Profile_Settings
    {
        public static int CurrentPosition { get; set; }

        public static int OnLeftClick(int position)
        {
            position--;

            if (position < 0)
            {
                CurrentPosition = 4;
                return CurrentPosition;
            }
            else
            {
                CurrentPosition = position;
                return position;
            }
        }

        public static int OnRightCLick(int position)
        {
            position++;
            if (position > 4)
            {
                position = 0;
                CurrentPosition = 0;
                return position;
            }

            else
            {
                CurrentPosition = position;
                return position;
            }
        }
        public static bool UpdateDetails(string firstname, string surname, string gender, string username)
        {
            bool error = false;
            if (!Validation.ValidateNullorEmpty(firstname))
            {
                error = true;
                throw new CustomException("Error: Firstname");
            }

            if (!Validation.ValidateNullorEmpty(surname))
            {
                error = true;
                throw new CustomException("Error: Surname");

            }

            if (!Validation.ValidateNullorEmpty(gender))
            {
                error = true;
                throw new CustomException("Error: Gender");


            }

            if (!Validation.ValidateNullorEmpty(username))
            {
                error = true;
                throw new CustomException("Error: Username");


            }

            if ((gender != "male") && (gender != "female") && (gender != "other"))
            {
                error = true;
                throw new CustomException("Error: Gender");

            }
            return error;
            
        }

        public static bool UpdatePassword(string newpass,string confirmpass, string password, string username)
        {
            bool validate = true;

                if ((User.LoggedInUser().Password == password))
                {
                    if ((Validation.PassMatch(newpass, confirmpass)) && (Validation.PassChange(newpass)))
                    {
                        if (Validation.SpecialCharacter.Matches(newpass).Count == 0)
                        {
                            validate = false;
                        }
                        if (Validation.NumberCharacter.Matches(newpass).Count == 0)
                        {
                            validate = false;

                        }
                        if (Validation.UpperCaseCharacter.Matches(newpass).Count == 0)
                        {
                            validate = false;

                        }
                    }

                        
                }
            
                return validate;
        }
    }
}
