using System;
using System.Numerics;
using Classes;
using Classes.Models;
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
        public bool RegisterServicePoint(ServicePointBindModel model)
        {
           return _servicePointDbController.RegisterServicePoint(model);
        }
        public List<ServicePoint> GetAllServices()
        {
            return _servicePointDbController.GetAllServicePoints();
        }
    }
}
