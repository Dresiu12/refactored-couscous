using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int n;

            Console.Write("Podaj x: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Podaj n: ");
            n = int.Parse(Console.ReadLine());

            licz(x, n);
            Console.ReadKey();
        }

        private static void licz(int x, int n)
        {
            int w = 0;
            for (int i = 1; i <= n; i++)
            {
                w += x + i;
            }
            Console.Write(w);
        }
    }
}
