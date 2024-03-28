
namespace AsCoursework
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.linklblSignIn = new System.Windows.Forms.LinkLabel();
            this.linklblSignUp = new System.Windows.Forms.LinkLabel();
            this.lblNeedAccount = new System.Windows.Forms.Label();
            this.lblIncorrectDetails = new System.Windows.Forms.Label();
            this.pcbEye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEye)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(517, 329);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 70);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxUsername.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUsername.Location = new System.Drawing.Point(500, 204);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(205, 45);
            this.txtboxUsername.TabIndex = 2;
            this.txtboxUsername.Text = "Username";
            this.txtboxUsername.Click += new System.EventHandler(this.txtboxUsername_Click);
            this.txtboxUsername.Leave += new System.EventHandler(this.txtboxUsername_Leave);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxPassword.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.Location = new System.Drawing.Point(500, 257);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(205, 45);
            this.txtboxPassword.TabIndex = 3;
            this.txtboxPassword.Text = "Password";
            this.txtboxPassword.Click += new System.EventHandler(this.txtboxPassword_Click);
            this.txtboxPassword.TextChanged += new System.EventHandler(this.txtboxPassword_TextChanged);
            this.txtboxPassword.Leave += new System.EventHandler(this.txtboxPassword_Leave);
            // 
            // linklblSignIn
            // 
            this.linklblSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linklblSignIn.AutoSize = true;
            this.linklblSignIn.BackColor = System.Drawing.Color.White;
            this.linklblSignIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblSignIn.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linklblSignIn.LinkColor = System.Drawing.Color.Black;
            this.linklblSignIn.Location = new System.Drawing.Point(510, 127);
            this.linklblSignIn.Name = "linklblSignIn";
            this.linklblSignIn.Size = new System.Drawing.Size(195, 64);
            this.linklblSignIn.TabIndex = 6;
            this.linklblSignIn.TabStop = true;
            this.linklblSignIn.Text = "Sign In";
            // 
            // linklblSignUp
            // 
            this.linklblSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linklblSignUp.AutoSize = true;
            this.linklblSignUp.BackColor = System.Drawing.Color.White;
            this.linklblSignUp.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.linklblSignUp.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.linklblSignUp.Location = new System.Drawing.Point(649, 398);
            this.linklblSignUp.Name = "linklblSignUp";
            this.linklblSignUp.Size = new System.Drawing.Size(73, 26);
            this.linklblSignUp.TabIndex = 7;
            this.linklblSignUp.TabStop = true;
            this.linklblSignUp.Text = "Sign Up";
            this.linklblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblSignUp_LinkClicked);
            // 
            // lblNeedAccount
            // 
            this.lblNeedAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNeedAccount.AutoSize = true;
            this.lblNeedAccount.BackColor = System.Drawing.Color.White;
            this.lblNeedAccount.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeedAccount.Location = new System.Drawing.Point(464, 398);
            this.lblNeedAccount.Name = "lblNeedAccount";
            this.lblNeedAccount.Size = new System.Drawing.Size(190, 26);
            this.lblNeedAccount.TabIndex = 8;
            this.lblNeedAccount.Text = "Don\'t have an account?";
            // 
            // lblIncorrectDetails
            // 
            this.lblIncorrectDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIncorrectDetails.AutoSize = true;
            this.lblIncorrectDetails.BackColor = System.Drawing.Color.White;
            this.lblIncorrectDetails.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectDetails.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrectDetails.Location = new System.Drawing.Point(512, 305);
            this.lblIncorrectDetails.Name = "lblIncorrectDetails";
            this.lblIncorrectDetails.Size = new System.Drawing.Size(155, 25);
            this.lblIncorrectDetails.TabIndex = 9;
            this.lblIncorrectDetails.Text = "Incorrect details";
            this.lblIncorrectDetails.Visible = false;
            // 
            // pcbEye
            // 
            this.pcbEye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbEye.BackColor = System.Drawing.Color.White;
            this.pcbEye.Image = global::AsCoursework.Properties.Resources.eye_crossed;
            this.pcbEye.Location = new System.Drawing.Point(711, 266);
            this.pcbEye.Name = "pcbEye";
            this.pcbEye.Size = new System.Drawing.Size(45, 36);
            this.pcbEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEye.TabIndex = 10;
            this.pcbEye.TabStop = false;
            this.pcbEye.Click += new System.EventHandler(this.pcbEye_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(159)))), ((int)(((byte)(194)))));
            this.BackgroundImage = global::AsCoursework.Properties.Resources.Bigger_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1163, 641);
            this.Controls.Add(this.pcbEye);
            this.Controls.Add(this.lblIncorrectDetails);
            this.Controls.Add(this.lblNeedAccount);
            this.Controls.Add(this.linklblSignUp);
            this.Controls.Add(this.linklblSignIn);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.btnLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcbEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.LinkLabel linklblSignIn;
        private System.Windows.Forms.LinkLabel linklblSignUp;
        private System.Windows.Forms.Label lblNeedAccount;
        private System.Windows.Forms.Label lblIncorrectDetails;
        private System.Windows.Forms.PictureBox pcbEye;
    }
}

