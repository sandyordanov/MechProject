using System;
using System.Net;
using System.Numerics;
using Microsoft.Data.SqlClient;

namespace DataLibrary
{
    public class ServicePointManagement
    {
        private readonly IServicePointDbController _servicePointDbController;
        public ServicePointManagement(IServicePointDbController servicePointDbCon)
        {
            _servicePointDbController = servicePointDbCon;
        }
        public void RegisterServicePoint(string name,string address,string phone,string email,string password)
        {
            _servicePointDbController.RegisterServicePoint(name,address,phone,email,password);
        }
        public List<ServicePoint> GetAllServices()
        {
            return _servicePointDbController.GetAllServicePoints();
        }
    }
}
