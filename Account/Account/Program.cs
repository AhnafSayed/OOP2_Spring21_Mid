using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new SavingsAccount("Avoid Rafa", "54367", 46000);
            Account a2 = new CurrentAccount("Avoid Rafa", "56427", 46000);
            Account a3 = new SavingsAccount("Avoid Rafa", "52866", 46000);

            Person p = new Person("Avoid Rafa");

            p.AddAccount(a1, a2, a3);
            p.ShowAccontDetails();

            var acc = p.GetAccount("56427");

            acc.Withdraw(42000);

        }
    }
}
