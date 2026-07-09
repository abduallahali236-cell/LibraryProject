using Library.Business.Global;
using Library.DataAccess;
using Library.Models;
using BCrypt.Net;


namespace Library.Business;

public class UserService
{
    public User? Login(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new ArgumentException("Username is required.");

        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Password is required.");


        // Retrieve user by username and verify password using BCrypt
        User? user = UserData.GetByUsername(username);

        if (user == null)
            return null;

        bool verified = BCrypt.Net.BCrypt.Verify(password, user.Password);

        if (!verified)
            return null;

        CurrentUser.Login(user);

        return user;
    }

    public void Logout()
    {
        CurrentUser.Logout();
    }

    public bool Add(User user)
    {
        Authorization.EnsureAdmin();

        Validate(user);

        if (UserData.Exists(user.Username))
            throw new InvalidOperationException("Username already exists.");

        user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

        return UserData.Add(user);
    }

    public bool Update(User user)
    {
        Authorization.EnsureAdmin();

        Validate(user);
        user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

        return UserData.Update(user);
    }

    public bool Delete(int userId)
    {
        Authorization.EnsureAdmin();

        if (CurrentUser.UserId == userId)
            throw new InvalidOperationException("You cannot delete your own account.");

        return UserData.Delete(userId);
    }

    public User? GetById(int userId)
    {
        return UserData.GetById(userId);
    }

    public List<User> GetAll()
    {
        Authorization.EnsureAdmin();

        return UserData.GetAll();
    }

    private static void Validate(User user)
    {
        if (user == null)
            throw new ArgumentNullException(nameof(user));

        if (string.IsNullOrWhiteSpace(user.Username))
            throw new ArgumentException("Username is required.");

        if (user.Username.Length < 4)
            throw new ArgumentException("Username must be at least 4 characters.");

        if (string.IsNullOrWhiteSpace(user.Password))
            throw new ArgumentException("Password is required.");

        if (user.Password.Length < 6)
            throw new ArgumentException("Password must be at least 6 characters.");

        if (string.IsNullOrWhiteSpace(user.FullName))
            throw new ArgumentException("Full name is required.");
    }

}