using AirPort.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort
{
    static class AirPortPasagireConsolUI
    {
        public static FlightPassengers Add()
        {
            FlightPassengers item = new FlightPassengers();
            try {
                Console.WriteLine("FirstName");
                item.FirstName = Console.ReadLine();
                Console.WriteLine("LastName");
                item.LastName = Console.ReadLine();
                Console.WriteLine("Male");
                item.Male = Console.ReadLine();
                Console.WriteLine("BirthDay");
                item.BirthDay = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Passport");
                item.Passport = Console.ReadLine();
                Console.WriteLine("Seat_number");
                item.Seat_number = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Flight_number");
                item.Flight_number = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Flight_Class");
                item.Flight_Class = FlightStatus.Arrived;
            } catch (Exception ex)
            {
                return null;
            }
            return item;
        }

        public static void Delete()
        {
            Console.WriteLine("Please Enter pasport or ID pasagire");
            var value = Console.ReadLine();
            if (true)
            {

            }
            else
            {

            }

        }

        internal static FlightPassengers Edit(FlightPassengers item)
        {
            try
            {
                Console.WriteLine("FirstName");
                item.FirstName = Console.ReadLine();
                Console.WriteLine("LastName");
                item.LastName = Console.ReadLine();
                Console.WriteLine("Male");
                item.Male = Console.ReadLine();
                Console.WriteLine("BirthDay");
                item.BirthDay = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Passport");
                item.Passport = Console.ReadLine();
                Console.WriteLine("Seat_number");
                item.Seat_number = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Flight_number");
                item.Flight_number = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Flight_Class");
                item.Flight_Class = FlightStatus.Arrived;
            }
            catch (Exception ex)
            {
                return null;
            }
            return item;
        }

        public static void ShowAllFlight()
        {
            
        }

        public static void Show(Aircraft FindItem)
        {
            string OutString = string.Format("{0}||{1}||{2}||{3}||{4}||{5}||"
                , Utils.Utils.TrimValueOrConcatSpace(FindItem.Flight_number.ToString(), 15)
                , Utils.Utils.TrimValueOrConcatSpace(FindItem.ArrivalCity, 15)
                , Utils.Utils.TrimValueOrConcatSpace(FindItem.DepartureCity, 15)
                , Utils.Utils.TrimValueOrConcatSpace(FindItem.ArrivalTime.ToString(), 15)
                , Utils.Utils.TrimValueOrConcatSpace(FindItem.DepartureTime.ToString(), 15)
                , Utils.Utils.TrimValueOrConcatSpace(FindItem.Status.ToString(), 15));

            Console.WriteLine(OutString);
        }
        public static void ShowMenu()
        {
            Console.Clear();
            string MenuString = string.Format("Flight_number  || ArrivalCity   || DepartureCity || ArrivalTime   || DepartureCity || Status        ||");
            Console.WriteLine(MenuString);
        }
    }
}
