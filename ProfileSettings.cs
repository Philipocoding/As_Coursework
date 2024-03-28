using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsCoursework
{
    class ProfileSettings
    {
        public static int CurrentPosition { get; set; }

        public static int OnLeftClick(int position)
        {
            position--;

            if(position < 0)
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
            if(position > 4)
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
    }
}
