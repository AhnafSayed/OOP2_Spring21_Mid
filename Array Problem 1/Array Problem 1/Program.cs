using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] b = new int[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                b[i] = a[i];
            }
            Console.Write("The first array elements are :\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            Console.Write("\nThe copy second array elements are :\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", b[i]);
            }
        }
    }
}
