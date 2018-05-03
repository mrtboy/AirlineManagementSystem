using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagementSystem3
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int PassengerId { get; set; }
        public Flight _Flight { get; set; }
        public decimal Price { get; set; }
        private decimal extraTax;

        public decimal ExtraTax
        {
            get { return extraTax; }
            set {
                DateTime dateTime = new DateTime();
                if(dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday)
                {
                    extraTax = 5;
                }
                else
                {
                    extraTax = 7;
                }
            }
        }


        public Ticket() { }

        public decimal GetPrice(int ticketId)
        {
            decimal calculatedPrice = ticketId * (ExtraTax/100);
            return calculatedPrice;
        }

        public string GetPassengetFlightInfo(Passenger[] passengers)
        {

            return null;
        }

    }
}
