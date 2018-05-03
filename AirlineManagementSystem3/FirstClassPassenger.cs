using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagementSystem3
{
    public class FirstClassPassenger : EconomyPassenger
    {
        public int Bonus { get; set; }
        public string MealMenu { get; set; }
        public FirstClassPassenger() { }
        public FirstClassPassenger(string mealMenu)
            : base()
        {
            this.MealMenu = mealMenu;
        }

        public override string GetInfo(int id)
        {
            return base.GetInfo(id);
        }
    }
}
