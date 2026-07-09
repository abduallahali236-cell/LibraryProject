using Library.Business;
using Library.Business.Global;
using Library.Models;
using System;
using System.Windows.Forms;

namespace Library.UI

{
    public partial class ucDashboard : UserControl
    {
        private readonly DashboardService _dashboardService;

        public ucDashboard()
        {
            InitializeComponent();

            _dashboardService = new DashboardService();

            LoadDashboard();
        }

        private void LoadDashboard()
        {
            lblWelcome.Text = $"Welcome, {CurrentUser.FullName}";
            lblDate.Text = $"Date : {DateTime.Now.ToLongDateString()}";

            DashboardStats stats = _dashboardService.GetStatistics();

            lblTotalBooks.Text = stats.TotalBooks.ToString();

            lblMembers.Text = stats.TotalMembers.ToString();

            lblBorrowed.Text = stats.BorrowedBooks.ToString();

            lblOverdue.Text = stats.OverdueBooks.ToString();
        }
    }
}