using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotnetExample
{
    internal class DataUtility
    {
        public void AddData()
        {
            string connectionString = "Server=DESKTOP-UAD9J96\\SQLEXPRESS;Database=Practice;User Id=practice;Password=12345;";
            SqlConnection connection = new SqlConnection(connectionString);
            var sql = "insert into tbl_abc([Name],id) values('Mynul', '2018831050')";
            
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            cmd.Dispose();
            connection.Dispose();
        }
    }
}
