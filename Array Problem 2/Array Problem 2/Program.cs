using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 6, 7, 7, 7, 8, 8, 9, 9, 9, 10, 10 };
            int[] b = new int[50];
            HashSet<int> ab = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                ab.Add(a[i]);
                b[a[i]]++;
            }
            foreach (int m in ab)
            {
                Console.WriteLine(m + " happens " + b[m] + " ");
            }
        }
    }
}