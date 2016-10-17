using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort.Interfaces
{
    interface IAirCraftPasagireManager<T>
    {
        bool Add(T NewPasagire);
        bool Edit(int FlightNumber, T EditedPasagire);
        bool Delete(int IDpasagire);
        T Find(int FlightNumber);
    }
}
