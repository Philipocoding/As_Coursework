
namespace AsCoursework
{
    partial class QuizSummary
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
            this.btnLeaderboards = new System.Windows.Forms.Button();
            this.BtnTakeNewQuiz = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblNewHighScore = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlQuizOptions = new System.Windows.Forms.Panel();
            this.btnMultipleCHoice = new System.Windows.Forms.Button();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnCapitalsQuiz = new System.Windows.Forms.Button();
            this.btnGuessFlag = new System.Windows.Forms.Button();
            this.btnTrueFalse = new System.Windows.Forms.Button();
            this.pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlQuizOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLeaderboards
            // 
            this.btnLeaderboards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.btnLeaderboards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaderboards.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderboards.Location = new System.Drawing.Point(222, 365);
            this.btnLeaderboards.Name = "btnLeaderboards";
            this.btnLeaderboards.Size = new System.Drawing.Size(268, 110);
            this.btnLeaderboards.TabIndex = 0;
            this.btnLeaderboards.Text = "View Leaderboards";
            this.btnLeaderboards.UseVisualStyleBackColor = false;
            this.btnLeaderboards.Click += new System.EventHandler(this.btnLeaderboards_Click);
            // 
            // BtnTakeNewQuiz
            // 
            this.BtnTakeNewQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.BtnTakeNewQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTakeNewQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTakeNewQuiz.Location = new System.Drawing.Point(222, 222);
            this.BtnTakeNewQuiz.Name = "BtnTakeNewQuiz";
            this.BtnTakeNewQuiz.Size = new System.Drawing.Size(268, 115);
            this.BtnTakeNewQuiz.TabIndex = 1;
            this.BtnTakeNewQuiz.Text = "Take a New Quiz";
            this.BtnTakeNewQuiz.UseVisualStyleBackColor = false;
            this.BtnTakeNewQuiz.Click += new System.EventHandler(this.BtnTakeNewQuiz_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(290, 93);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(161, 42);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "lblScore";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(287, 33);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(117, 48);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Score";
            // 
            // pnlSummary
            // 
            this.pnlSummary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.pnlSummary.Controls.Add(this.lblNewHighScore);
            this.pnlSummary.Controls.Add(this.BtnTakeNewQuiz);
            this.pnlSummary.Controls.Add(this.btnLeaderboards);
            this.pnlSummary.Controls.Add(this.lblScore);
            this.pnlSummary.Controls.Add(this.lbl);
            this.pnlSummary.Location = new System.Drawing.Point(131, 150);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(835, 551);
            this.pnlSummary.TabIndex = 9;
            // 
            // lblNewHighScore
            // 
            this.lblNewHighScore.AutoSize = true;
            this.lblNewHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewHighScore.ForeColor = System.Drawing.Color.Red;
            this.lblNewHighScore.Location = new System.Drawing.Point(23, 143);
            this.lblNewHighScore.Name = "lblNewHighScore";
            this.lblNewHighScore.Size = new System.Drawing.Size(106, 37);
            this.lblNewHighScore.TabIndex = 10;
            this.lblNewHighScore.Text = "label1";
            this.lblNewHighScore.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::AsCoursework.Properties.Resources.chart_histogram;
            this.pictureBox2.Location = new System.Drawing.Point(831, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::AsCoursework.Properties.Resources.chart_histogram;
            this.pictureBox1.Location = new System.Drawing.Point(104, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(196, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(625, 73);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Your Quiz Summary";
            // 
            // pnlQuizOptions
            // 
            this.pnlQuizOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlQuizOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.pnlQuizOptions.Controls.Add(this.btnMultipleCHoice);
            this.pnlQuizOptions.Controls.Add(this.btnMatch);
            this.pnlQuizOptions.Controls.Add(this.btnCapitalsQuiz);
            this.pnlQuizOptions.Controls.Add(this.btnGuessFlag);
            this.pnlQuizOptions.Controls.Add(this.btnTrueFalse);
            this.pnlQuizOptions.Location = new System.Drawing.Point(188, 336);
            this.pnlQuizOptions.Name = "pnlQuizOptions";
            this.pnlQuizOptions.Size = new System.Drawing.Size(736, 311);
            this.pnlQuizOptions.TabIndex = 5;
            this.pnlQuizOptions.Visible = false;
            // 
            // btnMultipleCHoice
            // 
            this.btnMultipleCHoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.btnMultipleCHoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultipleCHoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultipleCHoice.Location = new System.Drawing.Point(148, 177);
            this.btnMultipleCHoice.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultipleCHoice.Name = "btnMultipleCHoice";
            this.btnMultipleCHoice.Size = new System.Drawing.Size(210, 90);
            this.btnMultipleCHoice.TabIndex = 7;
            this.btnMultipleCHoice.Text = "Multiple Choice";
            this.btnMultipleCHoice.UseVisualStyleBackColor = false;
            this.btnMultipleCHoice.Click += new System.EventHandler(this.btnMultipleCHoice_Click);
            // 
            // btnMatch
            // 
            this.btnMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.btnMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatch.Location = new System.Drawing.Point(379, 177);
            this.btnMatch.Margin = new System.Windows.Forms.Padding(0);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(210, 90);
            this.btnMatch.TabIndex = 6;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = false;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnCapitalsQuiz
            // 
            this.btnCapitalsQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.btnCapitalsQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapitalsQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapitalsQuiz.Location = new System.Drawing.Point(264, 71);
            this.btnCapitalsQuiz.Margin = new System.Windows.Forms.Padding(0);
            this.btnCapitalsQuiz.Name = "btnCapitalsQuiz";
            this.btnCapitalsQuiz.Size = new System.Drawing.Size(210, 90);
            this.btnCapitalsQuiz.TabIndex = 5;
            this.btnCapitalsQuiz.Text = "Capitals";
            this.btnCapitalsQuiz.UseVisualStyleBackColor = false;
            this.btnCapitalsQuiz.Click += new System.EventHandler(this.btnCapitalsQuiz_Click);
            // 
            // btnGuessFlag
            // 
            this.btnGuessFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.btnGuessFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuessFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuessFlag.Location = new System.Drawing.Point(494, 71);
            this.btnGuessFlag.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuessFlag.Name = "btnGuessFlag";
            this.btnGuessFlag.Size = new System.Drawing.Size(210, 90);
            this.btnGuessFlag.TabIndex = 4;
            this.btnGuessFlag.Text = "Guess The Flag";
            this.btnGuessFlag.UseVisualStyleBackColor = false;
            this.btnGuessFlag.Click += new System.EventHandler(this.btnGuessFlag_Click);
            // 
            // btnTrueFalse
            // 
            this.btnTrueFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.btnTrueFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrueFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrueFalse.Location = new System.Drawing.Point(33, 71);
            this.btnTrueFalse.Margin = new System.Windows.Forms.Padding(0);
            this.btnTrueFalse.Name = "btnTrueFalse";
            this.btnTrueFalse.Size = new System.Drawing.Size(210, 90);
            this.btnTrueFalse.TabIndex = 3;
            this.btnTrueFalse.Text = "True or False";
            this.btnTrueFalse.UseVisualStyleBackColor = false;
            this.btnTrueFalse.Click += new System.EventHandler(this.btnTrueFalse_Click);
            // 
            // QuizSummary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1040, 725);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlQuizOptions);
            this.Controls.Add(this.lblTitle);
            this.Name = "QuizSummary";
            this.Text = "QuizSummary";
            this.Load += new System.EventHandler(this.QuizSummary_Load);
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlQuizOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeaderboards;
        private System.Windows.Forms.Button BtnTakeNewQuiz;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel pnlQuizOptions;
        private System.Windows.Forms.Button btnMultipleCHoice;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnCapitalsQuiz;
        private System.Windows.Forms.Button btnGuessFlag;
        private System.Windows.Forms.Button btnTrueFalse;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblNewHighScore;
    }
}