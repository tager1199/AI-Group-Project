using System;
using System.Collections.Generic;
using System.Text;

namespace AiBattleShipGame
{
    class Grid
    {
        public char[,] values;

        public Grid()
        {
            values = new char[10, 10];
            for (int i = 0; i < values.GetLength(0); i++)
                for (int j = 0; j < values.GetLength(1); j++)
                    values[i, j] = ' ';
        }
    }
}