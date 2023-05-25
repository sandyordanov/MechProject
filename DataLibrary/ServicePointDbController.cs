using BCrypt.Net;
using Classes.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class ServicePointDbController : IServicePointDbController
    {
        string dBConnection;
        public ServicePointDbController()
        {
            dBConnection = DbConnectionString.Get;
        }

        public bool RegisterServicePoint(ServicePointBindModel model)
        {
            int success;
            using (var connection = new SqlConnection(dBConnection))
            {     
                connection.Open();
                string query = "INSERT INTO ServicePoints (Username, Password, Name, Address, Email, PhoneNumber) VALUES(@username, @password, @name, @address, @email, @phoneNumber)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("username", model.Username);
                    command.Parameters.AddWithValue("password",BCrypt.Net.BCrypt.HashPassword(model.Password));
                    command.Parameters.AddWithValue("name", model.Name);
                    command.Parameters.AddWithValue("address", model.Address);
                    command.Parameters.AddWithValue("email", model.Email);
                    command.Parameters.AddWithValue("phoneNumber", model.PhoneNumber);
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
            throw new NotImplementedException();
        }

        public void InsertDetails(ServicePointBindModel input)
        {
            throw new NotImplementedException();
        }
    }
}
