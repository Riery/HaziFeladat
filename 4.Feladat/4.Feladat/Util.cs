using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Feladat
{
    class Util
    {
        public static Random RndGen = new Random();//Random generátor
        public static void Loves(Kacsa[] csapat)
        {
            int x = 0;
            int y = 0;
            Console.Write("Adj meg egy x,y koordinátát: ");
            string[] coords = Console.ReadLine().Split(',');//Bekért koordináták tömb-be rendezése
            if (coords.Length > 1)
            {
                while (!int.TryParse(coords[0],out x)&& !int.TryParse(coords[1],out y))
                {
                    Console.WriteLine("Adj meg két pozitív egész számot vesszővel elválasztva.");
                    coords = Console.ReadLine().Split(',');
                }
                foreach (Kacsa egyed in csapat)
                {
                    if (egyed.PozX == int.Parse(coords[0]) && egyed.PozY == int.Parse(coords[1]))
                    {
                        egyed.TalalatotKap();
                    }

                }
            }

        }
        public static JatekAllapot JatekAktualisAllapota(Kacsa[] csapat)//Játék állapot figyelése
        {
            int i = 0;
            while (i < csapat.Length && csapat[i].Tavolsag() != 0)
            {
                i++;
            }
            if (i < csapat.Length)
            {
                return JatekAllapot.KacsakNyertek;
            }
            else if (Kacsa.KacsakEletben < 1)
            {
                return JatekAllapot.JatekosNyert;
            }
            else
            {
                return JatekAllapot.Folytatodik;
            }        
        }
    }
}
