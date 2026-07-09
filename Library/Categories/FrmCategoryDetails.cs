using Library.Business;
using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library.UI.Categories
{

    
    public partial class FrmCategoryDetails : Form
    {
        private readonly CategoryService _categoryService = new();

        private readonly bool _isEdit;

        private Category _category;
        
        public FrmCategoryDetails()
        {
            InitializeComponent();

            _category = new Category();

            Text = "Add Category";
        }
        public FrmCategoryDetails(Category category)
        {
            InitializeComponent();

            _category = category;

            _isEdit = true;

            FillControls();

            Text = "Edit Category";
        }
        private void FillControls()
        {
            txtCategoryName.Text = _category.CategoryName;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _category.CategoryName =
                txtCategoryName.Text.Trim();
            try
            {
                if (_isEdit)
                    _categoryService.Update(_category);
                else
                    _categoryService.Add(_category);
            }
            catch(Exception ex)
            {
                MessageHelper.Error("An error occurred while saving the category: " + ex.Message);
            }


            DialogResult = DialogResult.OK;

            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCategoryName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                errorProvider1.SetError(txtCategoryName, "Category name is required.");
                btnSave.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(txtCategoryName, string.Empty);
                btnSave.Enabled = true;
            }


        }

        
    }
}

