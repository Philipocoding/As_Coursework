
namespace AsCoursework
{
    partial class GuessTheFlag
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbFlag = new System.Windows.Forms.PictureBox();
            this.txtbAnswer = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFlag)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pcbFlag);
            this.panel1.Location = new System.Drawing.Point(176, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 331);
            this.panel1.TabIndex = 0;
            // 
            // pcbFlag
            // 
            this.pcbFlag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbFlag.Location = new System.Drawing.Point(34, 3);
            this.pcbFlag.Name = "pcbFlag";
            this.pcbFlag.Size = new System.Drawing.Size(582, 310);
            this.pcbFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbFlag.TabIndex = 0;
            this.pcbFlag.TabStop = false;
            // 
            // txtbAnswer
            // 
            this.txtbAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAnswer.Location = new System.Drawing.Point(292, 482);
            this.txtbAnswer.Name = "txtbAnswer";
            this.txtbAnswer.Size = new System.Drawing.Size(400, 47);
            this.txtbAnswer.TabIndex = 1;
            this.txtbAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbAnswer_KeyDown);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(571, 12);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(181, 85);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "label1";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtbAnswer);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblTimer);
            this.panel2.Location = new System.Drawing.Point(111, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 602);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time Remaining:";
            // 
            // GuessTheFlag
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1313, 731);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GuessTheFlag";
            this.Text = "GuessTheFlag";
            this.Load += new System.EventHandler(this.GuessTheFlag_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFlag)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbFlag;
        private System.Windows.Forms.TextBox txtbAnswer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}