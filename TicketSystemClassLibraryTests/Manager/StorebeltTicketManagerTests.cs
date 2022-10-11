using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using StorebeltbroenTicketREST.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorebeltbroenTicketREST.Manager.Tests
{
    [TestClass()]
    public class StorebeltTicketManagerTests
    {
        private StorebeltTicketManager manager = new();

        [TestMethod()]
        public void AddCar_ShouldReturnSameObject_ManagerTest() // når jeg kører alle så fejler den. men når jeg kører kun den så er den sucess
        {
            // Arrange
            Storebaelt car1 = new();
            car1.Licenseplate = "5tegn";
            car1.Brobizz = false;

            // Act
            manager.AddCar(car1);

            Storebaelt newCar = manager.GetFromLicensePlate("5tegn")[0];
            Storebaelt latesCar = manager.AllCarTicketes().Last();

            // Assert
            Assert.AreEqual(newCar, latesCar);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddCar_ShouldthrowNullException_ManagerTest()
        {
            // Arrange
            Storebaelt car1 = new();

            // Act
            manager.AddCar(car1);

            // Assert
            Assert.Fail();
        }
        
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void AddCarDuplicate_ShouldthrowArgumentException_ManagerTest()
        {
            // Arrange
            Storebaelt car1 = new();
            car1.Licenseplate = "5tegn";
            car1.Brobizz = false;

            // Act
            manager.AddCar(car1);
            manager.AddCar(car1);

            // Assert
            Assert.Fail();
        }


        [TestMethod()]
        public void AllCarTicketesHasAtleastOneElement_ManagerTest()
        {
            // Arrange


            // Act
            int numberOfCars = manager.AllCarTicketes().Count();

            // Assert
            Assert.IsTrue(numberOfCars >= 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void AllCarTicketesHasAtLeastOne_ShowThrowArgumentException_ManagerTest()
        {
            // Arrange
            manager.AllCarTicketes().Clear();

            // Act
            int numberOfCars = manager.AllCarTicketes().Count();

            // Assert
            Assert.IsTrue(numberOfCars >= 1);
        }

        [TestMethod()]
        public void GetFromLicensePlate_ShouldReturnOneElement_ManagerTest()
        {
            // Arrange
            Storebaelt newCar = new();
            newCar.Licenseplate = "321";
            newCar.Brobizz = false;
            manager.AddCar(newCar);

            // Act
            List<Storebaelt> car = manager.GetFromLicensePlate("321");

            // Assert
            Assert.AreEqual(newCar, car.First());
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetFromLicensePlate_ShouldThrowNullException_ManagerTest()
        {
            // Arrange
            Storebaelt newCar = new();
            newCar.Licenseplate = "321";
            newCar.Brobizz = false;
            manager.AddCar(newCar);

            // Act
            List<Storebaelt> car = manager.GetFromLicensePlate("");

            // Assert
            Assert.Fail();
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void GetFromLicensePlate_ShouldThrowArguemntException_ManagerTest()
        {
            // Arrange
            Storebaelt newCar = new();
            newCar.Licenseplate = "321";
            newCar.Brobizz = false;
            manager.AddCar(newCar);

            // Act
            List<Storebaelt> car = manager.GetFromLicensePlate("123");

            // Assert
            Assert.Fail();
        }
    }
}