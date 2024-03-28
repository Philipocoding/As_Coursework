using System;
using System.Drawing;
using System.Windows.Forms;

namespace AsCoursework
{
    public partial class FrmAdmin : Form
    {
        bool Remove_User = true;
        string username;
        public FrmAdmin()
        {
            InitializeComponent();
        }
        private void RemoveUser()
        {
            dataGridViewAllUsers.Visible = true;
            datagridQuestions.Visible = false;
            pnlQuestionDetails.Visible = false;

            try
            {
                if (dataGridViewAllUsers.SelectedRows.Count > 0)
                {
                    string username;
                    username = dataGridViewAllUsers.SelectedRows[0].Cells["cUsername"].Value.ToString();
                    Admin.RemoveUser(username);
                    PopulateDataGrid();

                }
                else
                {
                    throw new CustomException("Select a user");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RemoveQuestion()
        {
            pnlChangeDetails.Visible = false;
            dataGridViewAllUsers.Visible = false;
            datagridQuestions.Visible = true;
            string id;

            try
            {
                id = datagridQuestions.SelectedRows[0].Cells["QuestionID"].Value.ToString();

                if (datagridQuestions.SelectedRows.Count > 0)
                {
                    Admin.RemoveQuestion(id);
                    PopulateQuestionsGrid();

                }
                else
                {
                    throw new CustomException("Select a Question");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void PopulateDataGrid()
        {
            dataGridViewAllUsers.Rows.Clear();
            foreach (User user in User.AllUsers)
            {
                dataGridViewAllUsers.Rows.Add(user.Firstname, user.Surname, user.Username, user.Gender, user.DateOfBirth, user.UserType);
            }
        }
        private void PopulateQuestionsGrid()
        {
            datagridQuestions.Visible = true;
            datagridQuestions.Rows.Clear();
            foreach (Question question in QuestionManager.Questions)
            {
                if (question is GuessFlag guessflag)
                {
                    datagridQuestions.Rows.Add(guessflag.QuestionID, guessflag.aQuestion, guessflag.difficulty, guessflag.Answer, "-", "-", "-");
                }
                if (question is CapitalsTest)
                {
                    datagridQuestions.Rows.Add(question.QuestionID, question.aQuestion, "-", question.Answer, "-", "-", "-");
                }
                if (question is TrueOrFalse truefalse)
                {
                    datagridQuestions.Rows.Add(question.QuestionID, question.aQuestion, "-", question.Answer, "-", "-", "-");

                }
                if (question is MultipleChoiceTest multiplecoice)
                {
                    datagridQuestions.Rows.Add(question.QuestionID, question.aQuestion, "-", question.Answer, multiplecoice.OptionOne, multiplecoice.OptionTwo, multiplecoice.OptionThree);

                }
                if (question is MixAndMatch mixmatch)
                {
                    string[] _question = new string[2];
                    _question = question.aQuestion.Split(',');
                    datagridQuestions.Rows.Add(question.QuestionID, question.aQuestion, "-", question.Answer, "-", "-", "-");

                }
            }
        }

        private void btnEditUsers_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Select column beside Firstname to select user and edit their details";
            lblMessage.Visible = true;
            Remove_User = true;
            PopulateDataGrid();
            pnlQuestionDetails.Visible = false;
            dataGridViewAllUsers.ClearSelection();
            pnlQuestionDetails.Visible = false;
            dataGridViewAllUsers.Visible = true;
            datagridQuestions.Visible = false;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
                string username = dataGridViewAllUsers.SelectedRows[0].Cells["cUsername"].Value.ToString();
                string UserType = dataGridViewAllUsers.SelectedRows[0].Cells["cUserType"].Value.ToString();
                string gender = txtbGender.Text;

            try
            {
                Admin.updateUserDetails(txtbFirstname.Text, txtbSurname.Text, txtbUsername.Text, txtbGender.Text, txtbUserType.Text, Convert.ToDateTime(txtbDOB.Text));
                PopulateDataGrid();
                timer.Start();
                dataGridViewAllUsers.Visible = false;
                pnlChangeDetails.Visible = false;
                lblGender.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void txtbUsername_MouseLeave(object sender, EventArgs e)
        {
            if(txtbUsername.Text != username)
            {
                MessageBox.Show("Usernames cannot be changed");
                txtbUsername.Text = username;
            }
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            pnlQuestionDetails.Visible = false;
            pnlChangeDetails.Visible = false;
            timer.Start();
            PopulateDataGrid();
            datagridQuestions.DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Regular);
            datagridQuestions.RowTemplate.Height = 45;
            dataGridViewAllUsers.DefaultCellStyle.Font = new Font("Arial", 20, FontStyle.Regular);
            dataGridViewAllUsers.RowTemplate.Height = 45;
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            ((MainMenu)ActiveForm).LoadChildForm(new AddQuestion());
            timer.Stop();

        }

        private void btnQuestions_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Select column to the far left beside ID to select and edit question";
            lblMessage.Visible = true;
            Remove_User = false;
            PopulateQuestionsGrid();
            btnRemove.Visible = true;
            pnlChangeDetails.Visible = false;
            datagridQuestions.ClearSelection();
            dataGridViewAllUsers.Visible = false;
            datagridQuestions.Visible = true;
        }

        
    private void btnSaveQuestions_Click(object sender, EventArgs e)
        {

            string ID = txtbID.Text;
            string aQuestion = txtbQuestion.Text;
            string answer = txtbAswer.Text;
            string optionOne = txtbOption1.Text;
            string optionTwo = txtboption2.Text;
            string optionThree = txtbOption3.Text;
            string difficulty = txtbDifficulty.Text;

            try
            {
                if ((txtbDifficulty.Text != "-") && (!ID.Contains("A")))
                {
                    txtbDifficulty.Text = "-";
                    throw new CustomException("This question doesn't support a difficulty rating");
                }
               
                Admin.updateQuestionDetails(aQuestion, answer, ID, difficulty, optionOne, optionTwo, optionThree);
                PopulateQuestionsGrid();
                pnlQuestionDetails.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        
        private void datagridQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                if (datagridQuestions.SelectedRows.Count > 0)
                {
                    try
                    {
                        dataGridViewAllUsers.ClearSelection();
                        pnlChangeDetails.Visible = false;
                        pnlQuestionDetails.Visible = true;
                        if(Validation.ValidateNullorEmpty(txtbID.Text = datagridQuestions.SelectedRows[0].Cells["QuestionID"].Value?.ToString()))
                        {
                            btnRemove.Visible = true;
                            txtbAswer.Text = datagridQuestions.SelectedRows[0].Cells["Answer"].Value.ToString();
                            txtbQuestion.Text = datagridQuestions.SelectedRows[0].Cells["Question"].Value.ToString();
                            txtbID.Text = datagridQuestions.SelectedRows[0].Cells["QuestionID"].Value.ToString();
                            txtbOption1.Text = datagridQuestions.SelectedRows[0].Cells["OptionOne"].Value.ToString();
                            txtbOption3.Text = datagridQuestions.SelectedRows[0].Cells["OptionTwo"].Value.ToString();
                            txtboption2.Text = datagridQuestions.SelectedRows[0].Cells["OptionThree"].Value.ToString();
                            txtbDifficulty.Text = datagridQuestions.SelectedRows[0].Cells["Difficulty"].Value.ToString();
                    }
                        else
                        {
                            btnRemove.Visible = false;
                            throw new CustomException("Select a row with data");

                        }
                }
                   
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }

                }      
        }

        private void dataGridViewAllUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewAllUsers.SelectedRows.Count > 0)
                {
                    if(Validation.ValidateNullorEmpty(txtbUsername.Text = dataGridViewAllUsers.SelectedRows[0].Cells["cUsername"].Value?.ToString()))
                    {
                        btnRemove.Visible = true;
                        datagridQuestions.ClearSelection();
                        pnlChangeDetails.Visible = true;
                        pnlQuestionDetails.Visible = false;
                        txtbUsername.Text = dataGridViewAllUsers.SelectedRows[0].Cells["cUsername"].Value.ToString();
                        txtbFirstname.Text = dataGridViewAllUsers.SelectedRows[0].Cells["cFirstname"].Value.ToString();
                        txtbSurname.Text = dataGridViewAllUsers.SelectedRows[0].Cells["cSurname"].Value.ToString();
                        txtbGender.Text = dataGridViewAllUsers.SelectedRows[0].Cells["cGender"].Value.ToString();
                        txtbDOB.Text = dataGridViewAllUsers.SelectedRows[0].Cells["cDOB"].Value.ToString();                      
                        txtbUserType.Text = dataGridViewAllUsers.SelectedRows[0].Cells["cUserType"].Value.ToString();
                        username = txtbUsername.Text;
                    }
                   
                }
                else
                {
                    btnRemove.Visible = false;

                    throw new CustomException("Seect a row with data");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(Remove_User)
            {
                RemoveUser();
                pnlChangeDetails.Visible = false;
            }
            else
            {
                RemoveQuestion();
            }
        }
    }
}
