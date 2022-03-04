// <copyright file="InterestCalculate.cs" company="PlaceholderCompany">
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
    /// Third Party Library to calculate Interest.
    /// </summary>
    public class InterestCalculate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterestCalculate"/> class.
        /// </summary>
        /// <param name="amount">Amount paid to the bank.</param>
        /// <param name="rate">Interest rate.</param>
        public InterestCalculate(double amount, double rate)
        {
            this.Amount = amount;
            this.InterestRate = rate;
        }

        /// <summary>
        /// Gets or Sets Interest Rate for the loan amount.
        /// </summary>
        public double InterestRate { get; set; }

        /// <summary>
        /// Gets or Sets Amount paid to the bank.
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Calculates the interest rate on the amount per year.
        /// </summary>
        /// <returns>Calculated interest.</returns>
        public double Calculate()
        {
            return (this.Amount * this.InterestRate * 1) / 100;
        }
    }
}
