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
        public int MechLevel { get; set; }

        public List<string> Skills { get; private set; } = new List<string>();

    public Mechanic(string firstName, string lastName, string phoneNumber, string password, int workplaceId, int level)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Password = password;
            WorkplaceId = workplaceId;
            MechLevel = level;
        }
        public Mechanic()
        {

        }

        public void PromoteMechanic()
        {
            MechLevel += 1;
        }
        public void AddSkills(List<string> skillList)
        {
            Skills = skillList;
        }
    }
}
