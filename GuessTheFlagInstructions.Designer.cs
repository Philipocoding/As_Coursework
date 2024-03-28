
namespace AsCoursework
{
    partial class GuessTheFlagInstructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuessTheFlagInstructions));
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnExpert = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlExpertSelect = new System.Windows.Forms.Panel();
            this.pnlMediumSelect = new System.Windows.Forms.Panel();
            this.pnlEasySelect = new System.Windows.Forms.Panel();
            this.pnlHardSelect = new System.Windows.Forms.Panel();
            this.pnlSelectDifficulty = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblAmountofTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumQuestions = new System.Windows.Forms.Label();
            this.pnlSelectDifficulty.SuspendLayout();
            this.pnlInstructions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess The Flag Instructions";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(372, 379);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(230, 90);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.Location = new System.Drawing.Point(111, 121);
            this.btnEasy.Margin = new System.Windows.Forms.Padding(0);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(184, 68);
            this.btnEasy.TabIndex = 8;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.Location = new System.Drawing.Point(300, 121);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(182, 68);
            this.btnMedium.TabIndex = 9;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.Chocolate;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(488, 122);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(181, 68);
            this.btnHard.TabIndex = 10;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnExpert
            // 
            this.btnExpert.BackColor = System.Drawing.Color.Red;
            this.btnExpert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpert.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpert.Location = new System.Drawing.Point(675, 122);
            this.btnExpert.Name = "btnExpert";
            this.btnExpert.Size = new System.Drawing.Size(181, 68);
            this.btnExpert.TabIndex = 11;
            this.btnExpert.Text = "Expert";
            this.btnExpert.UseVisualStyleBackColor = false;
            this.btnExpert.Click += new System.EventHandler(this.btnExpert_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(387, 472);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(194, 25);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "Select a difficulty";
            this.lblError.Visible = false;
            // 
            // pnlExpertSelect
            // 
            this.pnlExpertSelect.BackColor = System.Drawing.Color.Silver;
            this.pnlExpertSelect.Location = new System.Drawing.Point(675, 192);
            this.pnlExpertSelect.Name = "pnlExpertSelect";
            this.pnlExpertSelect.Size = new System.Drawing.Size(182, 5);
            this.pnlExpertSelect.TabIndex = 14;
            this.pnlExpertSelect.Visible = false;
            // 
            // pnlMediumSelect
            // 
            this.pnlMediumSelect.BackColor = System.Drawing.Color.Silver;
            this.pnlMediumSelect.Location = new System.Drawing.Point(300, 191);
            this.pnlMediumSelect.Name = "pnlMediumSelect";
            this.pnlMediumSelect.Size = new System.Drawing.Size(182, 5);
            this.pnlMediumSelect.TabIndex = 15;
            this.pnlMediumSelect.Visible = false;
            // 
            // pnlEasySelect
            // 
            this.pnlEasySelect.BackColor = System.Drawing.Color.Silver;
            this.pnlEasySelect.Location = new System.Drawing.Point(111, 191);
            this.pnlEasySelect.Name = "pnlEasySelect";
            this.pnlEasySelect.Size = new System.Drawing.Size(182, 5);
            this.pnlEasySelect.TabIndex = 15;
            this.pnlEasySelect.Visible = false;
            // 
            // pnlHardSelect
            // 
            this.pnlHardSelect.BackColor = System.Drawing.Color.Silver;
            this.pnlHardSelect.Location = new System.Drawing.Point(488, 193);
            this.pnlHardSelect.Name = "pnlHardSelect";
            this.pnlHardSelect.Size = new System.Drawing.Size(181, 5);
            this.pnlHardSelect.TabIndex = 15;
            this.pnlHardSelect.Visible = false;
            // 
            // pnlSelectDifficulty
            // 
            this.pnlSelectDifficulty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSelectDifficulty.Controls.Add(this.lblNumQuestions);
            this.pnlSelectDifficulty.Controls.Add(this.label3);
            this.pnlSelectDifficulty.Controls.Add(this.lblAmountofTime);
            this.pnlSelectDifficulty.Controls.Add(this.label2);
            this.pnlSelectDifficulty.Controls.Add(this.label6);
            this.pnlSelectDifficulty.Controls.Add(this.lblError);
            this.pnlSelectDifficulty.Controls.Add(this.pnlEasySelect);
            this.pnlSelectDifficulty.Controls.Add(this.btnStart);
            this.pnlSelectDifficulty.Controls.Add(this.pnlMediumSelect);
            this.pnlSelectDifficulty.Controls.Add(this.pnlHardSelect);
            this.pnlSelectDifficulty.Controls.Add(this.btnEasy);
            this.pnlSelectDifficulty.Controls.Add(this.btnMedium);
            this.pnlSelectDifficulty.Controls.Add(this.btnHard);
            this.pnlSelectDifficulty.Controls.Add(this.pnlExpertSelect);
            this.pnlSelectDifficulty.Controls.Add(this.btnExpert);
            this.pnlSelectDifficulty.Location = new System.Drawing.Point(12, 32);
            this.pnlSelectDifficulty.Name = "pnlSelectDifficulty";
            this.pnlSelectDifficulty.Size = new System.Drawing.Size(932, 565);
            this.pnlSelectDifficulty.TabIndex = 16;
            this.pnlSelectDifficulty.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 42);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total time provided (seconds):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(422, 55);
            this.label6.TabIndex = 16;
            this.label6.Text = "Select a Difficulty!";
            // 
            // pnlInstructions
            // 
            this.pnlInstructions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlInstructions.Controls.Add(this.btnOK);
            this.pnlInstructions.Controls.Add(this.label7);
            this.pnlInstructions.Controls.Add(this.label1);
            this.pnlInstructions.Location = new System.Drawing.Point(38, 2);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(1056, 764);
            this.pnlInstructions.TabIndex = 16;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOK.Location = new System.Drawing.Point(369, 490);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(272, 95);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "Ok!";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1032, 234);
            this.label7.TabIndex = 8;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // lblAmountofTime
            // 
            this.lblAmountofTime.AutoSize = true;
            this.lblAmountofTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountofTime.Location = new System.Drawing.Point(691, 246);
            this.lblAmountofTime.Name = "lblAmountofTime";
            this.lblAmountofTime.Size = new System.Drawing.Size(40, 42);
            this.lblAmountofTime.TabIndex = 17;
            this.lblAmountofTime.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 42);
            this.label3.TabIndex = 21;
            this.label3.Text = "Number of Questions:";
            // 
            // lblNumQuestions
            // 
            this.lblNumQuestions.AutoSize = true;
            this.lblNumQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumQuestions.Location = new System.Drawing.Point(695, 298);
            this.lblNumQuestions.Name = "lblNumQuestions";
            this.lblNumQuestions.Size = new System.Drawing.Size(40, 42);
            this.lblNumQuestions.TabIndex = 22;
            this.lblNumQuestions.Text = "0";
            // 
            // GuessTheFlagInstructions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1162, 687);
            this.Controls.Add(this.pnlInstructions);
            this.Controls.Add(this.pnlSelectDifficulty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GuessTheFlagInstructions";
            this.Text = "GuessTheFlagInstructions";
            this.Load += new System.EventHandler(this.GuessTheFlagInstructions_Load);
            this.pnlSelectDifficulty.ResumeLayout(false);
            this.pnlSelectDifficulty.PerformLayout();
            this.pnlInstructions.ResumeLayout(false);
            this.pnlInstructions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnExpert;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlExpertSelect;
        private System.Windows.Forms.Panel pnlMediumSelect;
        private System.Windows.Forms.Panel pnlEasySelect;
        private System.Windows.Forms.Panel pnlHardSelect;
        private System.Windows.Forms.Panel pnlSelectDifficulty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAmountofTime;
        private System.Windows.Forms.Label lblNumQuestions;
        private System.Windows.Forms.Label label3;
    }
}