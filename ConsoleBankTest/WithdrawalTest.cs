using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleBankTest
{
    [TestClass]
    public class WithdrawalTest
    {
        [TestMethod]
        public void NegativeWithdrawal()
        {
            //Arrange
            var account = new Account("tosin", DateTime.Now);


            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => account.Withdrawal(-3000, DateTime.Now, "Money for Food"));
        }

        [TestMethod]
        public void ExcessWithdrawal()
        {
            var account = new Account("IT", DateTime.Now);
            account.Deposit(2000, DateTime.Now, "Salary");

            //Act & Assert

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Withdrawal(5000, DateTime.Now, "Bank Cheat"));
        }

        [TestMethod]
        public void WithdrawalEffected()
        {
            //Arrange
            var account = new Account("Tasha", DateTime.Now);
            account.Deposit(10000, DateTime.Now, "Wages");
            account.Withdrawal(4000, DateTime.Now, "Flexing Money");
            var expected = 6000;
            //Act
            var actual = account.GetBalance();

            //Assert
            Assert.AreEqual(expected, actual);


        }


    }
}
