using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleBankTest
{
    [TestClass]
    public class RegisterTest
    {
        [TestMethod]
        public void CustomerFullName()
        {
            //Arrange
            var customer = new Customer();
            customer.CustomerFirstName = "Atinuke";
            customer.CustomerLastName = "David";
            var expected = "David, Atinuke";


            //Act
            var actual = customer.CustomerFullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomerNotValid()
        {
            //Act
            var customer = new Customer();
            customer.CustomerFirstName = "Tolulope";
            customer.CustomerLastName = "Idahosa";
            customer.CustomerEmail = "tolulopeidahosa@gmail.com";
            var expected = "Idaho, Tolulope";

            //Act
            var actual = customer.CustomerFullName;

            //Assert
            Assert.AreNotEqual(expected, actual);

        }
    }
}
