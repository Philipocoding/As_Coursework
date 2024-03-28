using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsCoursework
{
    class Leaderboard
    {
        public static void BubbleSort(string set, List<Player> FilteredUsers)
        {
            FilteredUsers.Clear();
            Player temp;

            foreach (User user in User.AllUsers)
            {
                if (user is Player _player)
                {
                    FilteredUsers.Add(_player);
                }
            }
            for (int i = 0; i <= FilteredUsers.Count - 2; i++)
            {
                for (int j = 0; j <= FilteredUsers.Count - 2; j++)
                {
                    int positionJ = 0;
                    int positionJJ = 0;
                    if (set == "A1") { positionJ = FilteredUsers[j].AHighScore; positionJJ = FilteredUsers[j + 1].AHighScore; }
                    if (set == "A2") { positionJ = FilteredUsers[j].AHighScoreTwo; positionJJ = FilteredUsers[j + 1].AHighScoreTwo; }
                    if (set == "A3") { positionJ = FilteredUsers[j].AHighScoreThree; positionJJ = FilteredUsers[j + 1].AHighScoreThree; }
                    if (set == "A4") { positionJ = FilteredUsers[j].AHighScoreFour; positionJJ = FilteredUsers[j + 1].AHighScoreFour; }
                    if (positionJ < positionJJ)
                    {
                        temp = FilteredUsers[j + 1];
                        FilteredUsers[j + 1] = FilteredUsers[j];
                        FilteredUsers[j] = temp;
                    }
                }
            }
        }
        public static void BubbleSort(char set, List<Player> FilteredUsers)
        {
            FilteredUsers.Clear();
            Player temp;

            foreach (User user in User.AllUsers)
            {
                if (user is Player _player)
                {
                    FilteredUsers.Add(_player);
                }
            }
            for (int i = 0; i <= FilteredUsers.Count - 2; i++)
            {
                for (int j = 0; j <= FilteredUsers.Count - 2; j++)
                {
                    int positionJ = 0;
                    int positionJJ = 0;
                    if (set == 'B') { positionJ = FilteredUsers[j].BHighScore; positionJJ = FilteredUsers[j + 1].BHighScore; }
                    if (set == 'C') { positionJ = FilteredUsers[j].CHighScore; positionJJ = FilteredUsers[j + 1].CHighScore; }
                    if (set == 'D') { positionJ = FilteredUsers[j].DHighScore; positionJJ = FilteredUsers[j + 1].DHighScore; }
                    if (set == 'E') { positionJ = FilteredUsers[j].EHighScore; positionJJ = FilteredUsers[j + 1].EHighScore; }
                    if (positionJ < positionJJ) // Checking if the current element is greater than the next element
                    {
                        temp = FilteredUsers[j + 1]; // Swapping elements if they are in the wrong order
                        FilteredUsers[j + 1] = FilteredUsers[j];
                        FilteredUsers[j] = temp;
                    }
                }
            }
        }

    }
}
