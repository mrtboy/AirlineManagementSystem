using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AirlineManagementSystem3
{
    public class Ticket
    {
        public static List<Ticket> tickets = new List<Ticket>();
        public int TicketId { get; set; }
        public int PassengerId { get; set; }
        public Flight _Flight { get; set; }
        public decimal Price { get; set; }
        public int ExtraTax { get; }

        public Ticket() { }
        public Ticket(int ticketId, int passengerId, Flight flight, decimal price)
        {
            this.TicketId = ticketId;
            this.PassengerId = passengerId;
            this._Flight = flight;
            this.Price = price;
            this.ExtraTax = getExtraTax();
            tickets.Add(this);
        }

        private int getExtraTax()
        {
            DateTime dateTime = new DateTime();
            if (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                return 5;
            }
            else
            {
                return 7;
            }
        }

        public static decimal GetPrice(int ticketId)
        {
            decimal calculatedTax = 0;
            decimal total = 0;
            foreach (Ticket ticket in tickets)
            {
                if(ticket.TicketId == ticketId)
                {
                    decimal price = ticket.Price;
                    decimal tax = ticket.ExtraTax;
                    calculatedTax = (price * (tax / 100));
                    total = price + calculatedTax;
                    return total;
                }
            }
            return total;
            
        }

        public static string GetPassengerFlightInfo(List<Passenger> passengers)
        {
            foreach(Passenger passenger in passengers)
            {
                Console.WriteLine(passenger.Id + " " + passenger.FirstName + " " + passenger.LastName + " " +
                    passenger.PhoneNumber + " Ticket Informations ===> " + Ticket.tickets.FirstOrDefault(t => t.PassengerId == passenger.Id) + " ===  Ticket price ==> " +
                    Ticket.GetPrice(Ticket.tickets.FirstOrDefault(t => t.PassengerId == passenger.Id).TicketId));
            }
            return null;
        }

        public override string ToString()
        {
            return "Ticket Id " + TicketId + " Passenger Id " + PassengerId + " Flight Info " + _Flight.Id + " Price " + Price;
        }

    }
}
