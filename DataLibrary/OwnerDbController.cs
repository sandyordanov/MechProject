
using Classes;
using Classes.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class OwnerDbController : IOwnerDbController
    {
        private readonly string _connectionString;

        public OwnerDbController()
        {
            _connectionString = DbConnectionString.Get;
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

        public void RegisterOwner(User owner)
        {
            throw new NotImplementedException();
        }

        public User GetOwner()
        {
            throw new NotImplementedException();
        }
    }
}

