using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AiBattleShipGame
{
    class AIGuess
    {
        static void AI()
        {
            string[] points = File.ReadAllLines(@"C:\Users\Student\Documents\GitHub\AI-Group-Project\Battleships AI\Battleships AI\AIPoints.txt");
            bool hit = false;

            if (hit == true)
            {
                PointsChange(X, Y, 5);
            }
            else
            {
                PointsChange(X, Y, -1);
            }
        }

        static void PointsChange(int CoordX, int CoordY, int Value)
        {
            string[] OldPoints = File.ReadAllLines(@"C:\Users\Student\Documents\GitHub\AI-Group-Project\Battleships AI\Battleships AI\AIPoints.txt");
            string[] NewPoints = new string[10];
            string[,] PointsArray = new string[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    string[] PointList = OldPoints[i].Split(",");
                    PointsArray[i, j] = PointList[j];
                }
            }
            //Console.WriteLine(OldPoints[CoordX]);
            int Points = Convert.ToInt32(PointsArray[CoordX, CoordY]);
            Points += Value;

            PointsArray[CoordX, CoordY] = Convert.ToString(Points);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    NewPoints[i] += PointsArray[i, j];
                    if (j != 9)
                    {
                        NewPoints[i] += ",";
                    }

                }
            }

            System.IO.File.WriteAllLines(@"C:\Users\Student\Documents\GitHub\AI-Group-Project\Battleships AI\Battleships AI\AIPoints.txt", NewPoints);
        }

    }
}
