using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MemberManagerLibrary
{
    public class SqlServerMemberManager : IMemberManager
    {
        private SqlConnection _conn;
        private string _connectionString = $@"Server=tcp:professionaltraining.database.windows.net,1433;Initial Catalog=trainingdb;Persist Security Info=False;User ID=ptdbuser;Password=xxxxxxx;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

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
            rdr.Close();
            return member;
        }
        public void Delete(int id)
        {
            var sql = $"DELETE FROM members WHERE id = {id}";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
        }

        public void Update(Member memberToUpdate)
        {
            var sql = $@"UPDATE members 
                        SET name = '{ memberToUpdate.Name }', 
                            email = '{ memberToUpdate.Email }', 
                            active = { (memberToUpdate.Active ? 1 : 0)}
                            WHERE id = {memberToUpdate.Id}";

            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
        }


        public Member AddMember(Member member)
        {
            var sql = $@"INSERT INTO members
                         (name, email, active)
                        VALUES('{member.Name}', 
                               '{member.Email}', 
                                {(member.Active ? 1 : 0)})";

            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();


            // return added member
            // including the newly assigned id

            sql = "SELECT @@IDENTITY";
            cmd = new SqlCommand(sql, _conn);

            var addedId = (Decimal)cmd.ExecuteScalar();

            member.Id = (int)addedId;
            return member;
        }

        public void Close()
        {
            _conn.Close();
        }



        public void DisplayAll()
        {
            throw new NotImplementedException();
        }



        public List<Member> GetActiveMembers()
        {
            throw new NotImplementedException();
        }




    }
}