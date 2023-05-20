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

        public List<ServicePoint> GetAllServicePoints()
        {
            throw new NotImplementedException();
        }

        public void InsertDetails(SpDetails input)
        {
            throw new NotImplementedException();
        }

        public bool RegisterServicePoint(string name, string adress, string phone, string email, string password)
        {
            using (var connection = new SqlConnection(dBConnection))
            {
                // connection.Open();
                var command = new SqlCommand("INSERT INTO ServicePoints (Name, Password, Email, Adress, Phone) VALUES (@Name, @Password, @Email, @Adress, @Phone)", connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Adress", adress);
                command.Parameters.AddWithValue("@Phone", phone);
                return command.ExecuteNonQuery() == 1;
            }
        }
    }
}
