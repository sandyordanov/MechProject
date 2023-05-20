using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class ValidateLogin
    {
        private readonly string connectionString = DbConnectionString.Get;

        public bool Login(string username, string password)
        {
            bool result = false;
            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Accounts WHERE UserType =  Email = @Email AND Password = @Password", connection);
             //   cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    result = true;
                }
            }
            return result;
        }

    }
}

