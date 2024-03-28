using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AsCoursework
{
    public partial class Leaderboards : Form
    {
        List<Player> FilteredUsers = new List<Player>();

        public Leaderboards()
        {
            InitializeComponent();
        }       

        private void btnGuessFlag_Click(object sender, EventArgs e)
        {
            pnlQuizChoice.Visible = false;
            pnlDifficulty.Visible = true;
        }

        private void btnCapitals_Click(object sender, EventArgs e)
        {
            pnlQuizChoice.Visible = false;
            pnlDifficulty.Visible = false;
            Leaderboard.BubbleSort('B',FilteredUsers);
            dataGridLeaderboard.Visible = true;
            foreach (Player player in FilteredUsers)
            {
                dataGridLeaderboard.Rows.Add(player.Firstname, player.Surname, player.Username, player.BHighScore);

            }
        }

        private void btnMultiChoice_Click(object sender, EventArgs e)
        {
            pnlQuizChoice.Visible = false;
            pnlDifficulty.Visible = false;

            Leaderboard.BubbleSort('C', FilteredUsers);
            dataGridLeaderboard.Visible = true;

            foreach (Player player in FilteredUsers)
            {
                dataGridLeaderboard.Rows.Add(player.Firstname, player.Surname, player.Username, player.CHighScore);
            }
        }

        private void btnTrueFalse_Click(object sender, EventArgs e)
        {
            pnlQuizChoice.Visible = false;
            pnlDifficulty.Visible = false;

            Leaderboard.BubbleSort('D', FilteredUsers);
            dataGridLeaderboard.Visible = true;

            foreach (Player player in FilteredUsers)
            {
                dataGridLeaderboard.Rows.Add(player.Firstname, player.Surname, player.Username, player.DHighScore);

            }
        }
        private void Leaderboards_Load(object sender, EventArgs e)
        {
            pnlQuizChoice.Visible = true;
            pnlDifficulty.Visible = true;
            dataGridLeaderboard.Rows.Clear();
            pnlQuizChoice.BringToFront();
            dataGridLeaderboard.DefaultCellStyle.Font = new Font("Arial", 26, FontStyle.Regular);
            dataGridLeaderboard.RowTemplate.Height = 45;
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Leaderboard.BubbleSort("A1", FilteredUsers);
            pnlDifficulty.Visible = false;

            foreach (Player player in FilteredUsers)
            {
                dataGridLeaderboard.Rows.Add(player.Firstname, player.Surname, player.Username, player.AHighScore);

            }
            dataGridLeaderboard.Visible = true;

        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            Leaderboard.BubbleSort("A2", FilteredUsers);
            dataGridLeaderboard.Visible = true;
            pnlDifficulty.Visible = false;

            foreach (Player player in FilteredUsers)
            {
                dataGridLeaderboard.Rows.Add(player.Firstname, player.Surname, player.Username, player.AHighScoreTwo);

            }
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Leaderboard.BubbleSort("A3", FilteredUsers);
            dataGridLeaderboard.Visible = true;
            pnlDifficulty.Visible = false;
            foreach (Player player in FilteredUsers)
            {
                dataGridLeaderboard.Rows.Add(player.Firstname, player.Surname, player.Username, player.AHighScoreThree);

            }
        }

        private void btnExpert_Click(object sender, EventArgs e)
        {
            Leaderboard.BubbleSort("A4", FilteredUsers);
            dataGridLeaderboard.Visible = true;
            pnlDifficulty.Visible = false;

            foreach (Player player in FilteredUsers)
            {
                dataGridLeaderboard.Rows.Add(player.Firstname, player.Surname, player.Username, player.AHighScoreFour);

            }
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            Leaderboard.BubbleSort('E', FilteredUsers);
            dataGridLeaderboard.Visible = true;
            pnlDifficulty.Visible = false;

            foreach (Player player in FilteredUsers)
            {
                dataGridLeaderboard.Rows.Add(player.Firstname, player.Surname, player.Username, player.EHighScore);

            }
        }

        private void btnViewAnotherLeaderboard_Click(object sender, EventArgs e)
        {
            dataGridLeaderboard.Rows.Clear();
            pnlDifficulty.Visible = true;
            pnlQuizChoice.Visible = true;
        }
    }
}
