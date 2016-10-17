using AirPort.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort.Interfaces
{
    public interface IAirCraftManager<T,S>
    {
        bool Add(T NewAircraft);
        bool Edit(int FlightNumber, T EditedAircraft);
        bool Delete(int FlightNumber);
        T Find(int FlightNumber);
        bool FindPassenger(string FirstName, string LastName);
        bool EditPassenger(int NumberPassenger, S EditedPass);

    }
}
