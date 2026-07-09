using Library.Business.Global;
using Library.DataAccess;
using Library.Models;

namespace Library.Business;

public class BorrowingService
{
    public bool Borrow(int memberId, int bookId, DateTime dueDate)
    {
        Authorization.EnsureLibrarianOrAdmin();

        if (!MemberData.Exists(memberId))
            throw new InvalidOperationException("Member not found.");

        if (!BookData.Exists(bookId))
            throw new InvalidOperationException("Book not found.");

        Book? book = BookData.GetById(bookId);

        if (book == null)
            throw new InvalidOperationException("Book not found.");

        if (book.AvailableCopies <= 0)
            throw new InvalidOperationException("No available copies.");

        if (dueDate <= DateTime.Today)
            throw new ArgumentException("Due date must be greater than today.");

        return BorrowingData.Borrow(memberId, bookId, dueDate);
    }

    public bool Return(int borrowId)
    {
        Authorization.EnsureLibrarianOrAdmin();

        Borrowing? borrowing = BorrowingData.GetById(borrowId);

        if (borrowing == null)
            throw new InvalidOperationException("Borrowing record not found.");

        if (borrowing.ReturnDate != null)
            throw new InvalidOperationException("Book has already been returned.");

        return BorrowingData.Return(borrowId);
    }

    public Borrowing? GetById(int borrowId)
    {
        Authorization.EnsureLibrarianOrAdmin();

        return BorrowingData.GetById(borrowId);
    }

    public List<Borrowing> GetAll()
    {
        Authorization.EnsureLibrarianOrAdmin();

        return BorrowingData.GetAll();
    }

    public List<Borrowing> GetBorrowedBooks()
    {
        Authorization.EnsureLibrarianOrAdmin();

        return BorrowingData.GetBorrowedBooks();
    }

    public List<Borrowing> Search(string keyword)
    {
        Authorization.EnsureLibrarianOrAdmin();

        if (string.IsNullOrWhiteSpace(keyword))
            return GetAll();

        return BorrowingData.Search(keyword.Trim());
    }
}