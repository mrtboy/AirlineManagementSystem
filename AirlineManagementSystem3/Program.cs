using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagementSystem3
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Flights Collections
            Flight flight1 = new Flight(1, "De", "It", DateTime.Now);
            Flight flight2 = new Flight(2, "Ir", "Sp", DateTime.Now);
            Flight flight3 = new Flight(3, "US", "UK", DateTime.Now);
            Flight flight4 = new Flight(4, "Pa", "In", DateTime.Now);
            Flight flight5 = new Flight(5, "Eu", "Si", DateTime.Now);
            #endregion

            #region Get Flight Information
            Console.WriteLine("Get Flight Informations");
            Console.WriteLine(Flight.FindFlight(1));
            Console.WriteLine(Flight.FindFlight(2));
            Console.WriteLine(Flight.FindFlight(3));
            Console.WriteLine(Flight.FindFlight(4));
            Console.WriteLine(Flight.FindFlight(5));
            Console.WriteLine(Flight.FindFlight(6));
            #endregion

            #region Tickets Collections
            Ticket ticket1 = new Ticket(1, 1, flight1, 2000);
            Ticket ticket2 = new Ticket(2, 2, flight2, 2500);
            Ticket ticket3 = new Ticket(3, 3, flight3, 1200);
            Ticket ticket4 = new Ticket(4, 4, flight5, 2223);
            Ticket ticket5 = new Ticket(5, 5, flight4, 1003);
            Ticket ticket6 = new Ticket(6, 6, flight5, 3222);
            Ticket ticket7 = new Ticket(7, 7, flight3, 3333);
            Ticket ticket8 = new Ticket(8, 8, flight4, 1111);
            #endregion

            #region GetPrice from ticket by including extra tax 
            Console.WriteLine("Get Ticket Price");
            Console.WriteLine("Get Ticket Price for Ticket Number 1: "+ Ticket.GetPrice(1));
            Console.WriteLine("Get Ticket Price for Ticket Number 2: " + Ticket.GetPrice(2));
            #endregion

            #region Economy Passengers Collection
            EconomyPassenger economy1 = new EconomyPassenger(1, "Reza", "Taleghani", "01998383",ticket1, 20.30);
            EconomyPassenger economy2 = new EconomyPassenger(2, "Ali", "Muller", "432435235",ticket2, 12.30);
            EconomyPassenger economy3 = new EconomyPassenger(3, "Gholi", "Khojaste", "234234324",ticket3, 40.30);
            EconomyPassenger economy4 = new EconomyPassenger(4, "Alex", "Raha", "456456546",ticket4, 30.30);
            EconomyPassenger economy5 = new EconomyPassenger(5, "Ahmad", "Rohani", "45645654",ticket5, 43.30);
            #endregion

            #region Firstclass Passengers Collection
            FirstClassPassenger firstClass1 = new FirstClassPassenger(6, "Jahn", "hoood", "454345",33.30,ticket6,"Ghorme Sanzi");
            FirstClassPassenger firstClass2 = new FirstClassPassenger(7, "Jak", "Lood", "34564356", 43.30,ticket7, "Kabab");
            FirstClassPassenger firstClass3 = new FirstClassPassenger(8, "Michel", "Obama", "345645", 23.30, ticket8,"Omlet");
            #endregion

            #region Get Passenger and related flight informations with Ticket Price
            Console.WriteLine();
            Console.WriteLine("Get Passenget and flight informations with price");
            Ticket.GetPassengerFlightInfo(Passenger.passengers);
            #endregion

            #region GetInfo Passenger and her/his ticket Information
            Console.WriteLine();
            Console.WriteLine("GetInfo() Passenger and her/his ticket Information");
            Console.WriteLine(firstClass1.GetInfo(7));
            Console.WriteLine(economy1.GetInfo(2));
            #endregion


        }
    }
}
