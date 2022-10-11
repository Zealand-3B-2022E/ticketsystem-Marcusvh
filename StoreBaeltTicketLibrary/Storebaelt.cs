using System.ComponentModel;
using TicketSystemClassLibrary;

namespace StoreBaeltTicketLibrary
{

    /// <summary>
    /// Class for Storebaelt's logic with cars
    /// </summary>
    public class Storebaelt: Car
    {
        private bool _brobizz;
        public bool Brobizz { 
            get { return _brobizz; }
            set { PriceForTicket = Price(value); 
            _brobizz = value;
            }
        }
        public double PriceForTicket { get; private set; }

        /// <summary>
        /// Method that calculates the price for a car to use the bridge. it handles weekend discount and brobizz
        /// </summary>
        /// <param name="broBizz">if the call should include brobizz or not</param>
        /// <returns>the price after the calculations</returns>
        public override double Price(bool broBizz)
        {
            double price = 240;
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
                price = 240 * (1 - (WeekendDiscountAmount / 100.0));

            if (broBizz)
                price = broBizz ? price * (1 - (BrobizzDiscountAmount / 100.0)) : 240;

            return price;
        }
    }
}