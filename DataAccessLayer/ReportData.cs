using System.Data;
using Microsoft.Data.SqlClient;
using Library.Models;
using static Library.Models.Report;


namespace Library.DataAccess;

public static class ReportData
{
    public static DataTable GetReport(
        ReportType reportType,
        string? search = null,
        DateTime? from = null,
        DateTime? to = null)
    {
        using SqlConnection connection = Database.GetConnection();

        using SqlCommand command = new();

        command.Connection = connection;
        command.CommandType = CommandType.StoredProcedure;

        switch (reportType)
        {
            case ReportType.Books:
                command.CommandText = "sp_ReportBooks";
                break;

            case ReportType.Members:
                command.CommandText = "sp_ReportMembers";
                break;

            case ReportType.Borrowings:
                command.CommandText = "sp_ReportBorrowings";
                break;

            case ReportType.OverdueBooks:
                command.CommandText = "sp_ReportOverdueBooks";
                break;

            default:
                throw new ArgumentException("Invalid report type.");
        }

        command.Parameters.AddWithValue("@Search",
            string.IsNullOrWhiteSpace(search)
                ? DBNull.Value
                : search);

        command.Parameters.AddWithValue("@FromDate",
            from ?? (object)DBNull.Value);

        command.Parameters.AddWithValue("@ToDate",
            to ?? (object)DBNull.Value);

        connection.Open();

        DataTable table = new();

        using SqlDataAdapter adapter = new(command);

        adapter.Fill(table);

        return table;
    }
}