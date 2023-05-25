using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class CarBindModel
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public int OwnerId { get; set ; }

        public void AddCars(List<Car> cars)
        {

        }
    }

}
