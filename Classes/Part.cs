using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Part
    {
        private FunctioningLevel functioningLevel;
        private FromSystem systemType;

        public string Repair()
        {
            functioningLevel -= 1;
            return $"{systemType} repaired to level {functioningLevel}.";
        }
        public string Change()
        {
            functioningLevel = 0;
            return $"{systemType} replaced.";
        }
    }
}
