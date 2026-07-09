using Library.Business.Global;
using Library.Models;
using Library.UI;
using Library.UI.Books;
using Library.UI.Members;
using Library.UI.Categories;
using Library.UI.UserControls;
using Library.UI.Users;
using Library.UI.Borrowings;

namespace Library
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            InitializeForm();
        }

        private void InitializeForm()
        {
            lblFullName.Text = CurrentUser.FullName;

            lblRole.Text = CurrentUser.Role.ToString();

            btnUsers.Visible = CurrentUser.IsAdmin;

            btnCategories.Visible = CurrentUser.IsAdmin;

            ShowControl(new ucDashboard());
        }

        private void ShowControl(UserControl control)
        {
            pnlContent.Controls.Clear();

            control.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(control);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowControl(new ucDashboard());
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            ShowControl(new ucBooks());
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            ShowControl(new ucMembers());
        }

        private void btnBorrowings_Click(object sender, EventArgs e)
        {
            ShowControl(new ucBorrowings());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ShowControl(new ucReports());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            ShowControl(new ucCategories());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ShowControl(new ucUsers());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (!MessageHelper.Confirm("Are you sure you want to logout?"))
                return;

            CurrentUser.Logout();

            Hide();

            frmLogin login = new();

            login.ShowDialog();

            Close();
        }
    }
}