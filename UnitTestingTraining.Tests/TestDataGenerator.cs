using SimpleDotNetExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingTraining.Tests
{
    public static class TestDataGenerator
    {
        /// <summary>
        /// Gets the transactions.
        /// </summary>
        /// <returns>The list of transactions</returns>
        public static List<Transaction> GetTransactions()
        {
            return new List<Transaction>()
            {
                new Transaction()
                {
                    AccountNumber = "ABC123432",
                    IsCredit = true,
                    Amount = 1000.0,
                    Id = "TRA3241623"
                },
                new Transaction()
                {
                    AccountNumber = "ABC123432",
                    IsCredit = true,
                    Amount = 500.0,
                    Id = "TRA3241624"
                },
                new Transaction()
                {
                    AccountNumber = "ABC123432",
                    IsCredit = false,
                    Amount = 1000.0,
                    Id = "TRA3241625"
                },
                new Transaction()
                {
                    AccountNumber = "ABC123432",
                    IsCredit = true,
                    Amount = 50,
                    Id = "TRA3241626"
                },
                new Transaction()
                {
                    AccountNumber = "ABC123432",
                    IsCredit = false,
                    Amount = 10,
                    Id = "TRA3241627"
                },
                new Transaction()
                {
                    AccountNumber = "BCD123432",
                    IsCredit = true,
                    Amount = 1000.0,
                    Id = "TRA3241628"
                },
            };
        }
    }
}
