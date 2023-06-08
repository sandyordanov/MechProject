using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IRepairRequestDbController
    {
        RepairRequest GetRepairRequest(int requestId);
        List<int> GetAllNewRepairRequests(int servicePointId);
        List<int> GetAllAcceptedRepairRequests(int servicePointId);
        void SetRequestAsAcceptedOrDenied(bool isAccepted, int Id);
        int InsertNewRequest(int carId, int userId, int servicePointId);
        void InsertRequestDetails(RepairDetails details, int Id);
        bool IsRequestSent(int carId);
    }
}
