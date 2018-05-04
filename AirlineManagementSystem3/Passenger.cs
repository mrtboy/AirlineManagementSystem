using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagementSystem3
{
    public class Passenger
    {
        public static List<Passenger> passengers = new List<Passenger>();
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Ticket> Tickets = new List<Ticket>();

        public Passenger() { }
        public Passenger(int id, string firstName, string lastName, string phoneNumber, Ticket tickets)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            Tickets.Add(tickets);
            passengers.Add(this);
        }

        public Passenger(int id, string firstName, string lastName, string phoneNumber)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            passengers.Add(this);
        }

        public virtual string GetInfo(int id)
        {
            foreach(Passenger passenger in passengers)
            {
                if (passenger.Id == id)
                {
                    string result = passenger.ToString() + "\n";
                    foreach (Ticket ticket in passenger.Tickets)
                    {
                        result += ticket.ToString();
                    }
                    return result;
                }
            }
            return "";
        }

        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + " Phone Numeber " + PhoneNumber;
        }
    }
}
