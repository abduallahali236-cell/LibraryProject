namespace Library.Models;

public class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;

    public string ISBN { get; set; } = string.Empty;

    public int PublishYear { get; set; }

    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;

    public int Copies { get; set; }

    public int AvailableCopies { get; set; }

    public string DisplayName =>
    $"{Title} ({AvailableCopies} Available)";
}