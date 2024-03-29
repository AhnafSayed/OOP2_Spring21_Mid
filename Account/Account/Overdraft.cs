﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class Overdraft : Accounts
    {
        double overdraftLimit;

        public Overdraft(double overdraftLimit)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public Overdraft(string name, int accNo, double bal, double overdraftLimit) : base(name, accNo, bal)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Account()
        {
            throw new NotImplementedException();
        }

        public override void Withdraw(double amount)
        {
            if (amount <= Balance + overdraftLimit)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("You can not withdraw.");
            }
        }
    }
}