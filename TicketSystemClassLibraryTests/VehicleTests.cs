using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TicketSystemClassLibrary.Tests
{
    [TestClass()]
    public class VehicleTests
    {
        /// <summary>
        /// Making a private instance field so i dont have to make an Car, MC object for every test where i need them
        /// </summary>
        private Car _car = new();
        private MC _mc = new();

        // Car 
        [TestMethod()]
        public void PriceShouldReturn240_CarTest()
        {
            // Arrange
            double expected = 240;

            // Act
            double actual = _car.Price();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void VehicleTypeShouldReturnCar_CarTest()
        {
            // Arrange
            string expected = "Car";

            // Act
            string actual = _car.VehicleType();

            // Assert
            Assert.AreEqual(expected, actual);
        }


        // MC
        [TestMethod()]
        public void PriceShouldReturn125_MCTest()
        {
            // Arrange
            double expected = 125;

            // Act
            double actual = _mc.Price();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void VehicleTypeShouldReturnMC_MCTest()
        {
            // Arrange
            string expected = "MC";

            // Act
            string actual = _mc.VehicleType();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}