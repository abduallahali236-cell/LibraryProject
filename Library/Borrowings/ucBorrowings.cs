using Library.Business;
using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library.UI.Borrowings
{
    public partial class ucBorrowings : UserControl
    {
        private readonly BorrowingService _borrowingService = new();

        public ucBorrowings()
        {
            InitializeComponent();

            LoadBorrowings();
        }

        private void LoadBorrowings()
        {
            dgvBorrowings.DataSource =
                _borrowingService.GetAll();

            dgvBorrowings.ClearSelection();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvBorrowings.DataSource =
                _borrowingService.Search(txtSearch.Text.Trim());
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            LoadBorrowings();
        }
        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            FrmBorrowBook frm = new();

            if (frm.ShowDialog() == DialogResult.OK)
                LoadBorrowings();
        }
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (dgvBorrowings.CurrentRow == null)
                return;

            Borrowing borrowing =
                (Borrowing)dgvBorrowings.CurrentRow.DataBoundItem;

            if (borrowing.ReturnDate != null)
            {
                MessageHelper.Error(
                    "This book has already been returned.");

                return;
            }

            if (!MessageHelper.Confirm(
                "Return this book?"))
                return;


            try
            {
                _borrowingService.Return(borrowing.BorrowId);
            }
            catch(Exception ex)
            {
                MessageHelper.Error(
                    $"Error returning book: {ex.Message}");
                return;
            }

            MessageHelper.Success(
                "Book returned successfully.");

            LoadBorrowings();
        }
    }
}