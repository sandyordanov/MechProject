using Classes;
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
        bool RegisterServicePoint(ServicePointBindModel model);
        List<ServicePoint> GetAllServicePoints();
        void InsertDetails(ServicePointBindModel input);
    }
}
