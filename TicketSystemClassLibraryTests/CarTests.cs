using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Tests
{
    [TestClass()]
    public class CarTests
    {
        /// <summary>
        /// Making a private instance field so i dont have to make an Car object for every test
        /// </summary>
        private Car car;


        [TestMethod()]
        public void PriceShouldReturn240_CarTest()
        {
            // Arrange
            double expected = 240;

            // Act
            double actual = car.Price();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void VehicleTypeShouldReturnCar_CarTest()
        {
            // Arrange
            string expected = "Car";

            // Act
            string actual = car.VehicleType();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}