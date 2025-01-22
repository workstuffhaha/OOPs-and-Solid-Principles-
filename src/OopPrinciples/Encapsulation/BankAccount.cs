using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OOPs.src.OopPrinciples.Encapsulation //no semicolon applied here
{
    public class BankAccount
    {
        private decimal balance;
    //constructor
        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }

        public decimal GetBalance()
        {
            return balance;
        }
        public void Deposit (decimal amount)
        {
            if(amount<=0)
            {
                throw new ArgumentException("the amount should be positive ");
            }
            this.balance+=amount;

        }

        public void WithDrawal(decimal amount)
        {
            if(amount<=0)
            {
                throw new ArgumentException("withdrawal amount should be positive");
            }
            if(amount>balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }
            this.balance-=amount;
        }
    }
}
