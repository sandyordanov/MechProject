using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace CarApp
{
    public class DataLoader
    {
        public int Do()
        {
            var connection = new SqlConnection(@"Server = mssqlstud.fhict.local; Database = dbi505814; User Id = dbi505814; Password = Takethatcucumber123@;TrustServerCertificate=True;");
            using(connection)
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users";
                var command = new SqlCommand(query, connection);
               var count = command.ExecuteScalar();
                return (int)count;
            }
            
        }
    }
}
