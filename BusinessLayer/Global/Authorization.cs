using Library.Models;

namespace Library.Business.Global;

public static class Authorization
{
    public static void EnsureLoggedIn()
    {
        if (!CurrentUser.IsLoggedIn)
            throw new UnauthorizedAccessException(
                "You must login first.");
    }

    public static void EnsureAdmin()
    {
        EnsureLoggedIn();

        if (!CurrentUser.IsAdmin)
            throw new UnauthorizedAccessException(
                "Only administrators can perform this operation.");
    }

    public static void EnsureLibrarianOrAdmin()
    {
        EnsureLoggedIn();

        if (!CurrentUser.IsAdmin &&
            !CurrentUser.IsLibrarian)
        {
            throw new UnauthorizedAccessException(
                "Access denied.");
        }
    }
}