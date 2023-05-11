using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class User
    {
        public UserType position { get; set; }

        public User(string username, string password, UserType pos)
        {
            Email = username;
            Password = password;
            this.position = pos;
        }
        public User()
        {
            
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
