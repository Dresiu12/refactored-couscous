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
            Console.WriteLine("Kalkulator\r");
            Console.WriteLine("----------\n");
            Console.WriteLine("Podaj pierwsza liczbe");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Wybierz opcje z listy:");
            Console.WriteLine("\ta - Dodawanie");
            Console.WriteLine("\ts - Odejmowanie");
            Console.WriteLine("\tm - Mnozenie");
            Console.WriteLine("\td - Dzielenie");
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Wynik: {x} + {y} = " + (x + y));
                    break;
                case "s":
                    Console.WriteLine($"Wynik: {x} - {y} = " + (x - y));
                    break;
                case "m":
                    Console.WriteLine($"Wynik: {x} * {y} = " + (x * y));
                    break;
                case "d":
                    Console.WriteLine($"Wynik: {x} / {y} = " + (x / y));
                    break;
            }

            Console.ReadKey();
        }
    }
}
