using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    abstract class Accounts
    {
        abstract public void Withdraw(double amount);
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int accNo;

        public Accounts(string name, int accNo, double bal)
        {
            this.name = name;
            this.accNo = accNo;
            this.Balance = bal;
        }

        protected double Balance
        { get; set; }

        protected int TransactionNum
        { get; set; }
        protected int maximumTransaction
        { get; set; }


        public int AccNo
        {
            get { return (int)accNo; }
            set { accNo = value; }
        }


        abstract public void Account();

        virtual public void Account(string name, int accNo, double balance)
        {
        }


    }
}