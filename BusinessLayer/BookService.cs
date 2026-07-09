using Library.Business.Global;
using Library.DataAccess;
using Library.Models;

namespace Library.Business;

public class BookService
{
    public bool Add(Book book)
    {
        Authorization.EnsureLibrarianOrAdmin();

        Validate(book);

        return BookData.Add(book);
    }

    public bool Update(Book book)
    {
        Authorization.EnsureLibrarianOrAdmin();

        Validate(book);

        if (!BookData.Exists(book.BookId))
            throw new InvalidOperationException("Book not found.");

        return BookData.Update(book);
    }

    public bool Delete(int bookId)
    {
        Authorization.EnsureAdmin();

        if (!BookData.Exists(bookId))
            throw new InvalidOperationException("Book not found.");

        return BookData.Delete(bookId);
    }

    public Book? GetById(int bookId)
    {
        Authorization.EnsureLibrarianOrAdmin();

        return BookData.GetById(bookId);
    }

    public List<Book> GetAll()
    {
        Authorization.EnsureLibrarianOrAdmin();

        return BookData.GetAll();
    }

    public List<Book> Search(string keyword)
    {
        Authorization.EnsureLibrarianOrAdmin();

        if (string.IsNullOrWhiteSpace(keyword))
            return GetAll();

        return BookData.Search(keyword.Trim());
    }

    private static void Validate(Book book)
    {
        if (book == null)
            throw new ArgumentNullException(nameof(book));

        if (string.IsNullOrWhiteSpace(book.Title))
            throw new ArgumentException("Book title is required.");

        if (book.Title.Length > 200)
            throw new ArgumentException("Book title is too long.");

        if (string.IsNullOrWhiteSpace(book.Author))
            throw new ArgumentException("Author is required.");

        if (book.Author.Length > 150)
            throw new ArgumentException("Author name is too long.");

        if (string.IsNullOrWhiteSpace(book.ISBN))
            throw new ArgumentException("ISBN is required.");

        if (book.PublishYear < 1450 || book.PublishYear > DateTime.Now.Year + 1)
            throw new ArgumentException("Invalid publish year.");

        if (book.CategoryId <= 0)
            throw new ArgumentException("Please select a category.");

        if (!CategoryData.Exists(book.CategoryId))
            throw new InvalidOperationException("Category not found.");

        if (book.Copies <= 0)
            throw new ArgumentException("Copies must be greater than zero.");
        if (book.Copies - book.AvailableCopies < 0)
            throw new ArgumentOutOfRangeException("AvailableCopies cannot be greater than Copies.");
    }
}