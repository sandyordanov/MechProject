using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace DataLibrary
{
    public class PasswordValidatior
    {
        private static User admin = new User("jeff", "1234", UserType.ServicePoint);
        private static User employee = new User("chef", "1234", UserType.Mechanic);
        private List<User> users = new List<User> { admin, employee };

        public User? ValidateCredentials(string email, string password)
        {
            foreach (var user in users)
            {
                if (user.Email == email && user.Password == password) { return user; }
            }
            return null;
        }
    }
}
