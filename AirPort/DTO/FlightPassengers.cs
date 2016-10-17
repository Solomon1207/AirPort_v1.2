using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort.DTO
{
    class FlightPassengers : Human
    {
        public int Seat_number { get; set; }
        public int Flight_number { get; set; }
        public FlightStatus Flight_Class { get; set; }
    }
}
