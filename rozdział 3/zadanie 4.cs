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
            int[] x = new int [100];
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                int v = (rand.Next(1, 999));
                x[i] = v;
            }
            for (int i = 0; i < x.Length; i++)
                if (IsPrime(x[i])) 
                    Console.WriteLine("{0} jest liczbą pierwszą.", x[i]);
            Console.ReadKey();
        }
        public static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= squareRoot; i += 2)
                if (number % i == 0) return false;

            return true;
        }
    }
}