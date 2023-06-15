using System.Data.SqlClient;

Console.WriteLine("SQL Server Hello World");

var connectionString = @"Server=tcp:professionaltraining.database.windows.net,1433;Initial Catalog=trainingdb;Persist Security Info=False;User ID=ptdbuser;Password=Training2023#@!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

SqlConnection conn = new SqlConnection(connectionString);

conn.Open();

var sql = "SELECT * FROM members";

SqlCommand cmd = new SqlCommand(sql, conn);
SqlDataReader rdr = cmd.ExecuteReader();

while (rdr.Read())
{
    Console.WriteLine(rdr.GetString(1));
}

rdr.Close();
conn.Close();



