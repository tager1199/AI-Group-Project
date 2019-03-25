using System;
using System.Collections.Generic;
using System.Text;

namespace AiBattleShipGame
{
    class AIGuess
    {
        public AIGuess()
        {
            string[] points = File.ReadAllLines(@"D:\Documents\1983\AI-Group-Project\Battleships AI\Battleships AI\AIPoints.txt");
            foreach (string line in points)
            {
                //points[i][j] = line.Split(' ');
                //Console.WriteLine(points);
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.WriteLine(points[i][j]);
                    }
                }
                PointsUp(0, 0);
                PointsUp(6, 0);
                PointsUp(0, 0);
                PointsUp(6, 0);
                PointsUp(0, 0);
                Console.ReadLine();
            }
        }

        static void PointsUp(int CoordX, int CoordY)
        {
            string[] OldPoints = File.ReadAllLines(@"D:\Documents\1983\AI-Group-Project\Battleships AI\Battleships AI\AIPoints.txt");
            string[] NewPoints = OldPoints;
            int Points = Convert.ToInt32(OldPoints[CoordX][CoordY]);
            Points += 5;

            string str = OldPoints[CoordX];
            StringBuilder newPoints = new StringBuilder(str);
            newPoints[CoordY] = Convert.ToChar(Convert.ToString(Points));
            NewPoints[CoordX] = Convert.ToString(newPoints);

            System.IO.File.WriteAllLines(@"D:\Documents\1983\AI-Group-Project\Battleships AI\Battleships AI\AIPoints.txt", NewPoints);
        }

    }
}
