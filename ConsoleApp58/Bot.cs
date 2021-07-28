using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wow
{
    class Bot
    {
        public Bot() { }
        public char[,] arrangement_bot(char[,] map)
        {
            int[] ships = { 4, 3, 3, 2, 2, 2, 1, 1, 1, 1 };
            for (int i = 0; i < ships.Length; i++)
            {
                Ship ship1 = new Ship();
                ship1.filling(map, ships[i], 1, i);
            }
            return map;
        }
    }
}
