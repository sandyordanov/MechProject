
using Classes.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class OwnerDbController
    {
        private readonly string _connectionString;

        public OwnerDbController()
        {
            _connectionString = GetConnection.Get;
        }

        public void InsertDetails(SpDetails input)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO ServicePoints (UserId, Name, Adress, Phone) VALUES (@Id, @Name, @Adress, @Phone)";
                command.Parameters.AddWithValue("@Id", input.Id);
                command.Parameters.AddWithValue("@Name", input.Name);
                command.Parameters.AddWithValue("@Adress", input.Adress);
                command.Parameters.AddWithValue("@Phone", input.Phone);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public int GetId(string Email)
        {
            int id = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT Id FROM Users WHERE Email = @Email";
                command.Parameters.AddWithValue("@Email", Email);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        id = reader.GetInt32(0);
                    }
                }
            }

            return id;
        }
    }
}

