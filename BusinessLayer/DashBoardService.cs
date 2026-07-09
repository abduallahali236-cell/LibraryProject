using Library.DataAccess;
using Library.Models;
using Library.Business.Global;

namespace Library.Business;

public class DashboardService
{
    public DashboardStats GetStatistics()
    {
        Authorization.EnsureLibrarianOrAdmin();

        return DashboardData.GetStatistics();
    }
}