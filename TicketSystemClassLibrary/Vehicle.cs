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
        private string _lp; // note: den vil ikke løbe mine test igennem hvis jeg retunere propertien selv.
        /// <summary>
        /// returns the licenseplate of a vehicle. it will throw an exception if the value is null and if the amount of characters if above 7.
        /// </summary>
        /// <exception cref="ArgumentNullException">if value is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">if value is above 7</exception>
        public string Licenseplate { 
            get { return _lp; } 
            set {
                if (value == null)
                    throw new ArgumentNullException("You need to fill out the licenseplate");
                if (value.Length > 7)
                    throw new ArgumentOutOfRangeException("The licenseplate is to long. it may maximum be 7 characters");

                _lp = value;
                }
        }
        /// <summary>
        /// returns the datetime of when the vehicle is called.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Price for a Vehicle to travel through
        /// </summary>
        /// <returns>Price in DKK</returns>
        public abstract double Price(bool brobizz);
        

        /// <summary>
        /// Specifies What kind of vehicle.
        /// </summary>
        /// <returns>The vehicle type as a string</returns>
        public abstract string VehicleType();

    }
}
