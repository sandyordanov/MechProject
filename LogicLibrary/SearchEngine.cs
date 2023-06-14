using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public static class SearchEngine
    {
        public static List<ServicePoint> SearchForRepairShops(string search, List<ServicePoint> servicePoints)
        {
            List<string> keyWords = Regex.Split(search.ToLower(), @"[\s,\.]+").ToList();
            List<ServicePoint> AllservicePoints = servicePoints;
            List<ServicePoint> matchingShops = new List<ServicePoint>();
            foreach (string keyWord in keyWords)
            {
                foreach (ServicePoint servicePoint in AllservicePoints)
                {
                    if (servicePoint.Name.ToLower().Contains(keyWord) || servicePoint.Address.ToLower().Contains(keyWord))
                    {
                        if (!matchingShops.Contains(servicePoint))
                        {
                            matchingShops.Add(servicePoint);
                        }
                    }
                }
            }
            return matchingShops;
        }

        public static List<Mechanic> SearchForMechanics(string search, List<Mechanic> mechanics)
        {
            List<string> keyWords = Regex.Split(search.ToLower(), @"[\s,\.]+").ToList();
            List<Mechanic> allMechs = mechanics;
            List<Mechanic> matchingMechs = new List<Mechanic>();
            foreach (string keyWord in keyWords)
            {
                foreach (var mech in allMechs)
                {
                    if (mech.FirstName.ToLower().Contains(keyWord) || mech.LastName.ToLower().Contains(keyWord))
                    {
                        if (!matchingMechs.Contains(mech))
                        {
                            matchingMechs.Add(mech);
                        }
                    }
                }
            }
            return matchingMechs;
        }
    }
}
