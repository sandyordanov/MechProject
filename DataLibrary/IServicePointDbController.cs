using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IServicePointDbController
    {
        List<ServicePoint> GetAllServicePoints();
        void InsertDetails(SpDetails input);
        bool RegisterServicePoint(string name, string adress, string phone, string email, string password);
    }
}
