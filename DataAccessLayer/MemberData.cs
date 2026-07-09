using System.Data;
using Library.Models;
using Microsoft.Data.SqlClient;

namespace Library.DataAccess;

public static class MemberData
{
    public static bool Add(Member member)
    {
        using SqlConnection connection = Database.GetConnection();

        using SqlCommand command = new("sp_AddMember", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = member.FullName;
        command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = member.Phone;
        command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = member.Email;
        command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = member.Address;

        connection.Open();

        return command.ExecuteNonQuery() > 0;
    }

    public static bool Update(Member member)
    {
        using SqlConnection connection = Database.GetConnection();

        using SqlCommand command = new("sp_UpdateMember", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@MemberID", SqlDbType.Int).Value = member.MemberId;
        command.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = member.FullName;
        command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = member.Phone;
        command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = member.Email;
        command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = member.Address;

        connection.Open();

        return command.ExecuteNonQuery() > 0;
    }

    public static bool Delete(int memberId)
    {
        using SqlConnection connection = Database.GetConnection();

        using SqlCommand command = new("sp_DeleteMember", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberId;

        connection.Open();

        return command.ExecuteNonQuery() > 0;
    }

    public static Member? GetById(int memberId)
    {
        using SqlConnection connection = Database.GetConnection();

        using SqlCommand command = new("sp_GetMemberById", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberId;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        if (!reader.Read())
            return null;

        return Map(reader);
    }

    public static List<Member> GetAll()
    {
        List<Member> members = new();

        using SqlConnection connection = Database.GetConnection();

        using SqlCommand command = new("sp_GetAllMembers", connection);

        command.CommandType = CommandType.StoredProcedure;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            members.Add(Map(reader));
        }

        return members;
    }

    public static List<Member> Search(string keyword)
    {
        List<Member> members = new();

        using SqlConnection connection = Database.GetConnection();

        using SqlCommand command = new("sp_SearchMembers", connection);

        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("@Keyword", SqlDbType.NVarChar).Value = keyword;

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            members.Add(Map(reader));
        }

        return members;
    }

    public static bool Exists(int memberId)
    {
        using SqlConnection connection = Database.GetConnection();

        using SqlCommand command = new("SELECT COUNT(*) FROM Members WHERE MemberID=@MemberID", connection);

        command.Parameters.Add("@MemberID", SqlDbType.Int).Value = memberId;

        connection.Open();

        return (int)command.ExecuteScalar()! > 0;
    }

    private static Member Map(SqlDataReader reader)
    {
        return new Member
        {
            MemberId = (int)reader["MemberID"],
            FullName = reader["FullName"].ToString()!,
            Phone = reader["Phone"].ToString()!,
            Email = reader["Email"].ToString()!,
            Address = reader["Address"].ToString()!,
            JoinDate = (DateTime)reader["JoinDate"]
        };
    }
}