using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagementSystem3
{
    public abstract class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Ticket> Tickets { get; set; }

        public Passenger() { }
        public Passenger(int id, string firstName, string lastName, string phoneNumber, List<Ticket> tickets)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Tickets = tickets;
        }

        public virtual string GetInfo(int id)
        {
            return "";
        }
    }
}
