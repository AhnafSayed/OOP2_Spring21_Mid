using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class Fixed : Accounts
    {
        DateTime tenure_year = new DateTime(2021, 03, 15);
        public Fixed(string name, int accNo, double bal) : base(name, accNo, bal)
        {
            this.Name = name;
            this.AccNo = accNo;
            this.Balance = bal;
        }

        public override void Account()
        {
            throw new NotImplementedException();
        }

        public override void Withdraw(double amount)
        {
            if (tenure_year < DateTime.Today && amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Transaction not allowed!");
            }
        }
    }
}