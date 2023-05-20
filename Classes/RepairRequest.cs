using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class RepairRequest
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public int ServicePointId { get; set; }
        public int OptionsId { get; set; }
        public int MechanicId { get; set; }
        public string Description { get; set; }
        public bool IsAccepted { get; set; }
        public List<Options> Options { get; set; }

        
    }
}
