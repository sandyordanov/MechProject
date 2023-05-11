using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class RepairRequest
    {
        private int _id;
        private string _description;
        private Car _car;
        private CarOwner _owner;
        private List<Maintenance> maintenancesRequired = new List<Maintenance>();
        private List<Repair> _fixesMade = new List<Repair>();

        private void AddFix(Repair repair)
        {
            _fixesMade.Add(repair);
        }
    }
}
