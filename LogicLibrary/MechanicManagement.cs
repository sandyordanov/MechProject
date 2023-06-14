using Classes;
using DataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class MechanicManagement
    {
        private List<Mechanic> mechanics;
        private readonly IMechanicDbController _controller;
        public MechanicManagement(IMechanicDbController mechDbCon, int spId)
        {
            _controller = mechDbCon;
            mechanics = _controller.GetAllWorkersInAWorkshop(spId);
        }
        public string InsertMechanic(Mechanic mechanic, List<string> specs)
        {
            string username = mechanic.FirstName[0] + "." + mechanic.LastName.Substring(0, 4).ToLower();
            if (_controller.CheckIfUsernameIsFree(username))
            {
                mechanic.Username = username;
            }
            else
            {
                while (!_controller.CheckIfUsernameIsFree(username))
                {
                    Random rnd = new Random();
                    int num = rnd.Next(1, 10);
                    username += num.ToString();
                    mechanic.Username = username;
                }
            }
            mechanic.Password = BCrypt.Net.BCrypt.HashPassword(mechanic.Password);
            _controller.InsertMechanic(mechanic);

            int id = _controller.GetMechanicId(username);
            _controller.AddMechSpeciality(id, specs);
            return username;
        }
        public List<Mechanic> GetAllWorkersInAWorkshop(int spId)
        {
            List<Mechanic> list = _controller.GetAllWorkersInAWorkshop(spId);
            foreach (var mech in list)
            {
                mech.AddSkills(GetMechSpeciality(mech.Id));
            }
            return list;
        }
        public Mechanic GetMechById(int mechId)
        {
            Mechanic mech = _controller.GetMechById(mechId);
            mech.AddSkills(GetMechSpeciality(mechId));
            return mech;
        }
        public List<string> GetMechSpeciality(int mechId)
        {
            List<string> list = _controller.GetMechSpeciality(mechId);
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i].ToUpper();
            }
            return list;
        }

        public void DeleteMechanic(int mechId)
        {
            _controller.DeleteMechanic(mechId);
        }

        public void PromoteMech(int mechId, int value)
        {
            _controller.PromoteMech(mechId, value);
        }
    }
}
