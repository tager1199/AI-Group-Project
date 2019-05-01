using AiBattle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiBattle
{
    class Grid
    {
        public char[,] values;
        public int sizeX = 10;
        public int sizeY = 10;

        public Grid()
        {
            values = new char[sizeX, sizeY];
            for (int i = 0; i < values.GetLength(0); i++)
                for (int j = 0; j < values.GetLength(1); j++)
                    values[i, j] = ' ';
        }
    }
}