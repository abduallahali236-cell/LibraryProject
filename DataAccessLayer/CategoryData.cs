using System.Data;
using Library.Models;
using Microsoft.Data.SqlClient;

namespace Library.DataAccess;

public static class CategoryData
{
    public static bool Add(Category category)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_AddCategory", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = category.CategoryName;

        connection.Open();

        return command.ExecuteNonQuery() > 0;
    }

    public static bool Update(Category category)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_UpdateCategory", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = category.CategoryId;
        command.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = category.CategoryName;

        connection.Open();

        return command.ExecuteNonQuery() > 0;
    }

    public static bool Delete(int categoryId)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_DeleteCategory", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = categoryId;

        connection.Open();

        return command.ExecuteNonQuery() > 0;
    }

    public static Category? GetById(int categoryId)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_GetCategoryById", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = categoryId;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        if (!reader.Read())
            return null;

        return Map(reader);
    }

    public static List<Category> GetAll()
    {
        List<Category> categories = new();

        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new("sp_GetAllCategories", connection);

        command.CommandType = CommandType.StoredProcedure;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            categories.Add(Map(reader));
        }

        return categories;
    }

    public static bool Exists(int categoryId)
    {
        using SqlConnection connection = Database.GetConnection();
        using SqlCommand command = new(
            "SELECT COUNT(*) FROM Categories WHERE CategoryID = @CategoryID",
            connection);

        command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = categoryId;

        connection.Open();

        return (int)command.ExecuteScalar()! > 0;
    }

    private static Category Map(SqlDataReader reader)
    {
        return new Category
        {
            CategoryId = (int)reader["CategoryID"],
            CategoryName = reader["CategoryName"].ToString()!,
            BookCount = (int)reader["BookCount"]
        };
    }
}