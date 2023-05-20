using Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class CarDbController : ICarDbController
    {
        string dBConnection;
        public CarDbController() 
        {
            dBConnection = DbConnectionString.Get;
        }

        public Car GetCarById(int userId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCars(int userId)
        {
            Car car = null;
            List<Car> list = new List<Car>();

            using (var connection = new SqlConnection(dBConnection))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT Make, Model, Year, Mileage FROM Cars WHERE ownerId = @Id";
                command.Parameters.AddWithValue("@Id", userId);

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
    }
}
