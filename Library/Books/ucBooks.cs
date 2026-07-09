using Library.Business;
using Library.Business.Global;
using Library.Models;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Library.UI.Books;

public partial class ucBooks : UserControl
{
    private readonly BookService _bookService;

    public ucBooks()
    {
        InitializeComponent();

        _bookService = new BookService();

        LoadBooks();

        ApplyPermissions();
    }

    private void ApplyPermissions()
    {
        btnDelete.Visible = CurrentUser.IsAdmin;
    }
    private void LoadBooks()
    {
        dgvBooks.DataSource = _bookService.GetAll();

        // hide DisplayName column if it was auto-generated
        var displayColumn = dgvBooks.Columns["DisplayName"];
        if (displayColumn != null)
            displayColumn.Visible = false;
        var categoryIdColumn = dgvBooks.Columns["CategoryId"];
        if (categoryIdColumn != null)
            categoryIdColumn.Visible = false;

        dgvBooks.ClearSelection();
    }
    private void btnSearch_Click(object sender, EventArgs e)
    {
        dgvBooks.DataSource =
            _bookService.Search(txtSearch.Text.Trim());
    }
    private void btnRefresh_Click(object sender, EventArgs e)
    {
        txtSearch.Clear();

        LoadBooks();
    }
    private void btnAdd_Click(object sender, EventArgs e)
    {
        FrmBookDetails frm = new();

        if (frm.ShowDialog() == DialogResult.OK)
            LoadBooks();
    }
    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvBooks.CurrentRow == null)
            return;



        Book book = (Book)dgvBooks.CurrentRow.DataBoundItem;

        FrmBookDetails frm = new(book);

        if (frm.ShowDialog() == DialogResult.OK)
            LoadBooks();
    }
    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvBooks.CurrentRow == null)
            return;

        if ((Book)dgvBooks.CurrentRow.DataBoundItem == null)
            return;

        Book book = (Book)dgvBooks.CurrentRow.DataBoundItem;

        if (!MessageHelper.Confirm(
            $"Delete '{book.Title}' ?"))
            return;
        try 
        { 
        _bookService.Delete(book.BookId);
        }
        catch(Exception ex)
        {
            MessageHelper.Error("An error occurred while deleting the book." + ex.Message);
            return;
        }

        MessageHelper.Success("Book deleted successfully.");
        LoadBooks();
    }
}
