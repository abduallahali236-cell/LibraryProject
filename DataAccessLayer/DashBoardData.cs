using System.Data;
using Library.Models;
using Microsoft.Data.SqlClient;

namespace Library.DataAccess;

public static class DashboardData
{
    public static DashboardStats GetStatistics()
    {
        using SqlConnection connection = Database.GetConnection();

        using SqlCommand command =
            new("sp_GetDashboardStatistics", connection);

        command.CommandType = CommandType.StoredProcedure;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        if (!reader.Read())
            return new DashboardStats();

        return new DashboardStats
        {
            TotalBooks = (int)reader["TotalBooks"],
            TotalMembers = (int)reader["TotalMembers"],
            BorrowedBooks = (int)reader["BorrowedBooks"],
            OverdueBooks = (int)reader["OverdueBooks"]
        };
    }
}