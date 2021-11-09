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
            Console.WriteLine("Podaj srednia ocen (nalezy uzyc przecinka, nie kropki)");
            float x = float.Parse(Console.ReadLine());
            if (x < 4.00)
            {
                Console.WriteLine("Przysługuje Ci kwota stpendium: 0.00zł");
            }
            else if (x < 4.8)
            {
                Console.WriteLine("Przysługuje Ci kwota stpendium: 350.00zł");
            }
            else
            {
                Console.WriteLine("Przysługuje Ci kwota stpendium: 550.00zł");
            }
            Console.ReadKey();
        }
    }
}
