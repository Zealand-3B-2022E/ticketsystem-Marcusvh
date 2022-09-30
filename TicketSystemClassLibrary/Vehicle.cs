using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// Base class for Vehicle. The class is abstract
    /// </summary>
    public abstract class Vehicle
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }


        /// <summary>
        /// Price for a Vehicle to travel through
        /// </summary>
        /// <returns>Price in DKK</returns>
        public abstract double Price();

        /// <summary>
        /// Specifies What kind of vehicle.
        /// </summary>
        /// <returns>The vehicle type as a string</returns>
        public abstract string VehicleType();

    }
}
