
namespace AsCoursework
{
    partial class MultipleChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultipleChoice));
            this.btnAnsOne = new System.Windows.Forms.Button();
            this.btnAnsTwo = new System.Windows.Forms.Button();
            this.btnAnsThree = new System.Windows.Forms.Button();
            this.btnAnsFour = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNumberofQuestions = new System.Windows.Forms.Label();
            this.lblTimeProvided = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.llblTimeRemaining = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlInstructions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnsOne
            // 
            this.btnAnsOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.btnAnsOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnsOne.Location = new System.Drawing.Point(104, 3);
            this.btnAnsOne.Name = "btnAnsOne";
            this.btnAnsOne.Size = new System.Drawing.Size(519, 215);
            this.btnAnsOne.TabIndex = 0;
            this.btnAnsOne.Text = "button1";
            this.btnAnsOne.UseVisualStyleBackColor = false;
            this.btnAnsOne.Click += new System.EventHandler(this.btnAnsOne_Click);
            // 
            // btnAnsTwo
            // 
            this.btnAnsTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.btnAnsTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnsTwo.Location = new System.Drawing.Point(104, 222);
            this.btnAnsTwo.Name = "btnAnsTwo";
            this.btnAnsTwo.Size = new System.Drawing.Size(519, 225);
            this.btnAnsTwo.TabIndex = 1;
            this.btnAnsTwo.Text = "button2";
            this.btnAnsTwo.UseVisualStyleBackColor = false;
            this.btnAnsTwo.Click += new System.EventHandler(this.btnAnsTwo_Click);
            // 
            // btnAnsThree
            // 
            this.btnAnsThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.btnAnsThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnsThree.Location = new System.Drawing.Point(629, 3);
            this.btnAnsThree.Name = "btnAnsThree";
            this.btnAnsThree.Size = new System.Drawing.Size(527, 215);
            this.btnAnsThree.TabIndex = 2;
            this.btnAnsThree.Text = "button3";
            this.btnAnsThree.UseVisualStyleBackColor = false;
            this.btnAnsThree.Click += new System.EventHandler(this.btnAnsThree_Click);
            // 
            // btnAnsFour
            // 
            this.btnAnsFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.btnAnsFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnsFour.Location = new System.Drawing.Point(629, 224);
            this.btnAnsFour.Name = "btnAnsFour";
            this.btnAnsFour.Size = new System.Drawing.Size(527, 225);
            this.btnAnsFour.TabIndex = 3;
            this.btnAnsFour.Text = "button4";
            this.btnAnsFour.UseVisualStyleBackColor = false;
            this.btnAnsFour.Click += new System.EventHandler(this.btnAnsFour_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnAnsOne);
            this.panel1.Controls.Add(this.btnAnsFour);
            this.panel1.Controls.Add(this.btnAnsTwo);
            this.panel1.Controls.Add(this.btnAnsThree);
            this.panel1.Location = new System.Drawing.Point(48, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 457);
            this.panel1.TabIndex = 4;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(169, 220);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(124, 42);
            this.lblQuestion.TabIndex = 6;
            this.lblQuestion.Text = "label2";
            // 
            // pnlInstructions
            // 
            this.pnlInstructions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlInstructions.Controls.Add(this.panel2);
            this.pnlInstructions.Controls.Add(this.label2);
            this.pnlInstructions.Controls.Add(this.btnStart);
            this.pnlInstructions.Location = new System.Drawing.Point(-6, -80);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(1895, 939);
            this.pnlInstructions.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblNumberofQuestions);
            this.panel2.Controls.Add(this.lblTimeProvided);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(86, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 399);
            this.panel2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(404, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(278, 42);
            this.label8.TabIndex = 7;
            this.label8.Text = "Time provided:";
            // 
            // lblNumberofQuestions
            // 
            this.lblNumberofQuestions.AutoSize = true;
            this.lblNumberofQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberofQuestions.Location = new System.Drawing.Point(676, 282);
            this.lblNumberofQuestions.Name = "lblNumberofQuestions";
            this.lblNumberofQuestions.Size = new System.Drawing.Size(40, 42);
            this.lblNumberofQuestions.TabIndex = 6;
            this.lblNumberofQuestions.Text = "0";
            // 
            // lblTimeProvided
            // 
            this.lblTimeProvided.AutoSize = true;
            this.lblTimeProvided.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeProvided.Location = new System.Drawing.Point(676, 333);
            this.lblTimeProvided.Name = "lblTimeProvided";
            this.lblTimeProvided.Size = new System.Drawing.Size(40, 42);
            this.lblTimeProvided.TabIndex = 5;
            this.lblTimeProvided.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of Questions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1101, 234);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(637, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Multiple Choice Instructions";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(497, 673);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(221, 80);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 42);
            this.label5.TabIndex = 8;
            this.label5.Text = "Q)";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(373, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 42);
            this.label6.TabIndex = 4;
            this.label6.Text = "Time remaining:";
            // 
            // llblTimeRemaining
            // 
            this.llblTimeRemaining.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.llblTimeRemaining.AutoSize = true;
            this.llblTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblTimeRemaining.Location = new System.Drawing.Point(660, 174);
            this.llblTimeRemaining.Name = "llblTimeRemaining";
            this.llblTimeRemaining.Size = new System.Drawing.Size(40, 42);
            this.llblTimeRemaining.TabIndex = 9;
            this.llblTimeRemaining.Text = "0";
            // 
            // MultipleChoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1335, 737);
            this.Controls.Add(this.pnlInstructions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.llblTimeRemaining);
            this.Controls.Add(this.label6);
            this.Name = "MultipleChoice";
            this.Text = "MultipleChoice";
            this.Load += new System.EventHandler(this.MultipleChoice_Load);
            this.panel1.ResumeLayout(false);
            this.pnlInstructions.ResumeLayout(false);
            this.pnlInstructions.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnsOne;
        private System.Windows.Forms.Button btnAnsTwo;
        private System.Windows.Forms.Button btnAnsThree;
        private System.Windows.Forms.Button btnAnsFour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNumberofQuestions;
        private System.Windows.Forms.Label lblTimeProvided;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label llblTimeRemaining;
    }
}