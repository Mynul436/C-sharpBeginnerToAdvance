using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetExamples
{
    internal class DataUtility
    {
        public void AddData()
        {
            
            string connectionString= "Server=DESKTOP-UAD9J96\\SQLEXPRESS;Database=Csharpb10;User Id=csharpb10;Password=akash1122";

            SqlConnection connection = new SqlConnection(connectionString);
            var sql= "insert into Students_Example([Name],Cgpa,DateOfBirth) values('Ahmed', 2.99, '2010-11-17')";
            SqlCommand command=new SqlCommand(sql, connection);
            command.Connection=connection;
            command.CommandText = sql;
            connection.Open();
            command.ExecuteNonQuery();
            //connection.ConnectionString = "";
            connection.Close();
            command.Dispose();
            connection.Dispose();
            
        }
    }
}
