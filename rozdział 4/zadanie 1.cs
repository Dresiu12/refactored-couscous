using System;

namespace ConsoleApp11
{
    class Program
    {
        static double cel(double x)
        {
            x = (x - 32) * 5 / 9;
            return (x);
        }
        static void Main(string[] args)
        {
            double x = 120;
            Console.WriteLine(x+" stopni Fahrenheita to "+cel(x)+" stopni Celsjusza");
            Console.ReadKey();
        }
    }
}
