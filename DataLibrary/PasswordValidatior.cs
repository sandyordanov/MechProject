using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using Microsoft.Data.SqlClient;

namespace DataLibrary
{
    public class PasswordValidatior
    {
        private string _connectionString = DbConnectionString.Get;

        public int ValidateCredentials(string username, string password, string userType)
        {
            int loggedUserId;
            string query = "";
            if (userType == "admin")
            {
                query = "SELECT Id FROM ServicePoints WHERE Username = @username AND Password = @password";
            }
            if (userType == "mechanic")
            {
                query = "SELECT Id FROM Mechanics WHERE Username = @username AND Password = @password";
            }
            if (query != null)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("username", username);
                        command.Parameters.AddWithValue("password", password);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                loggedUserId = reader.GetInt32(0);
                                return loggedUserId;
                            }
                            else
                            {
                                return 0;
                            }
                        }
                    }
                }
            }
            return 0;
        }
    }
}
