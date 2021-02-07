using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("The Even Numbers Are:");
            for (i = 1; i<=150; i++)
            {
                if (i%2==0)
                {
                    Console.Write(i + " \n");
                }
            }

        }
    }

}
