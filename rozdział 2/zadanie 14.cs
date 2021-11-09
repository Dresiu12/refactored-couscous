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
            int x = 1;
            int n = 0;
            int y = 0;
            while(x < 100)
            {
                x += y;
                y++;
                n++;               
            }
            Console.WriteLine("Nalezy dodac {0} liczb", n);
            Console.ReadKey();
        }
    }
}
