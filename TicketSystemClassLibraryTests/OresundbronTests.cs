using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBronTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace OresundBronTicketLibrary.Tests
{
    [TestClass()]
    public class OresundbronTests
    {
        private OresundbronCar oCar = new();
        private OresundbronMC oMC = new();

        // Car
        [TestMethod()]
        public void PriceWithoutBrobizz_ShouldReturn410_CarTest()
        {
            // Arrange
            double expected = 410;

            // Act
            double actual = oCar.Price(false);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PriceWithBrobizz_ShouldReturn161_CarTest()
        {
            // Arrange
            double expected = 161;

            // Act
            double actual = oCar.Price(true);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VehicleType_ShouldReturnOresundCar_CarTest()
        {
            // Arrange
            string expected = "Oresund car";

            // Act
            string actual = oCar.VehicleType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // mc
        [TestMethod()]
        public void PriceWithoutBrobizz_ShouldReturn210_MCTest()
        {
            // Arrange
            double expected = 210;

            // Act
            double actual = oMC.Price(false);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PriceWithBrobizz_ShouldReturn73_MCTest()
        {
            // Arrange
            double expected = 73;

            // Act
            double actual = oMC.Price(true);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VehicleType_ShouldReturnOresundMC_MCTest()
        {
            // Arrange
            string expected = "Oresund MC";

            // Act
            string actual = oMC.VehicleType();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}