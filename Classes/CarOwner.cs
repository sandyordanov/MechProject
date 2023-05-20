using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class CarOwner
    {
        public CarOwner()
        {
            
        }
        public CarOwner(int id, string fullName, string email, string password)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            Password  = password;
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public void ChangePassword(string newPassword)
        {

        }
    }
}
