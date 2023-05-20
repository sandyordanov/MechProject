
using Classes.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class MechanicDBController
    {
        private readonly string _connectionString;

        public MechanicDBController()
        {
            _connectionString = DbConnectionString.Get;
        }

        public void InsertDetails(MechanicDetails input)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Mechanics (UserId, FirstName, SecondName, Mechlevel) VALUES (@UserId, @FirstName, @SecondName, @Mechlevel)";
                command.Parameters.AddWithValue("@UserId", input.Id);
                command.Parameters.AddWithValue("@FirstName", input.FirstName);
                command.Parameters.AddWithValue("@SecondName", input.LastName);
                command.Parameters.AddWithValue("@Mechlevel", input.MechLevel);

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
