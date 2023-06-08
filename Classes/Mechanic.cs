using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Mechanic
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int WorkplaceId { get; set; }
        public MechLevel MechLevel { get; set; }

        public Mechanic(string firstName, string lastName, string phoneNumber, string password,int workplaceId)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Password = password;
            WorkplaceId = workplaceId;
        }
        public Mechanic()
        {
            
        }
    }
}
