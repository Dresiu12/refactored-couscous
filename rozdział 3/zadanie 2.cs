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
            int[] y = new int [x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = x[i];
            }
            Console.ReadKey();
        }
    }
}