using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagementSystem
{
    public class AirlineCompany
    {
        readonly  string airlineName;
        readonly  List<Flight> flights = new List<Flight>();

        public AirlineCompany(string airlineName)
        {
            this.airlineName = airlineName;
        }
        public AirlineCompany()
        {
            
        }

        public Flight this[int flightId]
        {
            get {
                foreach(Flight flight in flights)
                {
                    if(flight.FindFlight(flightId) != null)
                    {
                        return flight;
                    }
                }
                return null;
            }
            set {
                flights.Add(value);
            }
        }
        

    }
}
