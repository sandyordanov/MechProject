using Classes;
using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface ICarDbController
    {
        void CreateCar(CarBindModel model);
        Car GetCarById(int carId);
        List<Car> GetCarsByUserId(int userId);
    }
}
