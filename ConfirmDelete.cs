using System;
using System.Windows.Forms;

namespace AsCoursework
{
    public partial class ConfirmDelete : Form
    {
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            activeForm = childForm;

            //setup form display settings
            activeForm.TopLevel = false;
            activeForm.Location = new System.Drawing.Point(0, 0);
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Enabled = true;
            activeForm.Visible = true;
            activeForm.Dock = DockStyle.Fill;

            //display in panel
            pnlChildForm.Controls.Clear();
            pnlChildForm.Controls.Add(activeForm);
            pnlChildForm.Show();

        }
        public ConfirmDelete()
        {
            InitializeComponent();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            User.DeleteUser();
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((MainMenu)ActiveForm).LoadChildForm(new pcbSpecialChar());
        }
    }
}
