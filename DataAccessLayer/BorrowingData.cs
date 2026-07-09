using System.Data;
using Library.Models;
using Microsoft.Data.SqlClient;

namespace Library.DataAccess;

public static class BorrowingData
{
    public static bool Borrow(int memberId, int bookId, DateTime dueDate)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_BorrowBook", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberId;
        command.Parameters.Add("@BookID", SqlDbType.Int).Value = bookId;
        command.Parameters.Add("@DueDate", SqlDbType.Date).Value = dueDate;

        connection.Open();

        return command.ExecuteNonQuery() > 0;
    }

    public static bool Return(int borrowId)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_ReturnBook", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@BorrowID", SqlDbType.Int).Value = borrowId;

        connection.Open();

        return command.ExecuteNonQuery() > 0;
    }

    public static Borrowing? GetById(int borrowId)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_GetBorrowingById", connection);

        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@BorrowID", SqlDbType.Int).Value = borrowId;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        if (!reader.Read())
            return null;

        return Map(reader);
    }

    public static List<Borrowing> GetAll()
    {
        List<Borrowing> borrowings = new();

        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_GetAllBorrowings", connection);

        command.CommandType = CommandType.StoredProcedure;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            borrowings.Add(Map(reader));
        }

        return borrowings;
    }

    public static List<Borrowing> GetBorrowedBooks()
    {
        List<Borrowing> borrowings = new();

        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_GetBorrowedBooks", connection);

        command.CommandType = CommandType.StoredProcedure;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            borrowings.Add(Map(reader));
        }

        return borrowings;
    }

    public static List<Borrowing> Search(string keyword)
    {
        List<Borrowing> borrowings = new();

        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_SearchBorrowings", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@Keyword", SqlDbType.NVarChar).Value = keyword;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            borrowings.Add(Map(reader));
        }

        return borrowings;
    }

    public static bool HasActiveBorrowings(int memberId)
    {
        string query = "select 1 as HasBorrowedBooks from vw_MembersBorrowCount where MemberID = @MemberID AND TotalBorrowed > 0";

        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new(query, connection);

        command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberId;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        return reader.Read() && (bool)reader["HasBorrowedBooks"];
    }

    private static Borrowing Map(SqlDataReader reader)
    {
        return new Borrowing
        {
            BorrowId = (int)reader["BorrowID"],
            MemberName = reader["MemberName"].ToString(),
            BookTitle = reader["BookTitle"].ToString(),

            BorrowDate = (DateTime)reader["BorrowDate"],
            DueDate = (DateTime)reader["DueDate"],
            ReturnDate = reader["ReturnDate"] == DBNull.Value
                ? null
                : (DateTime?)reader["ReturnDate"],

            Status = reader["Status"].ToString()!

        };
    }
}
