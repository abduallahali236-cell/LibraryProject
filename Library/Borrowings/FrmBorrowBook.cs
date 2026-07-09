using Library.Business;
using Library.Models;

namespace Library.UI.Borrowings;

public partial class FrmBorrowBook : Form
{
    private readonly BorrowingService _borrowingService = new();

    private readonly MemberService _memberService = new();

    private readonly BookService _bookService = new();

    public FrmBorrowBook()
    {
        InitializeComponent();

        LoadData();

        InitializeForm();
    }

    private void InitializeForm()
    {
        Text = "Borrow Book";

        dtpDueDate.Value = DateTime.Today.AddDays(14);

        dtpDueDate.MinDate = DateTime.Today.AddDays(1);
    }
    private void LoadData()
    {
        LoadMembers();

        LoadBooks();
    }
    private void LoadMembers()
    {
        cmbMembers.DataSource =
            _memberService.GetAll();

        cmbMembers.DisplayMember = "FullName";

        cmbMembers.ValueMember = "MemberId";
    }

    private void LoadBooks()
    {


        cmbBooks.DataSource =
            _bookService
            .GetAll()
            .Where(b => b.AvailableCopies > 0)
            .ToList();



        cmbBooks.DisplayMember = "DisplayName";

        cmbBooks.ValueMember = "BookId";
    }
    private void btnBorrow_Click(object sender, EventArgs e)
    {
        try
        {
            int memberId =
                (int)cmbMembers.SelectedValue;

            int bookId =
                (int)cmbBooks.SelectedValue;     
            
            _borrowingService.Borrow(
                memberId,
                bookId,
                dtpDueDate.Value);

            MessageHelper.Success(
                "Book borrowed successfully.");

            DialogResult = DialogResult.OK;

            Close();
        }
        catch (Exception ex)
        {
            MessageHelper.Error(ex.Message);
        }
    }
    private void btnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}