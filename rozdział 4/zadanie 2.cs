using System;

namespace ConsoleApp11
{
    class Program
    {
        static double Prze(int a, int b, int x)
        {
            if (x <= b && x >= a) return 1;
            else return 0;
        }
        static void Main(string[] args)
        {
            if (Prze(3, 12, 62) == 1)
            {
                Console.WriteLine("Miesci sie w zakresie");
            }
            else Console.WriteLine("Nie miesci sie w zakresie");
            Console.ReadKey();
        }
    }
}
