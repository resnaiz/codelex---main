using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_7
{
    class SavingsAccount
    {
        private double rate;
        private double balance;

        public SavingsAccount(double amountOfBalance)
        {
            this.balance = amountOfBalance;
        }

        public void SubtractingAmountOfDeposit(double amount)
        {
            this.balance -= amount;
        }

        public void AddingAmountOfDeposit(double amount)
        {
            this.balance += amount;
        }

        public void AddingAmountOfInterest()
        {
            double interestRate = rate / 12;
            double interest = balance * interestRate;
            balance += interest;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void SetInterestRate(double rate)
        {
            this.rate = rate;
        }
    }
}
