using BCrypt.Net;
using Classes;
using Classes.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class ServicePointDbController : IServicePointDbController
    {
        private readonly string dBConnection;
        public ServicePointDbController()
        {
            dBConnection = DbConnectionString.Get;
        }

        public bool IsUsernameFree(string username, string userType)
        {
            using (SqlConnection connection = new SqlConnection(dBConnection))
            {
                connection.Open();
                string query = "";
                if (userType == "admin")
                {
                    query = "SELECT Id FROM ServicePoints WHERE Username = @username";
                }
                if (userType == "mechanic")
                {
                    query = "SELECT Id FROM Mechanics WHERE Username = @username";
                }
                if (userType == "owner")
                {
                    query = "SELECT Id FROM Users WHERE Username = @username";
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    if (command.ExecuteScalar() != null)
                    {
                        return false;
                    }
                    else { return true; }
                }
            }
        }
        public bool RegisterServicePoint(ServicePointBindModel model)
        {
            int success;
            using (var connection = new SqlConnection(dBConnection))
            {
                connection.Open();
                string query = "INSERT INTO ServicePoints (Username, Password, Name, Address, Email, PhoneNumber, Rating, Votes) VALUES(@username, @password, @name, @address, @email, @phoneNumber, @rating, @votes)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("username", model.Username);
                    command.Parameters.AddWithValue("password", BCrypt.Net.BCrypt.HashPassword(model.Password));
                    command.Parameters.AddWithValue("name", model.Name);
                    command.Parameters.AddWithValue("address", model.Address);
                    command.Parameters.AddWithValue("email", model.Email);
                    command.Parameters.AddWithValue("phoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("rating", 0);
                    command.Parameters.AddWithValue("votes", 0);
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

        public List<ServicePoint> GetAllServicePoints()
        {
            ServicePoint service = new ServicePoint();
            List<ServicePoint> repairShops = new List<ServicePoint>();
            using (var connection = new SqlConnection(dBConnection))
            {
                connection.Open();
                string query = "SELECT Id, Name, Address, Email, PhoneNumber, Rating, Votes FROM ServicePoints";
                using (var command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            service = new ServicePoint()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Address = reader.GetString(2),
                                Email = reader.GetString(3),
                                PhoneNumber = reader.GetString(4),
                                RatingSum = Convert.ToDouble(reader.GetInt32(5)),
                                Votes = reader.GetInt32(6),
                            };
                            repairShops.Add(service);
                        }
                    }
                }
            }
            return repairShops;
        }

        public List<ServicePoint> GetServicePointsPagination(int startIndex, int itemsPerPage)
        {
            int endIndex = startIndex + itemsPerPage - 1;
            ServicePoint service = new ServicePoint();
            List<ServicePoint> repairShops = new List<ServicePoint>();
            using (var connection = new SqlConnection(dBConnection))
            {
                connection.Open();
                string query = @" SELECT * FROM (SELECT *, ROW_NUMBER() OVER (ORDER BY Id) AS RowNumber FROM ServicePoints) AS sub WHERE sub.RowNumber BETWEEN @StartIndex AND @EndIndex;";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartIndex", startIndex);
                    command.Parameters.AddWithValue("@EndIndex", endIndex);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            service = new ServicePoint()
                            {
                                Id = reader.GetInt32(0),
                                UserName = reader.GetString(1),
                                Password = reader.GetString(2),
                                Name = reader.GetString(3),                              
                                Address = reader.GetString(4),
                                Email = reader.GetString(5),
                                PhoneNumber = reader.GetString(6),
                                RatingSum = Convert.ToDouble(reader.GetInt32(7)),
                                Votes = reader.GetInt32(8),
                            };
                            repairShops.Add(service);
                        }
                    }
                }
            }
            return repairShops;
        }

        public int GetShopsCount()
        {
            using (var connection = new SqlConnection(dBConnection))
            {
                connection.Open();
                string query = "SELECT COUNT(Id) FROM ServicePoints";
                using (var command = new SqlCommand(query, connection))
                {
                    return (int)command.ExecuteScalar();
                }

            }
        }

        public void AssignJobToMech(int requestId, int mechId)
        {
            using (SqlConnection connection = new SqlConnection(dBConnection))
            {
                connection.Open();
                string query = "INSERT INTO Mechanics_RepairRequests (MechanicId, RepairRequestId) VALUES (@mechId, @requestId)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("mechId", mechId);
                    command.Parameters.AddWithValue("requestId", requestId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
