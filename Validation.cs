using System;
using System.Text.RegularExpressions;

namespace AsCoursework
{
    public static class Validation
    {
        public static Regex SpecialCharacter = new Regex(@"[^\w\s]");
        public static Regex NumberCharacter = new Regex(@"\d");
        public static Regex UpperCaseCharacter = new Regex(@"[A-Z]");

        
        public static bool ValidateNullorEmpty(string data)
        {          
            if ((String.IsNullOrEmpty(data)))
            {               
                return false;
            }
            else { return true; }          
        }

        public static bool ValidateUnique(string username)
        {
            for (int i = 0; i<User.AllUsers.Count; i++)
            {
                if (username == User.AllUsers[i].Username)
                {
                    return false;                    
                }
            }
            return true;
        }


        public static bool PassMatch(string password, string passwordTwo)
        {
            if (password != passwordTwo)
            {
                return false;
            }
            else { return true; } 
        }
        public static bool PassChange(string password)
        {
          if(User.LoggedInUser().Password == password)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsFirstnameTheSame(string firstname)
        {
            if (User.LoggedInUser().Firstname == firstname)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsSurnameTheSame(string surname)
        {
            if (User.LoggedInUser().Surname == surname)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IsGenderTheSame(string gender)
        {
            if (User.LoggedInUser().Gender == gender)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidGender(string gender)
        {
            if ((gender.ToLower() != "male") &&(gender.ToLower() != "female") &&(gender.ToLower() != "other"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool MinLength(int length, string word)
        {
            int size = word.Length;
            if (size >= length)
            {
                return true;
            }
            else return false;
        }

 
    }
}
