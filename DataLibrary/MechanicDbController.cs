
using Classes;
using Classes.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class MechanicDBController : IMechanicDbController
    {
        private readonly string _connectionString;

        public MechanicDBController()
        {
            _connectionString = DbConnectionString.Get;
        }

        public bool CheckIfUsernameIsFree(string username)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT Id FROM Mechanics WHERE Username = @username";
                using (SqlCommand command = new SqlCommand(query, conn))
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

        public List<Mechanic> GetAllWorkersInAWorkshop(int spId)
        {
            List<Mechanic> list = new List<Mechanic>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Id, FirstName, LastName, PhoneNumber,Username, Password FROM Mechanics WHERE WorkplaceId = @spId";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("spId", spId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Mechanic()
                            {
                                Id = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                PhoneNumber = reader.GetString(3),
                                Username = reader.GetString(4),
                                Password = reader.GetString(5),
                                WorkplaceId = spId
                            });
                        }
                    }
                }
            }
            return list;
        }

        public Mechanic GetMechById(int mechId)
        {
            Mechanic mech = new Mechanic();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT FirstName, LastName, PhoneNumber,Username, Password, WorkplaceId FROM Mechanics WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("Id", mechId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        mech = new Mechanic()
                        {
                            Id = mechId,
                            FirstName = reader.GetString(0),
                            LastName = reader.GetString(1),
                            PhoneNumber = reader.GetString(2),
                            Username = reader.GetString(3),
                            Password = reader.GetString(4),
                            WorkplaceId = reader.GetInt32(5)
                        };
                    }
                }
            }
            return mech;
        }
        public void AddMechSpeciality(int mechId, List<string> strings)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                foreach (string s in strings)
                {
                    string query = "INSERT INTO MechanicDetails (Speciality, MechanicId) VALUES (@item, @mechId)";
                    using (var command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("item", s);
                        command.Parameters.AddWithValue("mechId", mechId);
                        command.ExecuteNonQuery();
                    }

                }
            }
        }

        public List<string> GetMechSpeciality(int mechId)
        {
            List<string> list = new List<string>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Speciality FROM MechanicDetails WHERE MechanicId = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", mechId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(reader.GetString(0));
                        }
                    }

                }
            }
            return list;
        }

        public void InsertMechanic(Mechanic mechanic)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Mechanics (FirstName, LastName, PhoneNumber, Username, Password, WorkplaceId) VALUES (@FirstName, @Lastname,@PhoneNumber, @Username, @Password, @WorkplaceId)";
                command.Parameters.AddWithValue("FirstName", mechanic.FirstName);
                command.Parameters.AddWithValue("LastName", mechanic.LastName);
                command.Parameters.AddWithValue("PhoneNumber", mechanic.PhoneNumber);
                command.Parameters.AddWithValue("Username", mechanic.Username);
                command.Parameters.AddWithValue("Password", mechanic.Password);
                command.Parameters.AddWithValue("WorkplaceId", mechanic.WorkplaceId);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public int GetMechanicId(string username)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Id FROM Mechanics WHERE Username = @username";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("username", username);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = reader.GetInt32(0);
                        }
                    }
                }
            }
            return id;
        }
    }
}
