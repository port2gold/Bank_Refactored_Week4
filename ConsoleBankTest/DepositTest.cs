using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleBankTest
{
    [TestClass]
    public class DepositTest
    {
        //Checks if it takes Negative deposit
        [TestMethod]
        public void NegativeDeposit()
        {
            
            //Arrange
            var account = new Account("Tunmise",  DateTime.Now);

            //Act 


            // Assert
            Assert.ThrowsException<ArgumentException>(() => account.Deposit(-12000, DateTime.Now, "Shopping spree"));
            
        }
        //Check if money was reflected when deposited 
        [TestMethod]
        public void PositiveMoneyEffected()
        {
            //Arrange
            var account = new Account("Bosun", DateTime.Now);
            account.Deposit(10000, DateTime.Now, "school fees");
            var expected = 10000;


            //Act
            decimal actual = account.GetBalance();
            


            //Assert
            Assert.AreEqual(expected, actual);

        }

        
    }
}
