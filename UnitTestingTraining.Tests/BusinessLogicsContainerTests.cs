using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleDotNetExample;

namespace UnitTestingTraining.Tests
{
    [TestClass]
    public class BusinessLogicsContainerTests
    {
        [TestMethod]
        public void GetAccountBalance_ReturnsCorrectBalanceForASeriesOfCreditsAndDebits()
        {
            var allTransactions = TestDataGenerator.GetTransactions();
            var balance = BusinessLogicsContainer.GetAccountBalance("ABC123432", allTransactions);
            Assert.AreEqual(540, balance);
        }

        #region hideme

        [TestMethod, Ignore]
        public void GetAccountBalance_ReturnsZeroBalanceForASeriesOfSameCreditsAndDebits()
        {
            // How to do this?
        }        
                
        [TestMethod, Ignore]
        public void GetAccountBalance_ReturnsCorrectBalanceForSameAccountNumber()
        {
            // How to do this?
        }        

        [TestMethod, Ignore]        
        public void GetAccountBalance_ReturnsExpectedExceptionWhenAllTransactionsAreNullOrEmpty()
        {
            // How to do this?
        }

        [TestMethod, Ignore]
        public void GetAccountBalance_ReturnsExpectedExceptionWhenAccountNumberDoesNotExist()
        {
            // How to do this?
        }

        [TestMethod, Ignore]
        public void GetAccountBalance_ReturnsExpectedExceptionWhenAccountNumberIsNullOrEmpty()
        {
            // How to do this?
        }

        [TestMethod, Ignore]
        public void GetAccountBalance_ReturnsExpectedExceptionWhenNumbersAreBeyondRanges()
        {
            // How to do this?
        }

        #endregion
    }
}
