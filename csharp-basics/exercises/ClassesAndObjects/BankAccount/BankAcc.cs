using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount
    {
        private string name;
        private double balance;

        public BankAccount(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            string newBalance;

            if (balance < 0)
            {
                newBalance = string.Format("-${0:F2}", -balance);
            }
            else
            {
                newBalance = string.Format("${0:F2}", balance);
            }
            return name + ", " + newBalance;
        }
    }
}
