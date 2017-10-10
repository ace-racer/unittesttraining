using SimpleDotNetExample.Models;
using System;
using System.Collections.Generic;

namespace SimpleDotNetExample
{
    public static class BusinessLogicsContainer
    {
        /// <summary>
        /// Gets the balance.
        /// </summary>
        /// <param name="accountNumber">The account number.</param>
        /// <param name="allTransactions">All transactions.</param>
        /// <returns>The balance of the account specified by the account number</returns>
        public static double GetAccountBalance(string accountNumber, List<Transaction> allTransactions)
        {
            double balance = 0;
            foreach (var transaction in allTransactions)
            {
                if(string.Compare(transaction.AccountNumber, accountNumber) == 0)
                {
                    // what does this line assume for a proper transaction??
                    balance += transaction.IsCredit ? transaction.Amount : -transaction.Amount;
                }
            }

            return balance;
        }

        /// <summary>
        /// Gets the transaction details from transaction identifier.
        /// </summary>
        /// <param name="transactionNumber">The transaction number.</param>
        /// <param name="allTransactions">All transactions.</param>
        /// <returns>The details of the transaction from the transaction ID</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public static Transaction GetTransactionDetailsFromTransactionId(string transactionNumber, List<Transaction> allTransactions)
        {
            // TODO: Implement this method based on the description in the method header and write unit tests
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the transactions for account during period.
        /// </summary>
        /// <param name="accountNumber">The account number.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="allTransactions">All transactions.</param>
        /// <returns>All transactions for the account number performed in the period provided, inclusive of the start and the end days.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public static List<Transaction> GetTransactionsForAccountDuringPeriod(string accountNumber, DateTime startDate, DateTime endDate, List<Transaction> allTransactions)
        {
            // TODO: Implement this method based on the description in the method header and write unit tests
            throw new NotImplementedException();
        }
    }
}
