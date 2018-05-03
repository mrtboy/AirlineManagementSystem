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

        public EconomyPassenger(double luggageWight)
            :base()
        {
            this.LuggageWeight = luggageWight;

        }

        public EconomyPassenger() { }

        public override string GetInfo(int id)
        {
            return base.GetInfo(id);
        }
    }
}
