using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class Savings : Accounts
    {

        public Savings(string name, int accNo, double bal) : base(name, accNo, bal)
        {
            maximumTransaction = 100;
        }
        public Savings()
        {
            maximumTransaction = 30;
        }
        public override void Withdraw(double amount)
        {
            if (Balance - amount >= 500 && TransactionNum <= maximumTransaction)
            {
                Balance -= amount;
                TransactionNum++;
            }
            else
            {
                Console.WriteLine("You can not withdraw.");
            }
        }

        public override void Account()
        {
            throw new NotImplementedException();
        }
    }
}