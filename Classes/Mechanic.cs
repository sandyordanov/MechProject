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
        public MechLevel MechLevel { get; set; }
        private int _id;
        private string _firstName;
        private string _lastName;
        private MechLevel _level;
        private string _email;
        private string _password;
        private RepairRequest _repairRequest;
        public Mechanic(int id, string firstName, string lastName, MechLevel level, string email, string password)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _level = level;
            _email = email;
            _password = password;
        }

        public string GetInfo()
        {
            return $"{_firstName} {_lastName} {_level}";
        }
        public MechLevel GetLevel()
        {
            return _level;
        }
        public void SetLevel(MechLevel l)
        {
            _level = l;
        }


    }
}
