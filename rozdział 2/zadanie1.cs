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
            Console.WriteLine("Podaj liczbe");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj inną liczbe");
            int y = int.Parse(Console.ReadLine());
            if (x % y == 0)
                Console.WriteLine("Liczba {1} jest dzielnikiem liczby {0}", x, y);
            else
                Console.WriteLine("Liczba {1} nie jest dzielnikiem liczby {0}", x, y);
            Console.ReadKey();
        }
    }
}
