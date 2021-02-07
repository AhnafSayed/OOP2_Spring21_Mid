using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading
{
    class Grade1
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert your desired marks:");
            int mark = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your grade is:");

            if (mark >= 90)
            {
                Console.WriteLine("A+");
            }
            else if (mark >= 85 && mark < 89)
            {
                Console.WriteLine("A");
            }
            else if (mark >= 80 && mark < 84)
            {
                Console.WriteLine("B+");
            }
            else if (mark >= 75 && mark < 79)
            {
                Console.WriteLine("B");
            }
            else if (mark >= 50 && mark < 74) 
            {
                Console.WriteLine("C+");
            }

            else if (mark <= 49)
            {
                Console.WriteLine("F");
            }

            else
            {
                Console.WriteLine("Nothing found!");
            }
        }
    }
}
