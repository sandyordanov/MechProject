using Classes;
using Classes.Models;
using DataLibrary;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class CarManagement
    {
        private readonly ICarDbController _controller;
        public CarManagement(ICarDbController carDbController) 
        {
            _controller = carDbController;
        }

        public void CreateCar(CarBindModel model)
        {
            _controller.CreateCar(model);
        }
        public Car GetCarById(int carId)
        {
            return _controller.GetCarById(carId);
        }
        public List<Car> GetCarsByUserId(int userId)
        {   
            return _controller.GetCarsByUserId(userId);
        }
        public void DeleteCar(int carId)
        {
            _controller.DeleteCar(carId);
        }
    }
}
