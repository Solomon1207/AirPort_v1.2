using AirPort.DTO;
using AirPort.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort
{
    class AirPortPasagire 
    {
        public bool Add(FlightPassengers NewPasagire,int FlightNumber)
        {
            return true;
        }

        public bool Delete(string PassportID, List<FlightPassengers> ListPangers)
        {
            var findIndex = ListPangers.FindIndex(arg => arg.Passport == PassportID);
            if (findIndex != null)
            {
                ListPangers.RemoveAt(findIndex);
                return true;
            }
            else
                return false;
        }

        public bool Edit(string PassportID, List<FlightPassengers> ListPangers)
        {
            /* var findItem = Find(PassportID, ListPangers);
             if (findItem != null)
             {

             }*/
            return true;
        }

        public FlightPassengers Find(string PassportID, List<FlightPassengers> ListPangers)
        {
            var findItem = ListPangers.Find(arg => arg.Passport == PassportID);
            if (findItem != null)
                return findItem;
            else
                return null;

        }
    }
}
