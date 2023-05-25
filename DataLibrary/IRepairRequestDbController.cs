using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IRepairRequestDbController
    {
        List<RequestInfo> GetAllRequests(int servicePointId);
    }
}
