﻿using Classes;
using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IServicePointDbController
    {
        bool IsUsernameFree(string username, string userType);
        bool RegisterServicePoint(ServicePointBindModel model);
        List<ServicePoint> GetAllServicePoints();
        List<ServicePoint> GetServicePointsPagination(int startIndex, int ItemsPerPage);
        int GetShopsCount();
        void AssignJobToMech(int requestId, int mechId);
    }
}
