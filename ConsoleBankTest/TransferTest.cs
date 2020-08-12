using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleBankTest
{
    
    [TestClass]
    public class TransferTest
    {
        //Checks for Negative Amount Transfer
        [TestMethod]
        public void TransferNegativeAmount()
        {

            //Arrange
            var account = new Account("Keisha", DateTime.Now);
            account.Deposit(78000, DateTime.Now, "Money for Travels");
            //Act & Assert

            Assert.ThrowsException<ArgumentException>(() => account.Transfer("1234567890", -20000, DateTime.Now, "Negative Transfer"));
        }

        //Checks for over Transfer
        [TestMethod]
        public void OverTransfer()
        {
            //Arrange
            var account = new Account("Jay Jay", DateTime.Now);
            account.Deposit(5000, DateTime.Now, "Cheat Super Bank");

            //Act & Assert

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Transfer("1234567890", 100000, DateTime.Now, "Cheat the bank"));
        }

        
    }
}
