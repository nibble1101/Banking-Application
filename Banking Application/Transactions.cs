// <copyright file="Transactions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Banking_Application
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Abstract transaction class.
    /// </summary>
    public abstract class Transactions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Transactions"/> class.
        /// </summary>
        /// <param name="from">Transaction made from.</param>
        /// <param name="amount">Transaction Amount.</param>
        /// <param name="type">Transaction type i.e. Credit or debit.</param>
        public Transactions(int from, double amount, string type)
        {
            this.TransactionFrom = from;
            this.TransactionAmount = amount;
            this.TransactionType = type;
        }

        /// <summary>
        /// Gets the Transaction ID.
        /// </summary>
        public int TransactionFrom { get; }

        /// <summary>
        /// Gets the Transaction Amount.
        /// </summary>
        public double TransactionAmount { get; }

        /// <summary>
        /// Gets Type of transaction, i.e. Debit or Credit.
        /// </summary>
        public string TransactionType { get; }

        /// <summary>
        /// Displays the transaction details.
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"\tTransaction Ac. No. \t\t\tTransaction Type \t\tTransaction Amount ");
            Console.WriteLine($"\t{this.TransactionFrom} \t\t\t\t\t{this.TransactionType} \t\t\t\t{this.TransactionAmount}");
            Console.WriteLine($"\n");
        }
    }
}
