using Library.Models;
using static Library.Models.User;

namespace Library.Business.Global;

public static class CurrentUser
{
    public static User? User { get; private set; }

    public static bool IsLoggedIn => User != null;

    public static int UserId => User?.UserId ?? 0;

    public static string Username => User?.Username ?? "";

    public static string FullName => User?.FullName ?? "";

    public static UserRole Role => User?.Role ?? UserRole.Librarian;

    public static bool IsAdmin => Role == UserRole.Admin;

    public static bool IsLibrarian => Role == UserRole.Librarian;

    public static void Login(User user)
    {
        User = user;
    }

    public static void Logout()
    {
        User = null;
    }
}