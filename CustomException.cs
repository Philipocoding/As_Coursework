using System;

namespace AsCoursework
{
    class CustomException : Exception
    {
        public CustomException()
        {
        }
        public CustomException(string message) : base(message)
        {

        }

    }
}
