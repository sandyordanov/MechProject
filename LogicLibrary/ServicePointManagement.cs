using System;
using Microsoft.Data.SqlClient;

namespace DataLibrary
{
    public class ServicePointManagement
    {
        private readonly string connectionString = @"Server = mssqlstud.fhict.local; Database = dbi505814; User Id = dbi505814; Password = Takethatcucumber123@;TrustServerCertificate=True;";

        public bool RegisterServicePoint(string name, string adress, string phone, string email, string password)
        {
            using (var connection = new SqlConnection(connectionString))
            {
               // connection.Open();
                var command = new SqlCommand("INSERT INTO ServicePoints (Name, Password, Email, Adress, Phone) VALUES (@Name, @Password, @Email, @Adress, @Phone)", connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Adress", adress);
                command.Parameters.AddWithValue("@Phone", phone);
                return command.ExecuteNonQuery() == 1;
            }
        }
    }
}
