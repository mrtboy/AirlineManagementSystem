using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagementSystem3
{
    public class FirstClassPassenger : EconomyPassenger
    {
        public decimal Bonus { get; }

        public string MealMenu { get; set; }
        public FirstClassPassenger() { }
        public FirstClassPassenger(int id, string firstName, string lastName, string phoneNumber, double luggageWight, Ticket ticket,string mealMenu)
            : base(id, firstName, lastName, phoneNumber, ticket, luggageWight)
        {
            this.MealMenu = mealMenu;
            Bonus = calculateBonus();
        }

        public override string GetInfo(int id)
        {
            return base.GetInfo(id);
        }

        public decimal calculateBonus()
        {
            decimal total = 0;
            decimal bonus = 0;
            foreach (Ticket ticket in Ticket.tickets)
            {
                if (Ticket.tickets != null)
                {
                    decimal price = ticket.Price;
                    bonus = (2m / 100m);
                    total = price * bonus;
                    return total;
                }
                return 0;
            }
            return 0;
        }

        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + " Phone Numeber " + PhoneNumber + 
                " Luggage Weight is " + LuggageWeight + " Meal Menu is " + MealMenu + " Bonus is " +Bonus;
        }
    }
}
