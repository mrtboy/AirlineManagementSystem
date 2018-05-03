using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Flight flight2 = new Flight(2, "Ir", "Spaing", DateTime.Now, 44);
            Flight flight3 = new Flight(3, "USA", "UK", DateTime.Now, 87);

            AirlineCompany airlineCompany = new AirlineCompany("German Airline");

            airlineCompany[2] = flight2;

            Console.WriteLine(airlineCompany[5]);
            
        }
    }
}
