using Classes;
using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IUserDbController
    {
        bool RegisterUser(UserBindModel model);
        UserBindModel GetUserByUsername(string username);
        User GetUserById(int userId);
        bool UserHasCars(int userId);
        
    }
}
