using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirPort.Interfaces;
using AirPort.DTO;


namespace AirPort
{
    class Airport : IAirCraftManager<Aircraft, FlightPassengers>
    {
        public List<Aircraft> ListAircraft { get; private set; } = new List<Aircraft>();
        public Airport()
        {
            ListAircraft.Add(new Aircraft() { Flight_number = 1, ArrivalCity = "test2", ArrivalTime = DateTime.Now, Cost = 15, DepartureCity = "test", DepartureTime = DateTime.Now, Gate = 1, Passengers = new List<FlightPassengers>(), Status = FlightStatus.Arrived, Terminal = 1 });
            ListAircraft.Add(new Aircraft() { Flight_number = 2, ArrivalCity = "test3", ArrivalTime = DateTime.Now, Cost = 15, DepartureCity = "test4", DepartureTime = DateTime.Now, Gate = 2, Passengers = new List<FlightPassengers>(), Status = FlightStatus.Arrived, Terminal = 2 });
        }

        public bool Add(Aircraft FlightNumber)
        {
            if (ListAircraft == null)
                return false;

                ListAircraft.Add(FlightNumber);
                return true;
            
        }

        public bool Delete(int FlightNumber)
        {
            try
            {
                int index = -1;
                index = ListAircraft.FindIndex(arg => arg.Flight_number == FlightNumber);
                if (index > 0)
                {
                    ListAircraft.RemoveAt(index);
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(int FlightNumber, Aircraft EditedAircraft)
        {
            try
            {
                int index = -1;
                index = ListAircraft.FindIndex(arg => arg.Flight_number == FlightNumber);
                if (index < 0)
                    return false;

                ListAircraft[index] = EditedAircraft;
                return true;
            }
            catch
            {
                return false;
            }

        }

        public Aircraft Find(int FlightNumber)
        {
            var FlightItem = ListAircraft.Find(arg => arg.Flight_number == FlightNumber);
            return FlightItem != null ? FlightItem : null;
        }

        public bool FindPassenger(string FirstName, string LastName)
        {
            throw new NotImplementedException();
        }

        public bool EditPassenger(int NumberPassenger, FlightPassengers EditedPass)
        {
            throw new NotImplementedException();
        }
    }
}
