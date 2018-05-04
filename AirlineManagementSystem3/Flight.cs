using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagementSystem3
{
    public class Flight
    {
        private static ArrayList FlightList = new ArrayList();
        
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }

        public Flight(int id, string origin, string destination, DateTime date)
        {
            this.Id = id;
            this.Origin = origin;
            this.Destination = destination;
            this.Date = date;
            FlightList.Add(this);
        }

        public override string ToString()
        {
            string result = "Flight with id " + Id + " from " + Origin + " To " + Destination + " Date " + Date ;
            return result;
        }

        //public Flight FindFlight(int id)
        //{
        //    if (this != null && Id == id)
        //    {
        //        return this;
        //    }
        //    return null;
        //}

        public static Flight FindFlight(int id)
        {
            foreach(Flight flight in FlightList)
            {
                if(flight.Id == id)
                {
                    return flight;
                }
            }
            return null;
        }
    }
}
