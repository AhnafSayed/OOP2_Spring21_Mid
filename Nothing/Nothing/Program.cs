using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nothing
{
    class Program
    {  static void main(string[] args)
        {
            int n = 1;
            method(n);
            Console.WriteLine(n);
            method1(ref n);
            Console.WriteLine(n);
        }
        static void method(int num)
        {
            num += 20;
            Console.WriteLine(num);
        }
        static void method1(ref int num)
        {
            num += 20;
            Console.WriteLine(num);
        }
    }
}
