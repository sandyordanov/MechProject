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
        private List<RepairRequest> repairRequests;
        private readonly IUserDbController _userController;
        private readonly ICarDbController _carController;
        private readonly IRepairRequestDbController _repairController;

        public RepairRequestManagement(IUserDbController userDbCon, ICarDbController carDbCon, IRepairRequestDbController repairDbCon)
        {
            repairRequests = new List<RepairRequest>();
            _userController = userDbCon;
            _carController = carDbCon;
            _repairController = repairDbCon;
        }

        public User GetUserInfo(int userId)
        {
            return _userController.GetUserById(userId);
        }

        public Car GetCarInfo(int userId)
        {
            return _carController.GetCarById(userId);
        }

        public List<RepairRequest> GetRepairRequests()
        {
            repairRequests = _repairController.GetAllRequests();
            return repairRequests;
        }
        
    }
}
