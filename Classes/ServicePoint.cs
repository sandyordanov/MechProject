using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ServicePoint
    {
        private int _id;
        private string _name;
        private string _address;
        private string _phoneNumber;
        private List<RepairRequest> _repairRequests;
        private List<Mechanic> _mechanics;

        public ServicePoint(string email, string password, UserType position, string name, string address, string phoneNumber) 
        {
            _name = name;
            _address = address;
            _phoneNumber = phoneNumber;
            _repairRequests = new List<RepairRequest>();
            _mechanics = new List<Mechanic>();
        }

        public List<RepairRequest> GetRepairRequests()
        {
            return _repairRequests;
        }
        public List<Mechanic> GetMechanics()
        {
            return _mechanics;
        }
        public void PromoteMechanic(Mechanic toBePromoted)
        {
            MechLevel l = toBePromoted.GetLevel();
            l -= 1;
            toBePromoted.SetLevel(l);
        }
    }
}
