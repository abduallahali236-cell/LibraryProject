using Library.Business;
using Library.Models;
using System;
using System.Windows.Forms;

namespace Library.UI.Books
{
    public partial class FrmBookDetails : Form
    {
        private readonly BookService _bookService = new();

        private readonly CategoryService _categoryService = new();

        private readonly bool _isEdit;

        private Book _book;

        public FrmBookDetails()
        {
            InitializeComponent();

            _book = new Book();

            LoadCategories();

            Text = "Add Book";

            btnSave.Enabled = false;
        }

        public FrmBookDetails(Book book)
        {
            InitializeComponent();

            _book = book;

            _isEdit = true;

            LoadCategories();

            FillControls();

            Text = "Edit Book";
        }

        private void FillControls()
        {
            txtTitle.Text = _book.Title;

            txtAuthor.Text = _book.Author;

            txtISBN.Text = _book.ISBN;

            nudPublishYear.Value = _book.PublishYear;

            nudCopies.Value = _book.Copies;
            nudCopies.Enabled = false;

        }

        private void LoadCategories()
        {
            cmbCategory.DataSource = _categoryService.GetAll();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
              
            cmbCategory.SelectedValue = _book.CategoryId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

                _book.Title = txtTitle.Text.Trim();

                _book.Author = txtAuthor.Text.Trim();

                _book.ISBN = txtISBN.Text.Trim();

                _book.PublishYear = (int)nudPublishYear.Value;

            
                if (cmbCategory.SelectedValue == null)
                     cmbCategory.SelectedIndex = 0;

                else 
                   {
                           _book.CategoryId =
                   (int)cmbCategory.SelectedValue;
                    }


                _book.Copies =
                    (int)nudCopies.Value;

                try
                {
                    if (_isEdit)
                        _bookService.Update(_book);
                    else
                        _bookService.Add(_book);
                }
                catch (Exception ex)
                {
                    MessageHelper.Error("An error occurred while saving book : " + ex.Message);
                }

                DialogResult = DialogResult.OK;

                Close();

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void txtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                errorProvider1.SetError((TextBox)sender, "This field is required.");
                btnSave.Enabled = false;
            }
            else
            {
                errorProvider1.SetError((TextBox)sender, string.Empty);
                btnSave.Enabled = true;
            }
        }
    }
}
