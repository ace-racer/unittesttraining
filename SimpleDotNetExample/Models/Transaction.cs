using System;

namespace SimpleDotNetExample.Models
{
    public class Transaction
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        /// <value>
        /// The account number.
        /// </value>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is credit.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is credit; otherwise, <c>false</c>.
        /// </value>
        public bool IsCredit { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets the created on.
        /// </summary>
        /// <value>
        /// The created on.
        /// </value>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>
        /// The comments.
        /// </value>
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets the beneficiary account number.
        /// </summary>
        /// <value>
        /// The beneficiary account number.
        /// </value>
        public string BeneficiaryAccountNumber { get; set; }
    }
}
