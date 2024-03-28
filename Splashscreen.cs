using System;
using System.Windows.Forms;

namespace AsCoursework
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
         //   pnlBigLoad.BringToFront();
            FileHandling.ReadInCsv();
            FileHandling.ReadInQuestions();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlLoading.Width += 5;
            if (pnlLoading.Width >= pnlBlackLoading.Width - 10)
            {
                timer1.Stop();
                this.Hide();
                Login login = new Login();
                login.Show();


            }

        }

    }
}
