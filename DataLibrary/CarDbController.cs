using Classes;
using Classes.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

        public Car GetCarById(int carId)
        {
            Car car = null;
            using (var connection = new SqlConnection(dBConnection))
            {
                string query = "SELECT Make, Model, Year, Mileage WHERE Id = @id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", carId);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
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
                        }      
                    }
                }
            }
            return car;
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
        public void CreateCar(CarBindModel input)
        {
            using (var connection = new SqlConnection(dBConnection))
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

    }
}
