using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagementSystem2
{
    public class AirlineCompany
    {
        readonly private string airlineName;
        readonly private List<Flight> flights = new List<Flight>();

        public AirlineCompany(string airlineName)
        {
            this.airlineName = airlineName;
        }
        public AirlineCompany()
        {

        }

        public Flight this[int index]
        {
            get
            {
                foreach (Flight flight in flights)
                {
                    if (flight.FindFlight(index) != null)
                    {
                        return flight;
                    }
                }
                return null;
            }
            set
            {
                flights.Add(value);
            }
        }
    }
}
