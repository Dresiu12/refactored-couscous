using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jakas liczbe do obliczenia jej silnii");
            int n = int.Parse(Console.ReadLine());
            int x = 1;
            while (n > 0)
            {
                x += x*(n-1);
                --n;
            }
            Console.WriteLine("Wynik wynosi {0}", x);
            Console.ReadKey();
        }
    }
}
