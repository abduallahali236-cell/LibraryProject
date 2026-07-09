using System.Data;
using Library.Models;
using Microsoft.Data.SqlClient;

namespace Library.DataAccess;

public static class UserData
{
    public static bool Add(User user)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new SqlCommand("dbo.sp_CreateUser", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = user.Username;
        command.Parameters.Add("@Password", SqlDbType.NVarChar, 255).Value = user.Password;
        command.Parameters.Add("@FullName", SqlDbType.NVarChar, 100).Value = user.FullName;
        command.Parameters.Add("@Role", SqlDbType.NVarChar, 20).Value = user.Role == User.UserRole.Admin ? "Admin" : "Librarian";


        connection.Open();

        return command.ExecuteNonQuery() > 0;
    }

    public static bool Update(User user)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_UpdateUser", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@UserID", SqlDbType.Int).Value = user.UserId;
        command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = user.Username;
        command.Parameters.Add("@Password", SqlDbType.NVarChar, 255).Value = user.Password;
        command.Parameters.Add("@FullName", SqlDbType.NVarChar, 100).Value = user.FullName;
        command.Parameters.Add("@Role", SqlDbType.NVarChar, 20).Value = user.Role == User.UserRole.Admin ? "Admin" : "Librarian";


        connection.Open();

        return command.ExecuteNonQuery() > 0;
    }

    public static bool Delete(int userId)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_DeleteUser", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@UserID", SqlDbType.Int).Value = userId;

        connection.Open();

        return command.ExecuteNonQuery() > 0;
    }

    public static User? GetById(int userId)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_GetUserById", connection);

        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@UserID", SqlDbType.Int).Value = userId;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        if (!reader.Read())
            return null;

        return Map(reader);
    }

    public static User? GetByUsername(string username)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new(
            "SELECT UserID, Username, Password, FullName, Role FROM Users WHERE Username = @Username",
            connection);

        command.CommandType = CommandType.Text;
        command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = username;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        if (!reader.Read())
            return null;

        return Map(reader);
    }

    public static List<User> GetAll()
    {
        List<User> users = new();

        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_GetAllUsers", connection);

        command.CommandType = CommandType.StoredProcedure;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            users.Add(Map(reader));
        }

        return users;
    }

    public static User? Login(string username, string password)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_Login", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = username;
        command.Parameters.Add("@Password", SqlDbType.NVarChar, 255).Value = password;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        if (!reader.Read())
            return null;

        return Map(reader);
    }

    public static bool Exists(string username)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new(
            "SELECT COUNT(*) FROM Users WHERE Username = @Username",
            connection);

        command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = username;

        connection.Open();

        return (int)command.ExecuteScalar()! > 0;
    }

    private static User Map(SqlDataReader reader)
    {
        try
        {
            int idOrd = reader.GetOrdinal("UserID");
            int usernameOrd = reader.GetOrdinal("Username");
            int pwdOrd = reader.GetOrdinal("Password");
            int fullNameOrd = reader.GetOrdinal("FullName");
            int roleOrd = reader.GetOrdinal("Role");

            return new User
            {
                UserId = reader.IsDBNull(idOrd) ? 0 : reader.GetInt32(idOrd),
                Username = reader.IsDBNull(usernameOrd) ? string.Empty : reader.GetString(usernameOrd),
                Password = reader.IsDBNull(pwdOrd) ? string.Empty : reader.GetString(pwdOrd),
                FullName = reader.IsDBNull(fullNameOrd) ? string.Empty : reader.GetString(fullNameOrd),
                Role = reader.IsDBNull(roleOrd) ? User.UserRole.Librarian
                       : (reader.GetString(roleOrd) == "Admin" ? User.UserRole.Admin : User.UserRole.Librarian)
            };
        }
        catch (IndexOutOfRangeException ex)
        {
            throw new InvalidOperationException($"Expected column missing from query result: {ex.Message}", ex);
        }
    }
}