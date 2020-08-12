using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleBankTest
{
    [TestClass]
    public class LogInTest
    {
        //Checks for valid input
        [TestMethod]
        public void fistNamePassWordMatch()
        {
            //Arrange
            var customer = new Customer();
            customer.CustomerFirstName = "Blessing";
            customer.CustomerLastName = "David";
            customer.Password = "blessing";
            customer.CustomerEmail = "blessingdavid@yahoo.com";
            bool actual = true;
            //Act
            Bank.LogIn("Blessing", "blessing");
            //Assert
            Assert.AreEqual(true, actual);
        }
    }
}
