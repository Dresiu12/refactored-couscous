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
            Console.WriteLine("Ile elementów?");
            int rozmiar = Convert.ToInt32(Console.ReadLine());
            int[] nel = new int[rozmiar];
            
            Console.WriteLine("Wypelnij tablice");
            for (int i = 0; i < nel.Length; i++)
            {
                nel[i] = int.Parse(Console.ReadLine());
            }

            int naje = 0;
            int najp = 0;
            for (int i = 0; i < nel.Length; i++)
            {
                if (nel[i] > naje)
                {
                    naje = nel[i];
                    najp = i+1;
                }
            }

            int nnaje = 100000;
            int nnajp = 100000;
            for (int i = 0; i < nel.Length; i++)
            {
                if (nel[i] < nnaje)
                {
                    nnaje = nel[i];
                    nnajp = i+1;
                }
            }

            float sr = 0;
            for (int i = 0; i < nel.Length; i++)
            {
                sr += nel[i];
            }
            sr /= nel.Length;
            
            int dod = 0;;
            for (int i = 0; i < nel.Length; i++)
            {
                if (nel[i] > 0)
                {
                    dod += 1;
                }
            }

            Console.WriteLine("wartość i numer pozycji największego elementu: " + naje + ", " + najp);
            Console.WriteLine("wartość i numer pozycji najmniejszego elementu: " + nnaje + ", " + nnajp);
            Console.WriteLine("srednia wartości wszystkich elementów tablicy: " + sr);
            Console.WriteLine("liczba dodatnich elementów tablicy: " + dod);

            Console.ReadKey();
        }
    }
}