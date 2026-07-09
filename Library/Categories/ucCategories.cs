using Library.Business;
using Library.Business.Global;
using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Library.UI;
using System;
using System.Windows.Forms;

namespace Library.UI.Categories

{

    public partial class ucCategories : UserControl
    {
        private readonly CategoryService _categoryService = new();

        public ucCategories()
        {
            InitializeComponent();

            ApplyPermissions();

            LoadCategories();
        }


        private void ApplyPermissions()
        {
            bool isAdmin = CurrentUser.IsAdmin;

            btnAdd.Visible = isAdmin;
            btnEdit.Visible = isAdmin;
            btnDelete.Visible = isAdmin;
        }
        private void LoadCategories()
        {
            dgvCategories.DataSource = _categoryService.GetAll();

            dgvCategories.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadCategories();
                return;
            }

            dgvCategories.DataSource = _categoryService
                .GetAll()
                .Where(c => c.CategoryName.Contains(keyword,
                    StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            LoadCategories();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCategoryDetails frm = new();

            if (frm.ShowDialog() == DialogResult.OK)
                LoadCategories();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null)
                return;

            Category category =
                (Category)dgvCategories.CurrentRow.DataBoundItem;

            FrmCategoryDetails frm = new(category);

            if (frm.ShowDialog() == DialogResult.OK)
                LoadCategories();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null)
                return;

            Category category =
                (Category)dgvCategories.CurrentRow.DataBoundItem;

            if (!MessageHelper.Confirm(
                $"Delete '{category.CategoryName}' ?"))
                return;
            try
            {
                _categoryService.Delete(category.CategoryId);
            }
            catch(Exception ex)
            {
                MessageHelper.Error($"Error deleting category: {ex.Message}");
                return;
            }

            MessageHelper.Success(
                "Category deleted successfully.");

            LoadCategories();
        }
    }
}