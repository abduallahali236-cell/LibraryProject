using Library.DataAccess;
using Library.Models;
using System.Data;
using Library.Business.Global;
using static Library.Models.Report;

namespace Library.Business;

public class ReportService
{
    public DataTable GetReport(
        ReportType reportType,
        string? search = null,
        DateTime? from = null,
        DateTime? to = null)
    {
        Authorization.EnsureLibrarianOrAdmin();

        return ReportData.GetReport(
            reportType,
            search,
            from,
            to);
    }
}