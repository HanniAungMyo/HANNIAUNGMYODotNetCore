// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");
//Console.ReadKey();
//Console.ReadLine();
string connectionString = "Data Source=LAPTOP\\SQLSERVER;Initial Catalog=DotNetTraning;User ID=sa;Password=sa@123";
SqlConnection connection = new SqlConnection(connectionString);
Console.WriteLine("Connection Opening..................");
connection.Open();
Console.WriteLine("Connection Opened");
string sql =@"SELECT [BlogId]
      ,[BlogTitle]
      ,[BlogAuthor]
      ,[BlogContent]
      ,[DeleteFlag]
  FROM [dbo].[Tbl_Blog]";
SqlCommand cmd = new SqlCommand(sql,connection);
//SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//adapter.Fill(dt);
SqlDataReader reader = cmd.ExecuteReader();
while (reader.Read())
{
    Console.WriteLine(reader["BlogId"]);
    Console.WriteLine(reader["BlogTitle"]);
    Console.WriteLine(reader["BlogAuthor"]);
    Console.WriteLine(reader["BlogContent"]);
}
Console.WriteLine("Connection Closing..................");
connection.Close();
Console.WriteLine("Connection Closed");
//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine(dr["BlogId"].ToString());
//    Console.WriteLine(dr["BlogTitle"].ToString());
//    Console.WriteLine(dr["BlogAuthor"].ToString());
//    Console.WriteLine(dr["BlogContent"].ToString());
//}