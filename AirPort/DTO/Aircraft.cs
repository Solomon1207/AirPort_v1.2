using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort.DTO
{
    class Aircraft
    {
        public int Flight_number { get; set; }
        public int Terminal { get; set; }
        public int Gate { get; set; }
        public int Cost { get; set; }// temporary
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime  { get; set; }
        public string ArrivalCity { get; set; }
        public string DepartureCity { get; set; }
        public FlightStatus Status { get; set; }
        public List<FlightPassengers> Passengers { get; set; }

    }
}
