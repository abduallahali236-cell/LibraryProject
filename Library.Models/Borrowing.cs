namespace Library.Models;

public class Borrowing
{
    public int BorrowId { get; set; }

    // Display Properties
    public string? MemberName { get; set; }

    public string? BookTitle { get; set; }

    public DateTime BorrowDate { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public string Status { get; set; } = string.Empty;

}