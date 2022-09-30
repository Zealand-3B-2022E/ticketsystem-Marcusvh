﻿using System;
using System.Collections.Generic;
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
        /// <summary>
        /// Price for a MC to travel through with or without BroBizz
        /// </summary>
        /// <returns>Price in DKK</returns>
        public double Price(bool broBizz)
        {
            return Vehicle.Price(125, broBizz);
        }
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
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
