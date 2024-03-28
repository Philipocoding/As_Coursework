
namespace AsCoursework
{
    partial class FrmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridQuestions = new System.Windows.Forms.DataGridView();
            this.QuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionThree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAllUsers = new System.Windows.Forms.DataGridView();
            this.cFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlChangeDetails = new System.Windows.Forms.Panel();
            this.txtbGender = new System.Windows.Forms.TextBox();
            this.txtbDOB = new System.Windows.Forms.TextBox();
            this.txtbUserType = new System.Windows.Forms.TextBox();
            this.txtbSurname = new System.Windows.Forms.TextBox();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.txtbFirstname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.btnEditUsers = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuestions = new System.Windows.Forms.Button();
            this.pnlQuestionDetails = new System.Windows.Forms.Panel();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.txtbDifficulty = new System.Windows.Forms.TextBox();
            this.btnSaveQuestions = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.txtbAswer = new System.Windows.Forms.TextBox();
            this.txtbOption1 = new System.Windows.Forms.TextBox();
            this.txtboption2 = new System.Windows.Forms.TextBox();
            this.txtbOption3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbQuestion = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllUsers)).BeginInit();
            this.pnlChangeDetails.SuspendLayout();
            this.pnlQuestionDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(927, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 62);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.datagridQuestions);
            this.panel1.Controls.Add(this.dataGridViewAllUsers);
            this.panel1.Location = new System.Drawing.Point(277, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 504);
            this.panel1.TabIndex = 2;
            // 
            // datagridQuestions
            // 
            this.datagridQuestions.AllowUserToAddRows = false;
            this.datagridQuestions.AllowUserToDeleteRows = false;
            this.datagridQuestions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.datagridQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionID,
            this.Question,
            this.Difficulty,
            this.Answer,
            this.OptionOne,
            this.OptionTwo,
            this.OptionThree});
            this.datagridQuestions.Location = new System.Drawing.Point(0, 4);
            this.datagridQuestions.Name = "datagridQuestions";
            this.datagridQuestions.ReadOnly = true;
            this.datagridQuestions.Size = new System.Drawing.Size(1202, 515);
            this.datagridQuestions.TabIndex = 1;
            this.datagridQuestions.Visible = false;
            this.datagridQuestions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridQuestions_CellClick);
            // 
            // QuestionID
            // 
            this.QuestionID.HeaderText = "ID";
            this.QuestionID.Name = "QuestionID";
            this.QuestionID.ReadOnly = true;
            this.QuestionID.Width = 45;
            // 
            // Question
            // 
            this.Question.HeaderText = "Question";
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            this.Question.Width = 480;
            // 
            // Difficulty
            // 
            this.Difficulty.HeaderText = "Difficulty";
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.ReadOnly = true;
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Answer";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Width = 160;
            // 
            // OptionOne
            // 
            this.OptionOne.HeaderText = "Option 1";
            this.OptionOne.Name = "OptionOne";
            this.OptionOne.ReadOnly = true;
            this.OptionOne.Width = 120;
            // 
            // OptionTwo
            // 
            this.OptionTwo.HeaderText = "Option 2";
            this.OptionTwo.Name = "OptionTwo";
            this.OptionTwo.ReadOnly = true;
            this.OptionTwo.Width = 120;
            // 
            // OptionThree
            // 
            this.OptionThree.HeaderText = "Option 3";
            this.OptionThree.Name = "OptionThree";
            this.OptionThree.ReadOnly = true;
            this.OptionThree.Width = 120;
            // 
            // dataGridViewAllUsers
            // 
            this.dataGridViewAllUsers.AllowUserToAddRows = false;
            this.dataGridViewAllUsers.AllowUserToDeleteRows = false;
            this.dataGridViewAllUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewAllUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.dataGridViewAllUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFirstname,
            this.cSurname,
            this.cUsername,
            this.cGender,
            this.cDOB,
            this.cUserType});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAllUsers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAllUsers.GridColor = System.Drawing.Color.Silver;
            this.dataGridViewAllUsers.Location = new System.Drawing.Point(119, 3);
            this.dataGridViewAllUsers.Name = "dataGridViewAllUsers";
            this.dataGridViewAllUsers.ReadOnly = true;
            this.dataGridViewAllUsers.Size = new System.Drawing.Size(924, 503);
            this.dataGridViewAllUsers.TabIndex = 0;
            this.dataGridViewAllUsers.Visible = false;
            this.dataGridViewAllUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllUsers_CellClick);
            // 
            // cFirstname
            // 
            this.cFirstname.HeaderText = "Firstname";
            this.cFirstname.Name = "cFirstname";
            this.cFirstname.ReadOnly = true;
            this.cFirstname.Width = 140;
            // 
            // cSurname
            // 
            this.cSurname.HeaderText = "Surname";
            this.cSurname.Name = "cSurname";
            this.cSurname.ReadOnly = true;
            this.cSurname.Width = 140;
            // 
            // cUsername
            // 
            this.cUsername.HeaderText = "Username";
            this.cUsername.Name = "cUsername";
            this.cUsername.ReadOnly = true;
            this.cUsername.Width = 140;
            // 
            // cGender
            // 
            this.cGender.HeaderText = "Gender";
            this.cGender.Name = "cGender";
            this.cGender.ReadOnly = true;
            this.cGender.Width = 140;
            // 
            // cDOB
            // 
            this.cDOB.HeaderText = "Date Of Birth";
            this.cDOB.Name = "cDOB";
            this.cDOB.ReadOnly = true;
            this.cDOB.Width = 180;
            // 
            // cUserType
            // 
            this.cUserType.HeaderText = "Usertype";
            this.cUserType.Name = "cUserType";
            this.cUserType.ReadOnly = true;
            this.cUserType.Width = 140;
            // 
            // pnlChangeDetails
            // 
            this.pnlChangeDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlChangeDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.pnlChangeDetails.Controls.Add(this.txtbGender);
            this.pnlChangeDetails.Controls.Add(this.txtbDOB);
            this.pnlChangeDetails.Controls.Add(this.txtbUserType);
            this.pnlChangeDetails.Controls.Add(this.txtbSurname);
            this.pnlChangeDetails.Controls.Add(this.txtbUsername);
            this.pnlChangeDetails.Controls.Add(this.txtbFirstname);
            this.pnlChangeDetails.Controls.Add(this.btnSave);
            this.pnlChangeDetails.Controls.Add(this.lblSurname);
            this.pnlChangeDetails.Controls.Add(this.lblDOB);
            this.pnlChangeDetails.Controls.Add(this.lblGender);
            this.pnlChangeDetails.Controls.Add(this.label4);
            this.pnlChangeDetails.Controls.Add(this.lblUsername);
            this.pnlChangeDetails.Controls.Add(this.lblFirstname);
            this.pnlChangeDetails.Location = new System.Drawing.Point(294, 546);
            this.pnlChangeDetails.Name = "pnlChangeDetails";
            this.pnlChangeDetails.Size = new System.Drawing.Size(1113, 284);
            this.pnlChangeDetails.TabIndex = 1;
            this.pnlChangeDetails.Visible = false;
            // 
            // txtbGender
            // 
            this.txtbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbGender.Location = new System.Drawing.Point(242, 229);
            this.txtbGender.Name = "txtbGender";
            this.txtbGender.Size = new System.Drawing.Size(221, 47);
            this.txtbGender.TabIndex = 13;
            // 
            // txtbDOB
            // 
            this.txtbDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDOB.Location = new System.Drawing.Point(672, 103);
            this.txtbDOB.Name = "txtbDOB";
            this.txtbDOB.Size = new System.Drawing.Size(334, 47);
            this.txtbDOB.TabIndex = 12;
            // 
            // txtbUserType
            // 
            this.txtbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUserType.Location = new System.Drawing.Point(672, 26);
            this.txtbUserType.Name = "txtbUserType";
            this.txtbUserType.Size = new System.Drawing.Size(221, 47);
            this.txtbUserType.TabIndex = 10;
            // 
            // txtbSurname
            // 
            this.txtbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSurname.Location = new System.Drawing.Point(242, 82);
            this.txtbSurname.Name = "txtbSurname";
            this.txtbSurname.Size = new System.Drawing.Size(221, 47);
            this.txtbSurname.TabIndex = 9;
            // 
            // txtbUsername
            // 
            this.txtbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUsername.Location = new System.Drawing.Point(242, 160);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(221, 47);
            this.txtbUsername.TabIndex = 8;
            this.txtbUsername.MouseLeave += new System.EventHandler(this.txtbUsername_MouseLeave);
            // 
            // txtbFirstname
            // 
            this.txtbFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFirstname.Location = new System.Drawing.Point(242, 13);
            this.txtbFirstname.Name = "txtbFirstname";
            this.txtbFirstname.Size = new System.Drawing.Size(221, 47);
            this.txtbFirstname.TabIndex = 7;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(47, 82);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(165, 39);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(512, 91);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(145, 78);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "Date of \r\n  Birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(47, 229);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(138, 39);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usertype";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(47, 163);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(186, 39);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(47, 21);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(182, 39);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "Firstname";
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.btnEditUsers.FlatAppearance.BorderSize = 0;
            this.btnEditUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUsers.Location = new System.Drawing.Point(14, 47);
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Size = new System.Drawing.Size(257, 86);
            this.btnEditUsers.TabIndex = 1;
            this.btnEditUsers.Text = "Edit Users";
            this.btnEditUsers.UseVisualStyleBackColor = false;
            this.btnEditUsers.Click += new System.EventHandler(this.btnEditUsers_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.btnAddQuestion.FlatAppearance.BorderSize = 0;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.Location = new System.Drawing.Point(14, 139);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(257, 84);
            this.btnAddQuestion.TabIndex = 4;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // Firstname
            // 
            this.Firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstname.DefaultCellStyle = dataGridViewCellStyle2;
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname.DefaultCellStyle = dataGridViewCellStyle3;
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // btnQuestions
            // 
            this.btnQuestions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.btnQuestions.FlatAppearance.BorderSize = 0;
            this.btnQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestions.Location = new System.Drawing.Point(12, 229);
            this.btnQuestions.Name = "btnQuestions";
            this.btnQuestions.Size = new System.Drawing.Size(259, 88);
            this.btnQuestions.TabIndex = 5;
            this.btnQuestions.Text = "Edit Questions";
            this.btnQuestions.UseVisualStyleBackColor = false;
            this.btnQuestions.Click += new System.EventHandler(this.btnQuestions_Click);
            // 
            // pnlQuestionDetails
            // 
            this.pnlQuestionDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlQuestionDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.pnlQuestionDetails.Controls.Add(this.lblDifficulty);
            this.pnlQuestionDetails.Controls.Add(this.txtbDifficulty);
            this.pnlQuestionDetails.Controls.Add(this.btnSaveQuestions);
            this.pnlQuestionDetails.Controls.Add(this.label7);
            this.pnlQuestionDetails.Controls.Add(this.label6);
            this.pnlQuestionDetails.Controls.Add(this.label5);
            this.pnlQuestionDetails.Controls.Add(this.label3);
            this.pnlQuestionDetails.Controls.Add(this.label2);
            this.pnlQuestionDetails.Controls.Add(this.txtbID);
            this.pnlQuestionDetails.Controls.Add(this.txtbAswer);
            this.pnlQuestionDetails.Controls.Add(this.txtbOption1);
            this.pnlQuestionDetails.Controls.Add(this.txtboption2);
            this.pnlQuestionDetails.Controls.Add(this.txtbOption3);
            this.pnlQuestionDetails.Controls.Add(this.label1);
            this.pnlQuestionDetails.Controls.Add(this.txtbQuestion);
            this.pnlQuestionDetails.Location = new System.Drawing.Point(124, 532);
            this.pnlQuestionDetails.Name = "pnlQuestionDetails";
            this.pnlQuestionDetails.Size = new System.Drawing.Size(1389, 282);
            this.pnlQuestionDetails.TabIndex = 6;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(43, 238);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(168, 42);
            this.lblDifficulty.TabIndex = 14;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // txtbDifficulty
            // 
            this.txtbDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDifficulty.Location = new System.Drawing.Point(233, 229);
            this.txtbDifficulty.Name = "txtbDifficulty";
            this.txtbDifficulty.Size = new System.Drawing.Size(307, 47);
            this.txtbDifficulty.TabIndex = 13;
            // 
            // btnSaveQuestions
            // 
            this.btnSaveQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.btnSaveQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveQuestions.Location = new System.Drawing.Point(1239, 210);
            this.btnSaveQuestions.Name = "btnSaveQuestions";
            this.btnSaveQuestions.Size = new System.Drawing.Size(148, 51);
            this.btnSaveQuestions.TabIndex = 12;
            this.btnSaveQuestions.Text = "Save";
            this.btnSaveQuestions.UseVisualStyleBackColor = false;
            this.btnSaveQuestions.Click += new System.EventHandler(this.btnSaveQuestions_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(588, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 42);
            this.label7.TabIndex = 11;
            this.label7.Text = "Option Three";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(617, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 42);
            this.label6.TabIndex = 10;
            this.label6.Text = "Option Two";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(617, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 42);
            this.label5.TabIndex = 9;
            this.label5.Text = "Option One";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "Answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // txtbID
            // 
            this.txtbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbID.Location = new System.Drawing.Point(233, 84);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(307, 47);
            this.txtbID.TabIndex = 6;
            // 
            // txtbAswer
            // 
            this.txtbAswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAswer.Location = new System.Drawing.Point(233, 156);
            this.txtbAswer.Name = "txtbAswer";
            this.txtbAswer.Size = new System.Drawing.Size(307, 47);
            this.txtbAswer.TabIndex = 5;
            // 
            // txtbOption1
            // 
            this.txtbOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbOption1.Location = new System.Drawing.Point(847, 75);
            this.txtbOption1.Name = "txtbOption1";
            this.txtbOption1.Size = new System.Drawing.Size(307, 47);
            this.txtbOption1.TabIndex = 4;
            // 
            // txtboption2
            // 
            this.txtboption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboption2.Location = new System.Drawing.Point(847, 158);
            this.txtboption2.Name = "txtboption2";
            this.txtboption2.Size = new System.Drawing.Size(307, 47);
            this.txtboption2.TabIndex = 3;
            // 
            // txtbOption3
            // 
            this.txtbOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbOption3.Location = new System.Drawing.Point(847, 222);
            this.txtbOption3.Name = "txtbOption3";
            this.txtbOption3.Size = new System.Drawing.Size(307, 47);
            this.txtbOption3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question";
            // 
            // txtbQuestion
            // 
            this.txtbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbQuestion.Location = new System.Drawing.Point(233, 11);
            this.txtbQuestion.Name = "txtbQuestion";
            this.txtbQuestion.Size = new System.Drawing.Size(1152, 44);
            this.txtbQuestion.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(12, 323);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(259, 93);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove ";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(285, 4);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(119, 42);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "LAbel";
            this.lblMessage.Visible = false;
            // 
            // FrmAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1513, 843);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.pnlQuestionDetails);
            this.Controls.Add(this.btnQuestions);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.btnEditUsers);
            this.Controls.Add(this.pnlChangeDetails);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmincs";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllUsers)).EndInit();
            this.pnlChangeDetails.ResumeLayout(false);
            this.pnlChangeDetails.PerformLayout();
            this.pnlQuestionDetails.ResumeLayout(false);
            this.pnlQuestionDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewAllUsers;
        private System.Windows.Forms.Panel pnlChangeDetails;
        private System.Windows.Forms.TextBox txtbGender;
        private System.Windows.Forms.TextBox txtbDOB;
        private System.Windows.Forms.TextBox txtbUserType;
        private System.Windows.Forms.TextBox txtbSurname;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.TextBox txtbFirstname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Button btnEditUsers;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridView datagridQuestions;
        private System.Windows.Forms.Button btnQuestions;
        private System.Windows.Forms.Panel pnlQuestionDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.TextBox txtbAswer;
        private System.Windows.Forms.TextBox txtbOption1;
        private System.Windows.Forms.TextBox txtboption2;
        private System.Windows.Forms.TextBox txtbOption3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbQuestion;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnSaveQuestions;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.TextBox txtbDifficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionThree;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserType;
    }
}