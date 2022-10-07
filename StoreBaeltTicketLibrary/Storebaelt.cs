using System.ComponentModel;
using TicketSystemClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class Storebaelt: Car // navngivning kunne godt være bedre for classen
    {
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