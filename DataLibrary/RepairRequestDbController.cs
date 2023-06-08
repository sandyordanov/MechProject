using Azure.Core;
using Classes;
using Microsoft.Data.SqlClient;
using System.Net;

namespace DataLibrary
{
    public class RepairRequestDbController : IRepairRequestDbController
    {
        private readonly string _connectionString;
        public RepairRequestDbController()
        {
            _connectionString = DbConnectionString.Get;
        }

        public List<int> GetAllNewRepairRequests(int servicePointId)
        {
            List<int> result = new List<int>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Id FROM RepairRequests WHERE ServicePointId = @spId AND IsAccepted IS NULL";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("spId", servicePointId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            return result;
        }

        public List<int> GetAllAcceptedRepairRequests(int servicePointId)
        {
            List<int> result = new List<int>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Id FROM RepairRequests WHERE ServicePointId = @spId AND IsAccepted = 1";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("spId", servicePointId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            return result;
        }

        public RepairRequest GetRepairRequest(int requestId)
        {
            RepairRequest request = new RepairRequest();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT RepairRequests.Id, Cars.Make, Cars.Model, Cars.Year, Cars.Mileage, Users.FirstName, Users.LastName, Users.Email, RepairDetails.Description, RepairDetails.OilChange, RepairDetails.AirFilter, RepairDetails.LightBulb, RepairDetails.TyreChange, RepairDetails.CoolantChange FROM RepairRequests INNER Join Cars ON RepairRequests.CarId = Cars.Id INNER JOIN Users ON RepairRequests.UserId = Users.Id INNER JOIN RepairDetails ON RepairRequests.Id = RepairDetails.Id WHERE RepairRequests.Id = @requestId AND IsAccepted IS NULL";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("requestId", requestId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            request = new RepairRequest()
                            {
                                Id = reader.GetInt32(0)
                            };
                            Car car = new Car()
                            {
                                Make = reader.GetString(1),
                                Model = reader.GetString(2),
                                Year = reader.GetInt32(3),
                                Mileage = reader.GetInt32(4)
                            };
                            User user = new User()
                            {
                                FirstName = reader.GetString(5),
                                LastName = reader.GetString(6),
                                Email = reader.GetString(7),
                            };
                            RepairDetails details = new RepairDetails()
                            {
                                Description = reader.GetString(8),
                                OilChange = reader.GetBoolean(9),
                                AirFilter = reader.GetBoolean(10),
                                LightBulb = reader.GetBoolean(11),
                                TyreChange = reader.GetBoolean(12),
                                CoolantChange = reader.GetBoolean(13)
                            };
                            request.Car = car;
                            request.User = user;
                            request.RepairDetails = details;
                            request.IsAccepted = false;

                        }
                    }
                }
                return request;
            }
        }

        public int InsertNewRequest(int carId, int userId, int servicePointId)
        {
            int id = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO RepairRequests (CarId, UserId, ServicePointId) VALUES (@carId, @userId, @servicePointId) SELECT SCOPE_IDENTITY()";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("carId", carId);
                    command.Parameters.AddWithValue("userId", userId);
                    command.Parameters.AddWithValue("servicePointId", servicePointId);
                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        id = Convert.ToInt32(reader.GetDecimal(0));
                    }
                }
            }
            return id;
        }

        public void InsertRequestDetails(RepairDetails details, int Id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO RepairDetails (Id, Description, OilChange, AirFilter, TyreChange, CoolantChange, LightBulb) VALUES (@id,@description, @oil, @air, @tyre, @coolant, @bulb)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", Id);
                    command.Parameters.AddWithValue("description", details.Description);
                    command.Parameters.AddWithValue("oil", details.OilChange);
                    command.Parameters.AddWithValue("air", details.AirFilter);
                    command.Parameters.AddWithValue("tyre", details.TyreChange);
                    command.Parameters.AddWithValue("coolant", details.CoolantChange);
                    command.Parameters.AddWithValue("bulb", details.LightBulb);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void SetRequestAsAcceptedOrDenied(bool isAccepted, int Id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE RepairRequests SET IsAccepted = @isAccepted  WHERE Id = @id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("isAccepted", isAccepted);
                    command.Parameters.AddWithValue("id", Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool IsRequestSent(int carId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Id From RepairRequests WHERE CarId = @carId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@carId", carId);
                    if (command.ExecuteScalar() == null)
                    {
                        return false;
                    }
                    else { return true; }
                }
            }
        }
    }
}
