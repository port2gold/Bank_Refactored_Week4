using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleBankTest
{
    [TestClass]
    public class RegisterTest
    {
        //Checks for a Valid customer name
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
        //Checks for NOn Valid customer Name
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
