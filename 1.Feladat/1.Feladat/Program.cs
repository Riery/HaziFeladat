using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Feladat
{
    class Program
    {
        public static string Prim(int x)
        {
            int a = 2;
            while (x % a != 0 && a <= x / 2)
                a++;
            if (a <= x / 2)
                return "Nem Prímszám";
                return "Prímszám";
        }//Prím vizsgálat.
        static void Main(string[] args)
        {  

            Console.WriteLine("Írj be egy pozitív egész számot:");
            bool eldontes = false;
            int szam = 0;

            while(!eldontes || szam < 2)//Beírt karakter vizsgálata.
            {
                eldontes = int.TryParse(Console.ReadLine(), out szam);
                if (!eldontes || szam<2)
                {
                    Console.WriteLine("Pozitív egész számot írj be !");
                }

            }
            Console.WriteLine(Prim(szam));
            Console.WriteLine("Nyomj egy karaktert a kilépéshez");
            Console.ReadLine();

        }
    }
}
