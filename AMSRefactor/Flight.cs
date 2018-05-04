using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSRefactor
{
    public class Flight
    {        
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
        }

        public override string ToString()
        {
            string result = "Flight with id " + Id + " from " + Origin + " To " +
                Destination + " Date " + Date ;
            return result;
        }
    }
}
