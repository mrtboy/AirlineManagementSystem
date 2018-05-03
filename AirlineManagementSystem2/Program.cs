using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagementSystem2
{
    class Program
    {
        static void Main(string[] args)
        {

            FlightMessageDelegate getDestinationDelegate = new FlightMessageDelegate(Flight.GetDestination);
            FlightMessageDelegate fullFlightDataDelegate = new FlightMessageDelegate(Flight.FullFlightData);
            FlightMessageDelegate onlyOriginDelegate = new FlightMessageDelegate(Flight.OnlyOrigin);

            Flight flight2 = new Flight(2, "Ir", "Spaing", DateTime.Now, 44);
            Flight flight3 = new Flight(3, "USA", "UK", DateTime.Now, 87);

            AirlineCompany airlineCompany = new AirlineCompany("German Airline");

            airlineCompany[2] = flight2;
            airlineCompany[3] = flight3;

            int id = 2;
            Console.WriteLine("Enter your Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            if (price < airlineCompany[id].Price)
            {
                getDestinationDelegate(price, airlineCompany[id]);
            }
            else if (price > airlineCompany[id].Price)
            {
                fullFlightDataDelegate(price, airlineCompany[id]);
            }
            else
            {
                onlyOriginDelegate(price, airlineCompany[id]);
            }
        }
       
    }
 }
