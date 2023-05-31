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
        private readonly IMechanicDbController _controller;
        public MechanicManagement(IMechanicDbController mechDbCon)
        {
            _controller = mechDbCon;
        }
    }
}
