using Classes;
using Microsoft.Data.SqlClient;
namespace DataLibrary
{
    public class RepairRequestDbController : IRepairRequestDbController
    {
        string _connectionString;
        public RepairRequestDbController()
        {
            _connectionString = DbConnectionString.Get;
        }
        public List<RequestInfo> GetAllRequests(int servicePointId)
        {
            using ( SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Id, CarId, UserId, isAccepted FROM RepairRequests WHERE ServicePointId = @id";
                List<RequestInfo> allRequest = new List<RequestInfo>();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", servicePointId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allRequest.Add(new RequestInfo()
                            {
                                Id = reader.GetInt32(0),
                                CarId = reader.GetInt32(1),
                                UserId = reader.GetInt32(2),
                                IsAccepted = reader.GetBoolean(3)
                            });
                        }
                        return allRequest;
                    }
                }
            }
        }
    }
}
