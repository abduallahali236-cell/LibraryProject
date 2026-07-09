using Library.Business.Global;
using Library.DataAccess;
using Library.Models;

namespace Library.Business;

public class MemberService
{
    public bool Add(Member member)
    {
        Authorization.EnsureLibrarianOrAdmin();

        Validate(member);

        return MemberData.Add(member);
    }

    public bool Update(Member member)
    {
        Authorization.EnsureLibrarianOrAdmin();

        Validate(member);

        if (!MemberData.Exists(member.MemberId))
            throw new InvalidOperationException("Member not found.");

        return MemberData.Update(member);
    }

    public bool Delete(int memberId)
    {
        Authorization.EnsureAdmin();

        if (!MemberData.Exists(memberId))
            throw new InvalidOperationException("Member not found.");

        // Optional Business Rule:
         if (BorrowingData.HasActiveBorrowings(memberId))
             throw new InvalidOperationException(
                 "Cannot delete a member with active borrowings.");

        return MemberData.Delete(memberId);
    }

    public Member? GetById(int memberId)
    {
        Authorization.EnsureLibrarianOrAdmin();

        return MemberData.GetById(memberId);
    }

    public List<Member> GetAll()
    {
        Authorization.EnsureLibrarianOrAdmin();

        return MemberData.GetAll();
    }

    public List<Member> Search(string keyword)
    {
        Authorization.EnsureLibrarianOrAdmin();

        if (string.IsNullOrWhiteSpace(keyword))
            return GetAll();

        return MemberData.Search(keyword.Trim());
    }

    private static void Validate(Member member)
    {
        if (member == null)
            throw new ArgumentNullException(nameof(member));

        if (string.IsNullOrWhiteSpace(member.FullName))
            throw new ArgumentException("Full name is required.");

        if (member.FullName.Length > 100)
            throw new ArgumentException("Full name is too long.");

        if (string.IsNullOrWhiteSpace(member.Phone))
            throw new ArgumentException("Phone number is required.");

        if (member.Phone.Length < 11 || member.Phone.Length > 15)
            throw new ArgumentException("Invalid phone number.");

        if (!member.Phone.All(char.IsDigit))
            throw new ArgumentException("Phone number must contain digits only.");

        if (string.IsNullOrWhiteSpace(member.Email))
            throw new ArgumentException("Email is required.");

        if (!member.Email.Contains('@'))
            throw new ArgumentException("Invalid email address.");

        if (member.Email.Length > 100)
            throw new ArgumentException("Email is too long.");

        if (string.IsNullOrWhiteSpace(member.Address))
            throw new ArgumentException("Address is required.");

        if (member.Address.Length > 200)
            throw new ArgumentException("Address is too long.");
    }
}