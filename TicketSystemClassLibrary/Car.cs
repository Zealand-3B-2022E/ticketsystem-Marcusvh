using System.Diagnostics;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// Class that handles a Car
    /// </summary>
    public class Car: Vehicle
    {
        /// <summary>
        /// sets the brobizz discount amount in percent. 5 would be 5 percent 
        /// </summary>
        protected int BrobizzDiscountAmount { get; set; } = 5;
        /// <summary>
        /// sets the weekend discount amount in percent. 20 would be 20 percent
        /// </summary>
        protected int WeekendDiscountAmount { get; set; } = 20;

        /// <summary>
        /// Price for a car to travel through with or without BroBizz
        /// </summary>
        /// <returns>Price in DKK</returns>
        public override double Price(bool broBizz)
        {
            return broBizz ? 240 * (1 - (BrobizzDiscountAmount / 100.0)) : 240;
        }

        /// <summary>
        /// Specifies What kind of vehicle.
        /// </summary>
        /// <returns>The vehicle type as a string</returns>
        public override string VehicleType()
        {
            return "Car";
        } 



    }
}