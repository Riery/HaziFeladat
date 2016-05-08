using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Feladat
{
    class Pálya
    {
        int dimX;

        public int DimX
        {
            get { return dimX; }
            //set { dimX = value; }
        }
        int dimY;

        public int DimY
        {
            get { return dimY; }
            //set { dimY = value; }
        }

        int targetX;

        public int TargetX
        {
            get { return targetX; }
            //set { targetX = value; }
        }
        int targetY;

        public int TargetY
        {
            get { return targetY; }
            //set { targetY = value; }
        }

        public bool VanEIlyenMezo(int x, int y)//Itt vizsgálja hogy, a kacsának a lépése érvényes-e
        {
            return x < this.DimX && y < this.DimY;
        }

        public Pálya(int dimX, int dimY, int targetX, int targetY)
        {
            this.dimX = dimX;
            this.dimY = dimY;
            this.targetX = targetX;
            this.targetY = targetY;
        }

    }
}
