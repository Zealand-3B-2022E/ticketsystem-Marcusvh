using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StorebaeltTests
    {
        private Storebaelt storebaelt = new();

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