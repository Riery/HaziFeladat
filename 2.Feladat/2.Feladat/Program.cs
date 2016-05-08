using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Feladat
{
    class Program
    {
        static int Fibonacci(int a)//Rekurzív fibonacci függvény
        {
            if (a < 1)
            {
                return 0;
            }
            if (a == 1)
            {
                return 1;
            }
            else
            {
                return (Fibonacci(a - 1) + Fibonacci(a - 2));
            }
        }
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)//Első öt elem kiirása
            {
                Console.WriteLine(Fibonacci(i));
            }
            Console.ReadLine();
        }
    }
}
