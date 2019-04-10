using System;
using System.Collections.Generic;
using System.Text;

namespace AiBattleShipGame
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

        public void display()
        {
            printLine();
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                    Console.Write("|  {0}  ", values[i, j]);
                Console.Write("|");
                Console.WriteLine();
                printLine();

            }
        }

        private void printLine()
        {
            string outV = "------";
            for (int i = 0; i < sizeX; i++)
                Console.Write(outV);
            Console.WriteLine();
        }
    }
}
