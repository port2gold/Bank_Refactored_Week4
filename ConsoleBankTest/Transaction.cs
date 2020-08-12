using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleBankTest
{
    [TestClass]
    public class Transaction
    {
        [TestMethod]
        public void TransactionCount()
        {
            //Arrange
             var account = new Account("TY",DateTime.Now);
           account.Deposit(100000, DateTime.Now,"paid leave");
           account.Deposit(105000, DateTime.Now,"Tax returns");
           account.Transfer("1234567890",5000, DateTime.Now ,"Free Money");
            int expected = 3;

            //Act
            int actual = account.AllTransactions.Count +1;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        
    }
}
