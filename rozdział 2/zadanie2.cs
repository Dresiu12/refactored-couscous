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
            Console.WriteLine("Podaj jeszcze inną liczbe");
            int z = int.Parse(Console.ReadLine());
            if (x > y & x > z)
                Console.WriteLine("Liczba {0} jest najwieksza", x);
            else if (y > x & y > z)
                Console.WriteLine("Liczba {0} jest najwieksza", y);
            else if (z > x & z > y)
                Console.WriteLine("Liczba {0} jest najwieksza", z);
            Console.ReadKey();
        }
    }
}
