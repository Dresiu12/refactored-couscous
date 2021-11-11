using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Podaj x: ");
            x = int.Parse(Console.ReadLine());

            licz(x);
            Console.ReadKey();
        }

        private static void licz(int x)
        {
            int w = 0;
            int i = 0;
            int j = 0;
            int z = 0;
            for (i = 0; x > 99; ++i)
            {
                x -= 100;
            }
            for (j = 0; x > 9; ++j)
            {
                x -= 10;
            }
            for (z = 0; x > 0; ++z)
            {
                x -= 1;
            }
            w = i + j + z;
            Console.Write(w);
        }
    }
}
