using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wow
{
    class Iam
    {
         public Iam() { }
        public char[,] arrangement(char[,] map)
        {
            int[] ships = { 4, 3, 3, 2, 2, 2, 1, 1, 1, 1 };
            //===========================================    
            for (int i = 0; i < ships.Length; i++)
            {
                Ship ship1 = new Ship();
                ship1.filling(map, ships[i], 1, i);
            }

            return map;
        }
    }
}
