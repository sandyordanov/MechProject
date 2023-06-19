using Classes;
using DataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class UsernameGenerator
    {
        private readonly IMechanicDbController _dbController;
        public  UsernameGenerator(IMechanicDbController mechController)
        {
            _dbController = mechController;
        }
        public string GenerateUsername(string firstName, string lastName)
        {
            string username = firstName[0] + "." + lastName.Substring(0, 4).ToLower();
            if (_dbController.CheckIfUsernameIsFree(username))
            {
                return username;
            }
            else
            {
                while (!_dbController.CheckIfUsernameIsFree(username))
                {
                    Random rnd = new Random();
                    int num = rnd.Next(1, 10);
                    username += num.ToString();                  
                }
            }
            return username;
        }
    }
}
