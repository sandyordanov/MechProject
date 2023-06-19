using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class RepairDetails
    {
        [Required]
        public string Description { get; set; }
        [Required]
        public bool OilChange { get; set; }
        public bool AirFilter { get; set; }
        public bool TyreChange { get; set; }
        public bool CoolantChange { get; set; }
        public bool LightBulb { get; set; }
        public string Report { get; set; }

        public void WriteReport(string report)
        {
            Report = report;
        }
        public void EditDescription(string description)
        {
           Description = description;
        }
    }
}
