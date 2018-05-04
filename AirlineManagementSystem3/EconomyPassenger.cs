using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagementSystem3
{
    public class EconomyPassenger : Passenger
    {
        public double LuggageWeight{ get; set; }

        public EconomyPassenger(int id, string firstName, string lastName, string phoneNumber, Ticket ticket, double luggageWight)
            :base(id, firstName,lastName, phoneNumber, ticket)
        {
            this.LuggageWeight = luggageWight;
        }

        public EconomyPassenger() { }

        public override string GetInfo(int id)
        {
            return base.GetInfo(id);
        }

        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + " Phone Numeber " + PhoneNumber + " Luggage Weight is " + LuggageWeight;
        }
    }
}
