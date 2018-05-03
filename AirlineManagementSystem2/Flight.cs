using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagementSystem2
{
    public delegate void FlightMessageDelegate(decimal price, Flight flight);
    public class Flight
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }

        public Flight(int id, string origin, string destination, DateTime date, decimal price)
        {
            this.Id = id;
            this.Origin = origin;
            this.Destination = destination;
            this.Date = date;
            this.Price = price;
        }

        public override string ToString()
        {
            string result = "Flight with id " + Id + " from " + Origin + " To " + Destination + " Date " + Date + " Price " + Price;
            return result;
        }

        public Flight FindFlight(int id)
        {
            if (this != null)
            {
                return this;
            }
            return null;
        }

        internal static void FullFlightData(decimal price, Flight flight)
        {
            Console.WriteLine("Flight id" + flight.Id + " From " + flight.Origin + " to " + flight.Destination + " Date " + flight.Date +
                " Price " + flight.Price);
        }

        internal static void GetDestination(decimal price, Flight flight)
        {
            Console.WriteLine("Destination for flight num " + flight.Id + " is " + flight.Destination);
        }

        internal static void OnlyOrigin(decimal price, Flight flight)
        {
            Console.WriteLine("Flight Origin is " + flight.Origin);
        }
    }
}
