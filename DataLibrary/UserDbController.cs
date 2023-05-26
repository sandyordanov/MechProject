
using Microsoft.Data.SqlClient;
using Classes;
using Classes.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace DataLibrary
{
    public class UserDbController : IUserDbController
    {
        private readonly string _connectionString;

        public UserDbController()
        {
            _connectionString = DbConnectionString.Get;
        }

        public bool RegisterUser(UserBindModel model)
        {
            int success;
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Users (FirstName, LastName, Email, Username, Password) VALUES (@firstName, @lastName, @email, @username, @password)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("firstName", model.FirstName);
                    command.Parameters.AddWithValue("lastName", model.LastName);
                    command.Parameters.AddWithValue("email", model.Email);
                    command.Parameters.AddWithValue("username", model.Username);
                    command.Parameters.AddWithValue("password", BCrypt.Net.BCrypt.HashPassword(model.Password));
                    success = command.ExecuteNonQuery();
                }
            }
            if (success == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public UserBindModel GetUserByUsername(string username)
        {
            UserBindModel user = null;
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Id, FirstName, LastName, Email, Password FROM Users WHERE Username = @username";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user = new UserBindModel()
                            {
                                Id = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Email = reader.GetString(3),
                                Password = reader.GetString(4),
                            };
                        }
                    }
                }
            }
            return user;
        }

        public User GetUserById(int userId)
        {
            User user = null;
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT FirstName, LastName, Email FROM Users WHERE Id = @id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", userId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user = new User()
                            {
                                FirstName = reader.GetString(0),
                                LastName = reader.GetString(1),
                                Email = reader.GetString(2)
                            };
                        }
                    }
                }
            }
            return user;
        }

        public bool UserHasCars(int userId)
        {
            List<int> ints = new List<int>();
            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Id FROM Cars WHERE OwnerId = @ownerId";
                using(var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("ownerId", userId);
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ints.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            if(ints.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
