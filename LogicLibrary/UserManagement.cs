using Classes;
using Classes.Models;
using DataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class UserManagement
    {
        private readonly IUserDbController _dbController;
        public UserManagement(IUserDbController userDbController)
        {
            _dbController = userDbController;
        }

        public bool RegisterUser(UserBindModel model)
        {
            return _dbController.RegisterUser(model);
        }
        public int ValidateUser(Login model)
        {
            string username = model.Username;
            UserBindModel user = _dbController.GetUserByUsername(username);
            bool isMaching = BCrypt.Net.BCrypt.Verify(model.Password,user.Password);
            if (isMaching)
            {
                return user.Id;
            }
            else
            {
                return 0;
            }
        }
        public User GetUserById(int id)
        {
            return _dbController.GetUserById(id);
        }
        public bool HasCars(int userId) 
        {
            return _dbController.UserHasCars(userId);
        }
    }
}
