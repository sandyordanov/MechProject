using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class ShowCars
    {
        
        public List<Car> Cars  = new List<Car>();

        public Car GetCar()
        {
            foreach (var car in Cars)
            {
                return car;
            }
            return null;
        }
        public void Addcars(List<Car> list)
        {
            foreach (var car in list)
            {
                Cars.Add(car);
            }
        }
    }
}
