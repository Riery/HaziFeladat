using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Feladat
{
    enum JatekAllapot { Folytatodik, KacsakNyertek, JatekosNyert }
    class Program
    {
        static void Main(string[] args)
        {
            Pálya tesztPalya = new Pálya(5, 10, 4,9);//Pálya létrehozása
            Kacsa[] csapat = new Kacsa[10];//csapat tömb amiben a kacsák vannak
            Kacsa.KacsakEletben = 10;
            

            for (int i = 0; i < csapat.Length; i++)
            {
                csapat[i] = new Kacsa(tesztPalya);
            }
            int levono = 0;
            int tarolo=0;
            while (Util.JatekAktualisAllapota(csapat) == JatekAllapot.Folytatodik)//Amíg van élő kacsa addig a while ciklusban marad
            {

                Console.Clear();
                double legkozelebbi = 10;
                int idx = 0;
                for (int i = 0; i < csapat.Length; i++)
                {
                    if (csapat[i].EletbenVan)
                    {
                        Console.WriteLine("A(z) {0}. Kacsa Pozíciója X:{1},Y:{2}", i + 1, csapat[i].PozX, csapat[i].PozY);//Kacsák pozíciójának a kiirása

                        if (legkozelebbi > csapat[i].Tavolsag())//Minimum kiválasztás a távolság jelzéséhez
                        {
                            legkozelebbi = csapat[i].Tavolsag();
                            idx = i + 1;
                        }
                    }
                    else
                    {
                        levono++;
                    }
                }
                int talalat = levono - 2 * tarolo;
                if (talalat > 0)//Találat jelző
                {
                    Console.WriteLine(talalat + "db találat");
                }
                Console.WriteLine("A legközelebbi Kacsa a(z) {0}. ami {1} távolságra van", idx, Math.Round(csapat[idx - 1].Tavolsag(), 0));
                tarolo = levono;
                Util.Loves(csapat);
                for (int i = 0; i < csapat.Length; i++)//Ha az adott kacsa életben van akkor lép
                {
                    if (csapat[i].EletbenVan)
                    {
                        csapat[i].Lep();
                    }

                }
            }
            Console.WriteLine("A játék véget ért, " + Util.JatekAktualisAllapota(csapat).ToString());
            Console.ReadLine();
        }
    }
}
