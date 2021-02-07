using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account1
    {
        private string accName;
        private string acid;
        private int balance;
        private int amount;

        public Account1()
        {
        }

        public Account1(string accName, string acid, int balance,int amount)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
            this.amount = amount;
        }
        public string AccName
        {
            get
            {
                return accName;
            }
            set
            {
                accName = value;
            }
        }
        public string Acid
        {
            get
            {
                return acid;
            }
            set
            {
                acid = value;
            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Please enter your amount:");
                }
                else
                {
                    amount = value;
                }
            }
        }

        class Main1
        {
            public void Main(string[] args)
            {
                Account1 a = new Account1();
                a.accName = "Kazi Zafar";
                a.acid = "Zafar009";
                a.balance = 120000;
                Console.WriteLine("Deposit: " + amount);
                Console.WriteLine("Withdrawal: " - amount);
            }

        }
    }

}