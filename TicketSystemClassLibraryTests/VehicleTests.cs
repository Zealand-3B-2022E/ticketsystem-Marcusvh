using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using StoreBaeltTicketLibrary;

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
        private Storebaelt storebaelt = new ();

        // Car 
        [TestMethod()]
        public void Price_ShouldReturn240_CarTest()
        {
            // Arrange
            double expected = 240;

            // Act
            double actual = car.Price(false);

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
            double actual = mc.Price(false);

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


        // Vehicle
        [TestMethod()]
        [DataRow("")]
        [DataRow("d")]
        [DataRow("DK 25")]
        [DataRow("DK 2567")]
        public void LicensePlateMayNotBeLongerThen7Characters_ShouldBeSuccess_VehicleTest(string LPlate)
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
        public void LicensePlateMayNotBeLongerThen7Characters_ShouldThrowNullException_VehicleTest(string LPlate)
        {
            // Arrange


            // Act
            mc.Licenseplate = LPlate;

            // Assert
            Assert.Fail();
        }
        [TestMethod()]
        [DataRow("DK 25678")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LicensePlateMayNotBeLongerThen7Characters_ShouldThrowOutOfRangeException_VehicleTest(string LPlate)
        {
            // Arrange


            // Act
            mc.Licenseplate = LPlate;

            // Assert
            Assert.Fail();
        }

        
        [TestMethod()]
        public void DiscountWhenUsingBrobizz_PriceShouldBe5percentLess_MCTest()
        {
            // Arrange
            double expected = mc.Price(false) * 0.95;

            // Act
            double actual = mc.Price(true);

            // Assert
            Assert.AreEqual(expected, actual, 0.1);
        }
        [TestMethod()]
        public void NoDiscountWhenNotUsingBrobizz_PriceShouldBeUnchanged_MCTest()
        {
            // Arrange
            double expected = 125;

            // Act
            double actual = mc.Price(false);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DiscountWhenUsingBrobizz_PriceShouldBe5percentLess_CarTest()
        {
            // Arrange
            double expected = car.Price(false) * 0.95;

            // Act
            double actual = car.Price(true);

            // Assert
            Assert.AreEqual(expected, actual, 0.1);
        }
        [TestMethod()]
        public void NoDiscountWhenNotUsingBrobizz_PriceShouldBeUnchanged_CarTest()
        {
            // Arrange
            double expected = 240;

            // Act
            double actual = car.Price(false);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void WeekendDiscountWhenNotUsingBrobizz_PriceShouldBe20PercentLess_CarTest()
        {
            // Arrange
            double expected = 192;
            storebaelt.Date = DateTime.Parse("08-10-2022");

            // Act
            double actual = storebaelt.Price(false);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod()]
        public void NoWeekendDiscountAndNoBrobizz_PriceShouldBeUnchanged_CarTest()
        {
            // Arrange
            double expected = 240;
            storebaelt.Date = DateTime.Parse("07-10-2022");

            // Act
            double actual = storebaelt.Price(false);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void WeekendAndBrobizzDiscount_PriceShouldBe182dot4_CarTest()
        {
            // Arrange
            double expected = 182.4;
            storebaelt.Date = DateTime.Parse("08-10-2022");

            // Act
            double actual = storebaelt.Price(true);

            // Assert
            Assert.AreEqual(expected, actual, 0.1);
        }
    }
}