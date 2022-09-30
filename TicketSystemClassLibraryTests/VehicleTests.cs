﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        private Car car = new();
        private MC mc = new();

        // Car 
        [TestMethod()]
        public void Price_ShouldReturn240_CarTest()
        {
            // Arrange
            double expected = 240;

            // Act
            double actual = car.Price();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void VehicleType_ShouldReturnCar_CarTest()
        {
            // Arrange
            string expected = "Car";
            
            // Act
            string actual = car.VehicleType();

            // Assert
            Assert.AreEqual(expected, actual);
        }


        // MC
        [TestMethod()]
        public void Price_ShouldReturn125_MCTest()
        {
            // Arrange
            double expected = 125;

            // Act
            double actual = mc.Price();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void VehicleType_ShouldReturnMC_MCTest()
        {
            // Arrange
            string expected = "MC";

            // Act
            string actual = mc.VehicleType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow("")]
        [DataRow("d")]
        [DataRow("DK 25")]
        [DataRow("DK 2567")]
        public void LicensePlateMayNotBeLongerThen7Characters_ShouldBeSuccess_MCTest(string LPlate)
        {
            // Arrange


            // Act
            mc.Licenseplate = LPlate;

            // Assert
            Assert.IsTrue(7 >= mc.Licenseplate.Length);
        }
        [TestMethod()]
        [DataRow(null)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LicensePlateMayNotBeLongerThen7Characters_ShouldThrowNullException_MCTest(string LPlate)
        {
            // Arrange


            // Act
            mc.Licenseplate = LPlate;

            // Assert
            Assert.Fail();
        }
        [TestMethod()]
        [DataRow(null)]
        [DataRow("DK 25678")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LicensePlateMayNotBeLongerThen7Characters_ShouldThrowOutOfRangeException_MCTest(string LPlate)
        {
            // Arrange


            // Act
            mc.Licenseplate = LPlate;

            // Assert
            Assert.Fail();
        }
    }
}