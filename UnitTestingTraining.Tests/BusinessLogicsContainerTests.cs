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

        #region TODO - tests to be implemented for GetAccountBalance method

        [TestMethod]
        public void GetAccountBalance_ReturnsZeroBalanceForASeriesOfSameCreditsAndDebits()
        {
            // TODO: Implement the test based on the test title
            Assert.Fail();
        }        
                
        [TestMethod]
        public void GetAccountBalance_ReturnsCorrectBalanceForSameAccountNumber()
        {
            // TODO: Implement the test based on the test title
            Assert.Fail();
        }

        [TestMethod]        
        public void GetAccountBalance_ReturnsExpectedExceptionWhenAllTransactionsAreNullOrEmpty()
        {
            // TODO: Implement the test based on the test title
            Assert.Fail();
        }

        [TestMethod]
        public void GetAccountBalance_ReturnsExpectedExceptionWhenAccountNumberDoesNotExist()
        {
            // TODO: Implement the test based on the test title
            Assert.Fail();
        }

        [TestMethod]
        public void GetAccountBalance_ReturnsExpectedExceptionWhenAccountNumberIsNullOrEmpty()
        {
            // TODO: Implement the test based on the test title
            Assert.Fail();
        }

        [TestMethod]        
        public void GetAccountBalance_ReturnsExpectedExceptionWhenNumbersAreBeyondRanges()
        {
            // TODO: Implement the test based on the test title
            Assert.Fail();
        }

        #endregion

        #region TODO: Add tests for GetTransactionDetailsFromTransactionId method
        #endregion

        #region TODO: Add tests for GetTransactionsForAccountDuringPeriod method
        #endregion
    }
}
