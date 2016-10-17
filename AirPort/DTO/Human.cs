using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort.DTO
{
    class Human
    {
        private int ID = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Male { get; set; }
        public DateTime BirthDay { get; set; }
        public string Passport { get; set; }
    }
}
