using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleBankTest
{
    [TestClass]
    public class WithdrawalTest
    {
        //Check for Negative Withdrawal
        [TestMethod]
        public void NegativeWithdrawal()
        {
            //Arrange
            var account = new Account("tosin", DateTime.Now);


            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => account.Withdrawal(-3000, DateTime.Now, "Money for Food"));
        }
        //Checks for Excess Withdrawal
        [TestMethod]
        public void ExcessWithdrawal()
        {
            var account = new Account("IT", DateTime.Now);
            account.Deposit(2000, DateTime.Now, "Salary");

            //Act & Assert

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Withdrawal(5000, DateTime.Now, "Bank Cheat"));
        }
        
       


    }
}
