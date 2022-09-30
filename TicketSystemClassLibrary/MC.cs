using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// Class that handles a MC
    /// </summary>
    public class MC
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }


        /// <summary>
        /// Price for a MC to travel through
        /// </summary>
        /// <returns>Price in DKK</returns>
        public double Price()
        {
            return 125;
        }

        /// <summary>
        /// Specifies What kind of vehicle.
        /// </summary>
        /// <returns>The vehicle type as a string</returns>
        public string VehicleType()
        {
            return "MC";
        }
    }
}
