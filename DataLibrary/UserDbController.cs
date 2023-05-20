
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

        public bool RegisterUser(string email, string password)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Users (Password, Email) VALUES (@Password, @Email)", connection);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Email", email);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public bool RegisterMechanic(string username, string password, string email)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Users (Username, Password, Email) VALUES (@Username, @Password, @Email)", connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Email", email);
                return command.ExecuteNonQuery() == 1;
            }
        }
        public bool RegisterServicePoint(string username, string password, string email)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Users (Username, Password, Email) VALUES (@Username, @Password, @Email)", connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Email", email);
                return command.ExecuteNonQuery() == 1;
            }
        }

        public bool ValidateUser(string username, string password)
        {
            bool result = false;
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Username = @Username AND Password = @Password", con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    result = true;
                }
            }
            return result;
        }
        public async Task<bool> RegisterUserAsync(Register input)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.Transaction = transaction;
                        command.CommandText = "INSERT INTO Users (Email, Password, UserType) VALUES (@Email, @Password, @UserType)";
                        command.Parameters.AddWithValue("@Email", input.Email);
                        command.Parameters.AddWithValue("@Password", BCrypt.Net.BCrypt.HashPassword(input.Password));
                        command.Parameters.AddWithValue("@UserType", input.Role.ToString());

                        await command.ExecuteNonQueryAsync();
                    }

                    transaction.Commit();
                    return true;
                }

            }
        }
        public User GetUserByEmail(string Email)
        {
            User user = null;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT Id, Email, Password, UserType FROM Users WHERE Email = @Email";
                command.Parameters.AddWithValue("@Email", Email);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            Id = reader.GetInt32(0),
                            Email = reader.GetString(1),
                            Password = reader.GetString(2),
                            Role = reader.GetString(3),
                        };
                    }
                }
            }

            return user;
        }
        public void InsertAuthToken(int userId, string token)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO AuthTokens (UserId, Token) VALUES (@UserId, @Token)";
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@Token", token);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteAuthToken(int userId)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM AuthTokens WHERE UserId = @UserId";
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }


        public bool IsAuthTokenValid(int userId, string authToken)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) FROM AuthTokens WHERE UserId = @UserId AND Token = @Token";
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@Token", authToken);

                connection.Open();

                int count = (int)command.ExecuteScalar();

                return count == 1;
            }
        }
        public void CreateCar(AddCar input)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Cars (Make, Model, Year, Mileage, OwnerId) VALUES (@Make, @Model, @Year ,@Mileage, @OwnerId)";
                command.Parameters.AddWithValue("@Make", input.Make);
                command.Parameters.AddWithValue("@Model", input.Model);
                command.Parameters.AddWithValue("@Year", input.Year);
                command.Parameters.AddWithValue("@Mileage", input.Mileage);
                command.Parameters.AddWithValue("@OwnerId", input.OwnerId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public List<Car> GetCars(int Id)
        {
            Car car = null;
            List<Car> list = new List<Car>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT Make, Model, Year, Mileage FROM Cars WHERE ownerId = @Id";
                command.Parameters.AddWithValue("@Id", Id);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        car = new Car
                        {
                            Make = reader.GetString(0),
                            Model = reader.GetString(1),
                            Year = reader.GetInt32(2),
                            Mileage = reader.GetInt32(3),
                        };
                        list.Add(car);
                    }
                }
            }

            return list;
        }

        public User GetUserById(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
