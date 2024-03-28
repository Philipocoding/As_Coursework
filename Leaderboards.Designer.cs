
namespace AsCoursework
{
    partial class Leaderboards
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGuessFlag = new System.Windows.Forms.Button();
            this.pnlQuizChoice = new System.Windows.Forms.Panel();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnTrueFalse = new System.Windows.Forms.Button();
            this.btnMultiChoice = new System.Windows.Forms.Button();
            this.btnCapitals = new System.Windows.Forms.Button();
            this.pnlDifficulty = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnExpert = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.dataGridLeaderboard = new System.Windows.Forms.DataGridView();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HighScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewAnotherLeaderboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlQuizChoice.SuspendLayout();
            this.pnlDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeaderboard)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuessFlag
            // 
            this.btnGuessFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.btnGuessFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuessFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuessFlag.Location = new System.Drawing.Point(271, 27);
            this.btnGuessFlag.Name = "btnGuessFlag";
            this.btnGuessFlag.Size = new System.Drawing.Size(279, 114);
            this.btnGuessFlag.TabIndex = 0;
            this.btnGuessFlag.Text = "Guess The Flag";
            this.btnGuessFlag.UseVisualStyleBackColor = false;
            this.btnGuessFlag.Click += new System.EventHandler(this.btnGuessFlag_Click);
            // 
            // pnlQuizChoice
            // 
            this.pnlQuizChoice.Controls.Add(this.btnMatch);
            this.pnlQuizChoice.Controls.Add(this.btnGuessFlag);
            this.pnlQuizChoice.Controls.Add(this.btnTrueFalse);
            this.pnlQuizChoice.Controls.Add(this.btnMultiChoice);
            this.pnlQuizChoice.Controls.Add(this.btnCapitals);
            this.pnlQuizChoice.Location = new System.Drawing.Point(46, 0);
            this.pnlQuizChoice.Name = "pnlQuizChoice";
            this.pnlQuizChoice.Size = new System.Drawing.Size(867, 662);
            this.pnlQuizChoice.TabIndex = 1;
            // 
            // btnMatch
            // 
            this.btnMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.btnMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatch.Location = new System.Drawing.Point(271, 507);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(279, 114);
            this.btnMatch.TabIndex = 3;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = false;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnTrueFalse
            // 
            this.btnTrueFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.btnTrueFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrueFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrueFalse.Location = new System.Drawing.Point(271, 387);
            this.btnTrueFalse.Name = "btnTrueFalse";
            this.btnTrueFalse.Size = new System.Drawing.Size(279, 114);
            this.btnTrueFalse.TabIndex = 2;
            this.btnTrueFalse.Text = "True/False";
            this.btnTrueFalse.UseVisualStyleBackColor = false;
            this.btnTrueFalse.Click += new System.EventHandler(this.btnTrueFalse_Click);
            // 
            // btnMultiChoice
            // 
            this.btnMultiChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.btnMultiChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiChoice.Location = new System.Drawing.Point(271, 267);
            this.btnMultiChoice.Name = "btnMultiChoice";
            this.btnMultiChoice.Size = new System.Drawing.Size(279, 114);
            this.btnMultiChoice.TabIndex = 1;
            this.btnMultiChoice.Text = "Multiple Choice";
            this.btnMultiChoice.UseVisualStyleBackColor = false;
            this.btnMultiChoice.Click += new System.EventHandler(this.btnMultiChoice_Click);
            // 
            // btnCapitals
            // 
            this.btnCapitals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.btnCapitals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapitals.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapitals.Location = new System.Drawing.Point(271, 147);
            this.btnCapitals.Name = "btnCapitals";
            this.btnCapitals.Size = new System.Drawing.Size(279, 114);
            this.btnCapitals.TabIndex = 0;
            this.btnCapitals.Text = "Capitals";
            this.btnCapitals.UseVisualStyleBackColor = false;
            this.btnCapitals.Click += new System.EventHandler(this.btnCapitals_Click);
            // 
            // pnlDifficulty
            // 
            this.pnlDifficulty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDifficulty.Controls.Add(this.pnlQuizChoice);
            this.pnlDifficulty.Controls.Add(this.lbltitle);
            this.pnlDifficulty.Controls.Add(this.btnExpert);
            this.pnlDifficulty.Controls.Add(this.btnHard);
            this.pnlDifficulty.Controls.Add(this.btnMedium);
            this.pnlDifficulty.Controls.Add(this.btnEasy);
            this.pnlDifficulty.Location = new System.Drawing.Point(108, 12);
            this.pnlDifficulty.Name = "pnlDifficulty";
            this.pnlDifficulty.Size = new System.Drawing.Size(1001, 725);
            this.pnlDifficulty.TabIndex = 5;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(60, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(871, 146);
            this.lbltitle.TabIndex = 4;
            this.lbltitle.Text = "Select which Guess the Flag\r\n        difficulty to filter by:";
            this.lbltitle.Visible = false;
            // 
            // btnExpert
            // 
            this.btnExpert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.btnExpert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpert.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpert.Location = new System.Drawing.Point(335, 524);
            this.btnExpert.Name = "btnExpert";
            this.btnExpert.Size = new System.Drawing.Size(230, 99);
            this.btnExpert.TabIndex = 3;
            this.btnExpert.Text = "Expert";
            this.btnExpert.UseVisualStyleBackColor = false;
            this.btnExpert.Click += new System.EventHandler(this.btnExpert_Click);
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(335, 404);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(230, 99);
            this.btnHard.TabIndex = 2;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.Location = new System.Drawing.Point(335, 287);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(230, 99);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.Location = new System.Drawing.Point(335, 161);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(230, 99);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // dataGridLeaderboard
            // 
            this.dataGridLeaderboard.AllowUserToAddRows = false;
            this.dataGridLeaderboard.AllowUserToDeleteRows = false;
            this.dataGridLeaderboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridLeaderboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.dataGridLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLeaderboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLeaderboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Firstname,
            this.Username,
            this.Surname,
            this.HighScore});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridLeaderboard.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridLeaderboard.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.dataGridLeaderboard.Location = new System.Drawing.Point(61, 14);
            this.dataGridLeaderboard.Name = "dataGridLeaderboard";
            this.dataGridLeaderboard.ReadOnly = true;
            this.dataGridLeaderboard.RowHeadersWidth = 20;
            this.dataGridLeaderboard.Size = new System.Drawing.Size(864, 589);
            this.dataGridLeaderboard.TabIndex = 4;
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.MinimumWidth = 200;
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            this.Firstname.Width = 210;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 210;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Width = 210;
            // 
            // HighScore
            // 
            this.HighScore.HeaderText = "HighScore";
            this.HighScore.Name = "HighScore";
            this.HighScore.ReadOnly = true;
            this.HighScore.Width = 210;
            // 
            // btnViewAnotherLeaderboard
            // 
            this.btnViewAnotherLeaderboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewAnotherLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.btnViewAnotherLeaderboard.FlatAppearance.BorderSize = 0;
            this.btnViewAnotherLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAnotherLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAnotherLeaderboard.Location = new System.Drawing.Point(256, 599);
            this.btnViewAnotherLeaderboard.Name = "btnViewAnotherLeaderboard";
            this.btnViewAnotherLeaderboard.Size = new System.Drawing.Size(530, 90);
            this.btnViewAnotherLeaderboard.TabIndex = 6;
            this.btnViewAnotherLeaderboard.Text = "View another leaderboard";
            this.btnViewAnotherLeaderboard.UseVisualStyleBackColor = false;
            this.btnViewAnotherLeaderboard.Click += new System.EventHandler(this.btnViewAnotherLeaderboard_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnViewAnotherLeaderboard);
            this.panel1.Controls.Add(this.dataGridLeaderboard);
            this.panel1.Location = new System.Drawing.Point(93, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 713);
            this.panel1.TabIndex = 7;
            // 
            // Leaderboards
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1222, 737);
            this.Controls.Add(this.pnlDifficulty);
            this.Controls.Add(this.panel1);
            this.Name = "Leaderboards";
            this.Text = "Leaderboards";
            this.Load += new System.EventHandler(this.Leaderboards_Load);
            this.pnlQuizChoice.ResumeLayout(false);
            this.pnlDifficulty.ResumeLayout(false);
            this.pnlDifficulty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeaderboard)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuessFlag;
        private System.Windows.Forms.Panel pnlQuizChoice;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnTrueFalse;
        private System.Windows.Forms.Button btnMultiChoice;
        private System.Windows.Forms.Button btnCapitals;
        private System.Windows.Forms.Panel pnlDifficulty;
        private System.Windows.Forms.DataGridView dataGridLeaderboard;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnExpert;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn HighScore;
        private System.Windows.Forms.Button btnViewAnotherLeaderboard;
        private System.Windows.Forms.Panel panel1;
    }
}