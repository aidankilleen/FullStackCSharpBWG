using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MemberManagerLibrary
{
    public class SqlServerMemberManager : IMemberManager
    {
        private SqlConnection _conn;
        private string _connectionString = @"Server=tcp:professionaltraining.database.windows.net,1433;Initial Catalog=trainingdb;Persist Security Info=False;User ID=ptdbuser;Password=Training2023#@!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public SqlServerMemberManager()
        {
            _conn = new SqlConnection(_connectionString);
            _conn.Open();
        }

        public List<Member> GetAll()
        {
            List<Member> members = new List<Member>();

            var sql = "SELECT * FROM members";

            SqlCommand cmd = new SqlCommand(sql, _conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                var member = new Member
                {
                    Id = rdr.GetInt32(0),
                    Name = rdr.GetString(1),
                    Email = rdr.GetString(2),
                    Active = rdr.GetBoolean(3)
                };
                members.Add(member);
            }
            rdr.Close(); 

            return members;
        }

        public Member? FindById(int id)
        {
            var sql = $"SELECT * FROM members WHERE id = { id }";

            SqlCommand cmd = new SqlCommand(sql, _conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            Member? member = null;
            if (rdr.Read())
            {
                member = new Member
                {
                    Id = rdr.GetInt32(0),
                    Name = rdr.GetString(1),
                    Email = rdr.GetString(2),
                    Active = rdr.GetBoolean(3)
                };
            }
            return member;
        }


        public void AddMember(Member member)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DisplayAll()
        {
            throw new NotImplementedException();
        }



        public List<Member> GetActiveMembers()
        {
            throw new NotImplementedException();
        }



        public void Update(Member memberToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}