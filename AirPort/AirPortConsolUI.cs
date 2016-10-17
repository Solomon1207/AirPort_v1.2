using AirPort.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirPort.Utils;


namespace AirPort
{
    class AirPortConsolUI
    {
        Airport AirportItem;
        public AirPortConsolUI()
        {
            Console.WindowWidth = 140;
            AirportItem = new Airport();
            //Add();
            ShowAllFlight();
            AddPasagire();

        }

        private void AddPasagire()
        {
            Console.WriteLine("Please enter Flight_number : ");
            var FlightNumber = int.Parse(Console.ReadLine());
            var FindItem = AirportItem.Find(FlightNumber);
            if (FindItem != null)
            {
                FindItem.Passengers.Add(AirPortPasagireConsolUI.Add());
            }
            else
            {
                Console.WriteLine("Flight_number not fount pleace try again");
            }
        }

        private void EditPasagire()
        {
            Console.WriteLine("Please enter Flight_number : ");
            var FlightNumber = int.Parse(Console.ReadLine());
            var FindItem = AirportItem.Find(FlightNumber);
            if (FindItem != null)
            {
                Console.WriteLine("Please enter PassportID pasagire :");
                var id = Console.ReadLine();
                var index = FindItem.Passengers.FindIndex(arg => arg.Passport == id);
                if (index > 0)
                {
                    var item = AirPortPasagireConsolUI.Edit(FindItem.Passengers[index]);
                    FindItem.Passengers[index] = item;

                }
                else
                    Console.WriteLine("passagire not found");
            }
            else
            {
                Console.WriteLine("Flight_number not fount pleace try again");
            }
        }

        private void DeletePasagire()
        {
            Console.WriteLine("Please enter Flight_number : ");
            var FlightNumber = int.Parse(Console.ReadLine());
            var FindItem = AirportItem.Find(FlightNumber);
            if (FindItem != null)
            {
                Console.WriteLine("Please enter PassportID pasagire :");
                var id = Console.ReadLine();
                var index = FindItem.Passengers.FindIndex(arg => arg.Passport == id);
                if (index > 0)
                {
                    FindItem.Passengers.RemoveAt(index);

                }
                else
                    Console.WriteLine("passagire not found");
            }
            else
            {
                Console.WriteLine("Flight_number not fount pleace try again");
            }
        }

        public void Add()
        {
            Console.Clear();
            Aircraft AircraftItem = new Aircraft();
            Console.Write("please enter  Flight_number : ");
            AircraftItem.Flight_number = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter  Terminal : ");
            AircraftItem.Terminal = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter  Gate : ");
            AircraftItem.Gate = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter  Cost : ");
            AircraftItem.Cost = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter  ArrivalTime in format Y,M,D, H, M, S :: ");
            AircraftItem.ArrivalTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("please enter  DepartureTime in format Y,M,D, H, M, S :: ");
            AircraftItem.DepartureTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("please enter  ArrivalCity : ");
            AircraftItem.ArrivalCity = Console.ReadLine();
            Console.WriteLine("please enter  DepartureCity : ");
            AircraftItem.DepartureCity = Console.ReadLine();
            AircraftItem.Status = FlightStatus.Arrived;
            AircraftItem.Passengers = new List<FlightPassengers>();

            AirportItem.Add(AircraftItem);

        }

        public void Delete(int FlightNumber)
        {
            Console.Clear();

            Console.WriteLine("Please enter Flight number");
            int NumberForDelete = int.Parse(Console.ReadLine());
            var findItem = AirportItem.Find(NumberForDelete);
            if (findItem != null)
            {
                AirportItem.Delete(NumberForDelete);
            }
            else
            {
                Console.WriteLine("Flight not found");
            }

        }

        public void Edit(int FlightNumber)
        {
            Console.Clear();
            var FindItem = AirportItem.Find(FlightNumber);
            if (FindItem != null)
            {
                ShowMenu();
                ShowFlight(FindItem);
            }
            else
            {
                Console.WriteLine("Flight not found");
            }

        }

        public void Find(int FlightNumber)
        {
            var FindItem = AirportItem.Find(FlightNumber);
            if (FindItem != null)
            {
                ShowMenu();
                ShowFlight(FindItem);
            }
            else
            {
                Console.WriteLine("Flight not found");
            }
        }

        public void ShowAllFlight()
        {
            ShowMenu();
            foreach (var item in AirportItem.ListAircraft)
            {
                ShowFlight(item);

            }
        }

        public void ShowFlight(Aircraft FindItem)
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
        public void ShowMenu()
        {
            Console.Clear();
            string MenuString = string.Format("Flight_number  || ArrivalCity   || DepartureCity || ArrivalTime   || DepartureCity || Status        ||");
            Console.WriteLine(MenuString);
        }
    }

}
