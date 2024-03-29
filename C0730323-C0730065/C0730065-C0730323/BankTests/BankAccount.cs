﻿using System;

namespace BankTests
{
    internal class BankAccount
    {
        private string v;
        private double beginningBalance;

        public BankAccount(string v, double beginningBalance)
        {
            this.v = v;
            this.beginningBalance = beginningBalance;
        }

        public static string DebitAmountLessThanZeroMessage { get; internal set; }
        public static string DebitAmountExceedsBalanceMessage { get; internal set; }
        public double Balance { get; internal set; }

        internal void Debit(double debitAmount)
        {
            throw new NotImplementedException();
        }
    }
}