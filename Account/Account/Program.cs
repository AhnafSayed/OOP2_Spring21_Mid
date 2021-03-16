using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts acc1 = new Savings();
            Accounts acc2 = new Savings("Hasan", 52606, 63000);
            Accounts acc3 = new SpecialSavings("Jubaer", 57345, 45000, 20);

            Accounts acc4 = new Fixed("Rahman", 52346, 6000);

            Accounts acc5 = new Overdraft(1500);
            SpecialSavings s1 = new SpecialSavings(30);

            Overdraft od = new Overdraft("Hasan", 52606, 63000, 4500);
        }
    }
}