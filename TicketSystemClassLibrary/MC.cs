using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// Class that handles a MC
    /// </summary>
    public class MC: Vehicle
    {
        public int BrobizzDiscountAmount { get; set; } = 5;
        /// <summary>
        /// Price for a MC to travel through with or without BroBizz
        /// </summary>
        /// <returns>Price in DKK</returns>
        public override double Price(bool broBizz)
        {
            return broBizz ? 125 * (1 - (BrobizzDiscountAmount / 100.0)) : 125;
        }
        
        /// <summary>
        /// Specifies What kind of vehicle.
        /// </summary>
        /// <returns>The vehicle type as a string</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
