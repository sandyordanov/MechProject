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
        public List<ServicePoint> GetAllRepairShops()
        {
            return _servicePointDbController.GetAllServicePoints();
        }
        public bool IsUsernameFree(string username, string userType)
        {
            return _servicePointDbController.IsUsernameFree(username, userType);
        }

        public List<ServicePoint> GetSortedShopsByRating()
        {
            List<ServicePoint> sortedList = GetAllRepairShops();
            sortedList.Sort((x, y) => y.GetRating().CompareTo(x.GetRating()));
            return sortedList;
        }
        public List<ServicePoint> GetServicePointsPagination(int count, int index)
        {
            return _servicePointDbController.GetServicePointsPagination(count, index);
        }
        public int GetShopsCount()
        {
            return _servicePointDbController.GetShopsCount();
        }
    }
}
