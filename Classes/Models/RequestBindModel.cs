using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class RequestBindModel
    {
        public int CarId { get; set; }
        public int RepairShopId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public bool OilChange { get; set; }
        public bool AirFilter { get; set; }
        public bool TyreChange { get; set; }
        public bool CoolantChange { get; set; }
        public bool LightBulb { get; set; }
        public string Report { get; set; }
        public bool IsAccepted { get; set; }
    }
}
