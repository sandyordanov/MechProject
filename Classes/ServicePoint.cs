using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ServicePoint
    {
        private double rating;

        public ServicePoint()
        {
            
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public double RatingSum { get; set; }
        public int Votes { get; set; }

        public double GetRating() 
        {
            rating =Math.Round(RatingSum / Votes, 2);
            return rating; }
    }
}
