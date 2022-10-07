using TicketSystemClassLibrary;

namespace OresundBronTicketLibrary
{
    /// <summary>
    /// Class for Oresundbron's logic with cars
    /// </summary>
    public class OresundbronCar: Car
    {
        /// <summary>
        /// Method that calculates the price for a car to use the bridge. It handles brobizz discount
        /// </summary>
        /// <param name="broBizz">if the call should include brobizz or not</param>
        /// <returns>the price after the calculations</returns>
        public override double Price(bool broBizz)
        {
            return broBizz ? 161 : 410;
        }

        /// <summary>
        /// Method that returns the bridge name and what type the Vehicle is.
        /// </summary>
        /// <returns>string with bridge name and vehicle type</returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}