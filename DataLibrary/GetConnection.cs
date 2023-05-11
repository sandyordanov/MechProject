using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public static class GetConnection
    {
        public static string Get
        {
            get
            {
                return @"Server = mssqlstud.fhict.local; Database = dbi505814; User Id = dbi505814; Password = Takethatcucumber123@;TrustServerCertificate=True";
            }  
        }

    }
}
