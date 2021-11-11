using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int d;
            int s;
            string z;
            
            Console.WriteLine("Podaj dlugosc: ");
            d = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Podaj szerokosc: ");
            s = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Podaj znak: ");
            z = Console.ReadLine();

            rysuj(d, s, z);
            Console.ReadKey();
        }

        private static void rysuj(int d, int s, string z)
        {
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    Console.Write(z);
                }
                Console.WriteLine();
            }
        }
    }
}
