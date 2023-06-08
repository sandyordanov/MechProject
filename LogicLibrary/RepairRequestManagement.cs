using Classes;
using DataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class RepairRequestManagement
    {
        private readonly IRepairRequestDbController _repairController;

        public RepairRequestManagement(IRepairRequestDbController repairDbCon)
        {
            _repairController = repairDbCon;
        }

        public List<int> GetRepairAllRequests(int servicePointId)
        {
            return _repairController.GetAllNewRepairRequests(servicePointId);
        }

        public RepairRequest GetRepairRequest(int requestId) 
        {
            return _repairController.GetRepairRequest(requestId);
        }

        public void SetRequestAsAcceptedOrDenied(bool isAccepted, int Id)
        {
            _repairController.SetRequestAsAcceptedOrDenied(isAccepted, Id);
        }

        public int InsertNewRequest(int carId, int userId, int servicePointId)
        {
            return _repairController.InsertNewRequest(carId, userId, servicePointId);
        }

        public void InsertRequestDetails(RepairDetails details, int Id)
        {
            _repairController.InsertRequestDetails(details, Id);
        }

        public List<int> GetAllAcceptedRepairRequests(int servicePointId)
        {
            return _repairController.GetAllAcceptedRepairRequests(servicePointId);
        }
    }
}
