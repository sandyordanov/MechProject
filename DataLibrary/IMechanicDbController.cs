using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IMechanicDbController
    {
        void InsertMechanic(Mechanic mechanic);
        List<Mechanic> GetAllWorkersInAWorkshop(int spId);
        Mechanic GetMechById(int mechId);
        void AddMechSpeciality(int mechId, List<string> strings);
        List<string> GetMechSpeciality(int mechId);
        bool CheckIfUsernameIsFree(string username);
        int GetMechanicId(string username);
        void DeleteMechanic(int mechId);
        void PromoteMech(int mechId, int value);
    }
}
