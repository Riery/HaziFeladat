using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Feladat
{
    class Kacsa
    {
        static int kacsakEletben;

        public static int KacsakEletben
        {
            get { return Kacsa.kacsakEletben; }
            set { Kacsa.kacsakEletben = value; }
        }

        public int pozX;

        public int PozX
        {
            get { return pozX; }
            set { pozX = value; }
        }
        int pozY;

        public int PozY
        {
            get { return pozY; }
            set { pozY = value; }
        }

        bool eletbenVan;

        public bool EletbenVan
        {
            get { return eletbenVan; }
            set { eletbenVan = value; }
        }

        Pálya aPalyaAminVan;

        public Kacsa(Pálya aPalyaAminVan)
        {
            this.PozX = 0;
            this.PozY = 0;
            this.EletbenVan = true;
            this.aPalyaAminVan = aPalyaAminVan;
            this.Lep();
        }

        public void TalalatotKap()//Ha egy kacsa találatot kap akkor az életbenvan változó értéke hamis lesz
        {
            if(this.EletbenVan)
            {
                this.EletbenVan = false;
                Kacsa.kacsakEletben--;
            }
        }

        public void Lep()
        {
            int direction = Util.RndGen.Next(3);//Random alkalmazása a lépésekhez
            if (this.EletbenVan)
            {

                if (direction == 0 && aPalyaAminVan.VanEIlyenMezo(this.PozX + 1, this.PozY))
                {
                    this.PozX++;
                }
                else if (direction == 1 && aPalyaAminVan.VanEIlyenMezo(this.PozX + 1, this.PozY + 1))
                {
                    this.PozX++;
                    this.PozY++;
                }
                else if (direction == 2 && aPalyaAminVan.VanEIlyenMezo(this.PozX, this.PozY + 1))
                {
                    this.PozY++;
                }
            }
        }

        public double Tavolsag()//Távolság mérő légvonalban
        {
            return Math.Sqrt(Math.Pow(this.PozX - this.aPalyaAminVan.TargetX, 2) + Math.Pow(this.PozY - this.aPalyaAminVan.TargetY, 2));
        }
    }
}
