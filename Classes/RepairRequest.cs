﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class RepairRequest
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public User User { get; set; }
        public RepairDetails RepairDetails { get; set; }
        public bool IsAccepted { get; set; }

        public RepairRequest(int id, Car car, User user, RepairDetails details)
        {
            Id = id;
            Car = car;
            User = user;
            RepairDetails = details;
        }

        public RepairRequest()
        {
            Car = new Car();
            User = new User();
            RepairDetails = new RepairDetails();
        }

        public void WriteReport(string report)
        {
            RepairDetails.WriteReport(report);
        }
        public override string ToString()
        {
            return $"{Id} - {Car.Make} {Car.Model}";
        }
    }
}
