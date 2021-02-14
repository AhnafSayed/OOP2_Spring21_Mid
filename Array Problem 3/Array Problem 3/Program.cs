using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 6, 7, 7, 7, 8, 8, 9, 9, 9, 10, 10 };
            HashSet<int> a = new HashSet<int>();
            for (int i = 0; i < 15; i++)
            {
                a.Add(arr[i]);
            }
            foreach (int j in a)
            {
                Console.WriteLine("Unique elements are: " +j);
            }
        }
    }
}
