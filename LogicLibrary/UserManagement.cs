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
        public int ValidateUser(string username, string password, string type)
        {
            IdAndPassword props = _dbController.GetIdAndPasswordByUsername(username, type);
            if (props != null)
            {
                bool isMaching = BCrypt.Net.BCrypt.Verify(password, props.HashPassword);
                if (isMaching)
                {
                    return props.Id;
                }
            }
            return 0;
        }
        public User GetUserById(int id)
        {
            return _dbController.GetUserById(id);
        }
        public bool HasCars(int userId)
        {
            return _dbController.UserHasCars(userId);
        }
        public bool IsUsernameFree(string username, string userType)
        {
            return _dbController.IsUsernameFree(username, userType);
        }
        public void UpdateUserDetails(int userId, User model)
        {
            _dbController.UpdateUserDetails(userId, model);
        }
        public void DeleteUser(int userId)
        {
            _dbController.DeleteUser(userId);
        }
    }
}
