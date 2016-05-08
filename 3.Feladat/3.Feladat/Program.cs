using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Feladat
{
    class Program
    {



        public static void Csere(ref int elso, ref int masodik)
        {
            int seged = elso;
            elso = masodik;
            masodik = seged;
        }//Két elem cseréje
        public static int RekurzivBinarisKereses(int[] x, int bal, int jobb, int ertek)
        {
            if (bal > jobb)
            {
                return 0;
            }
            else
            {
                int center = (bal + jobb) / 2;
                if (x[center] == ertek)
                {
                    return center+1;
                }
                else
                {
                    if (x[center] > ertek)
                    {
                        return RekurzivBinarisKereses(x, bal, center - 1, ertek);
                    }
                    else
                    {
                        return RekurzivBinarisKereses(x, center + 1, jobb, ertek);
                    }
                }
            }
        }
        public static void Rendezes(int[] tomb) //Minimum kiválasztásos rendezés
        {
            for (int i = 0; i < tomb.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < tomb.Length; j++)
                    if (tomb[min] > tomb[j])
                        min = j;
                Csere(ref tomb[i], ref tomb[min]);
            }
        }
        public static string Kiir(int[] tomb)
        {
            string lista = "";
            for (int i = 0; i < tomb.Length; i++)
            {
                lista += tomb[i] + "  ";
            }
            return lista;
        }//Tömb megjelenítése
        static void Main(string[] args)//2. elem probléma
        {
            int[] tomb = new int[5];
            int szam = 2;
            int i = 0;
            Console.WriteLine("Adjon meg 5db számot");
            bool eldontes = false;
            while ((!eldontes || i < 5)) //Karakter vizsgálata
            {
                    eldontes = (int.TryParse(Console.ReadLine(), out szam));
                    if (eldontes && i < 5)
                    {
                        tomb[i] = szam;
                        i++;
                    }
                    else if (!eldontes) //Hibás karakter esetén
                    {
                        Console.WriteLine("Egész számot írj be !");
                    }
                }
            Rendezes(tomb);
            Console.WriteLine(Kiir(tomb));
            int z = 0;
            bool x = false;
            Console.WriteLine("Adjon meg a keresett számot:");
            do
            {
                x = int.TryParse(Console.ReadLine(),out z);
                if (!x)
                {
                    Console.WriteLine("Egész számot írj be!");
                }
            } while (!x);
            
            int a = 0;
            if (RekurzivBinarisKereses(tomb, a, tomb.Length, z) == 0)//Keresés kiértékelése
            {
                Console.WriteLine("A szám nem szerepel a tömb-ben.");
            }
            else
            {
                Console.WriteLine("A szám benne van a tömb-ben.");
            }
            Console.ReadLine();

        }
    }
}
