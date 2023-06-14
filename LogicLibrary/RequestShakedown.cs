using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public static class RequestShakedown
    {
        public static List<string> ScrapeRequest(string make, string description)
        {
            List<string> result = Regex.Split(description.ToLower(), @"[\s,\.]+", (RegexOptions)StringSplitOptions.RemoveEmptyEntries).ToList();
            result.Add(make);
            return result;

        }
        public static Dictionary<Mechanic, List<string>> SearchForAMatch(List<Mechanic> mechanics, List<string> keyWords)
        {
            var result = new Dictionary<Mechanic, List<string>>();
            List<string> matching = new List<string>();

            foreach (var mechanic in mechanics)
            {
                matching = new List<string>();
                foreach (var skill in mechanic.Skills)
                {
                    foreach (var keyWord in keyWords)
                    {
                        if (skill.ToLower() == keyWord)
                        {
                            matching.Add(keyWord);
                        }
                    }
                }
                if (matching.Count > 0)
                {
                    result.Add(mechanic, matching);
                }
            }
            result.OrderByDescending(x => x.Value.Count);
            return result;
        }

    }
}
