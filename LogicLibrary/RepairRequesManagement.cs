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
        private List<RequestInfo> repairRequests;
        private readonly IRepairRequestDbController _repairController;

        public RepairRequestManagement(IRepairRequestDbController repairDbCon)
        {
            repairRequests = new List<RequestInfo>();
            _repairController = repairDbCon;
        }

        public List<RequestInfo> GetRepairRequests(int id)
        {
            repairRequests = _repairController.GetAllRequests(id);
            return repairRequests;
        }
        
    }
}
