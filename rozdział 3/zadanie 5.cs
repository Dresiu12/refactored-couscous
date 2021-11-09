using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 19, 34, 23, 54, 31, 12, 13, 2, 4, 5 };
            int[] y = new int[x.Length];
            for (int i = 0; i < x.Length-1; i++)
            {
                if (i == 0)
                {
                    y[i] = x[x.Length-1];
                    Console.WriteLine(y[i]);
                }
                else
                {
                    y[i] = x[i-1];
                    Console.WriteLine(y[i]);
                }
            }
            Console.ReadKey();
        }
    }
}