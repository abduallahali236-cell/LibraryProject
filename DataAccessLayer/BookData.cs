using Library.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Net;

namespace Library.DataAccess;

public static class BookData
{
    public static bool Add(Book book)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_AddBook", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = book.Title;
        command.Parameters.Add("@Author", SqlDbType.NVarChar).Value = book.Author;
        command.Parameters.Add("@ISBN", SqlDbType.NVarChar).Value = book.ISBN;
        command.Parameters.Add("@PublishYear", SqlDbType.Int).Value = book.PublishYear;
        command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = book.CategoryId;
        command.Parameters.Add("@Copies", SqlDbType.Int).Value = book.Copies;

        connection.Open();

        return command.ExecuteNonQuery() > 0;
    }

    public static bool Update(Book book)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_UpdateBook", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@BookID", SqlDbType.Int).Value = book.BookId;
        command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = book.Title;
        command.Parameters.Add("@Author", SqlDbType.NVarChar).Value = book.Author;
        command.Parameters.Add("@ISBN", SqlDbType.NVarChar).Value = book.ISBN;
        command.Parameters.Add("@PublishYear", SqlDbType.Int).Value = book.PublishYear;
        command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = book.CategoryId;
        connection.Open();

        return command.ExecuteNonQuery() > 0;
    }

    public static bool Delete(int bookId)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_DeleteBook", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@BookID", SqlDbType.Int).Value = bookId;

        connection.Open();

        return command.ExecuteNonQuery() > 0;
    }

    public static Book? GetById(int bookId)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_GetBookById", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@BookID", SqlDbType.Int).Value = bookId;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        if (!reader.Read())
            return null;

        return Map(reader);
    }

    public static List<Book> GetAll()
    {
        List<Book> books = new();

        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_GetAllBooks", connection);

        command.CommandType = CommandType.StoredProcedure;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            books.Add
                (new Book
                {
                    BookId = (int)reader["BookID"],
                    Title = reader["Title"].ToString()!,
                    Author = reader["Author"].ToString()!,
                    ISBN = reader["ISBN"].ToString()!,
                    PublishYear = (int)reader["PublishYear"],
                    CategoryName = reader["CategoryName"].ToString()!,
                    Copies = (int)reader["Copies"],
                    AvailableCopies = (int)reader["AvailableCopies"]
                });
        }

        return books;
    }

    public static List<Book> Search(string keyword)
    {
        List<Book> books = new();

        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_SearchBook", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@Keyword", SqlDbType.NVarChar).Value = keyword;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            books.Add(Map(reader));
        }

        return books;
    }

    public static bool Exists(int bookId)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("SELECT COUNT(*) FROM Books WHERE BookID = @BookID", connection);

        command.Parameters.Add("@BookID", SqlDbType.Int).Value = bookId;

        connection.Open();

        return (int)command.ExecuteScalar()! > 0;
    }

    public static bool HasBooks(int categoryId)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("SELECT COUNT(*) FROM Books WHERE CategoryID = @CategoryID", connection);

        command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = categoryId;

        connection.Open();

        return (int)command.ExecuteScalar()! > 0;
    }

    private static Book Map(SqlDataReader reader)
    {
        return new Book
        {
            BookId = (int)reader["BookID"],
            Title = reader["Title"].ToString()!,
            Author = reader["Author"].ToString()!,
            ISBN = reader["ISBN"].ToString()!,
            PublishYear = (int)reader["PublishYear"],
            CategoryId = (int)reader["CategoryID"],
            Copies = (int)reader["Copies"],
            AvailableCopies = (int)reader["AvailableCopies"]
        };
    }
}