﻿using System;
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
        public string Licenseplate { 
            get { return Licenseplate; } 
            set {
                if (value == null)
                    throw new ArgumentNullException("You need to fill out the licenseplate");
                if (value.Length > 7)
                    throw new ArgumentOutOfRangeException("The licenseplate is to long. it may maximum be 7 characters");

                Licenseplate = value;
                }
        }
        public DateTime Date { get; set; }

        /// <summary>
        /// Price for a Vehicle to travel through
        /// </summary>
        /// <returns>Price in DKK</returns>
        public static double Price(double price, bool broBizz)
        {
            double broBizzDiscountAmount = 5;
            if(broBizz == true)
                return price -= price * (broBizzDiscountAmount / 100);
            else 
                return price;
        }

        /// <summary>
        /// Specifies What kind of vehicle.
        /// </summary>
        /// <returns>The vehicle type as a string</returns>
        public abstract string VehicleType();

    }
}
