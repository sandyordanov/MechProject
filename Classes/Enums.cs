using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum MechLevel
    {
        Apprentice,
        Regular,
        Master
    }
    public enum UserType
    {
        CarOwner,
        Mechanic,
        ServicePoint
    }
    public enum FunctioningLevel
    {
        FullyWorking,
        SemiWorking,
        NeedsReplacement,
        Faulty
    }
    public enum FromSystem
    {
        Engine,
        Brakes,
        Suspension,
        Body,
        Fuel
    }
    public enum Maintenance
    {
        OilChange,
        AirFilterChange,
        LighBulbChange,
        TyreChange,
        CoolantChange,
        WaxVehicle,
        Inspection
    }
}
