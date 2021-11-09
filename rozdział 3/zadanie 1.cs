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
            int[] x = { 19, 34, 23, 54, 31, 12, 13, 2, 4 ,5 }; 
            foreach (int z in x) 
                Console.WriteLine(z); 
            Console.ReadKey();
        }
    }
}