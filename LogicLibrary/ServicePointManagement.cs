using System;
using System.Numerics;
using System.Text.RegularExpressions;
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

        public List<ServicePoint> SortShopsByRating(List<ServicePoint> list)
        {
            List<ServicePoint> sortedList = list;
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
        public List<ServicePoint> SearchForRepairShops(string search)
        {
            List<string> keyWords = Regex.Split(search.ToLower(), @"[\s,\.]+").ToList();
            List<ServicePoint> AllservicePoints = GetAllRepairShops();
            List<ServicePoint> matchingShops = new List<ServicePoint>();
            foreach (string keyWord in keyWords)
            {
                foreach (ServicePoint servicePoint in AllservicePoints)
                {
                    if (servicePoint.Name.ToLower().Contains(keyWord) || servicePoint.Address.ToLower().Contains(keyWord))
                    {
                        if (!matchingShops.Contains(servicePoint))
                        {
                            matchingShops.Add(servicePoint);
                        }
                    }
                }
            }
            return SortShopsByRating(matchingShops);
        }
    }
}
