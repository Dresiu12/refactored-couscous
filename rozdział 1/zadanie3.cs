using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, w, bmi;
            Console.WriteLine("Podaj swoja mase: ");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoj wzrost: ");
            w = double.Parse(Console.ReadLine());
            bmi = m / w;
            Console.WriteLine("Twoje BMI wynosi: " + bmi);
            Console.ReadKey();
        }
    }
}
