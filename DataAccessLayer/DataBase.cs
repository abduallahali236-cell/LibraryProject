using Microsoft.Data.SqlClient;
using System.Data;

namespace Library.DataAccess;

public static class Database
{
    private const string ConnectionString =
        "Server=(localdb)\\MSSQLLocalDB;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(ConnectionString);
    }
}