using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Odd_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0, sum1=0, i, n = 100;
            for (i = 1; i <= n; i++)
            {
                sum+= 2 * i;
                sum1+= (2 * i) - 1;
            }
            Console.WriteLine("Sum of all Even numbers are= {0} \n", sum);
            Console.WriteLine("Sum of all Odd numbers are= {0} \n", sum1);
        }
    }
}
      
