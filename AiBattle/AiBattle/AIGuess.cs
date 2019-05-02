using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AiBattle
{
    class AIGuess
    {
        string path = Directory.GetCurrentDirectory();
        public string[,] AI(string[,] playerGrid, string[,] HitArray)
        {

            string[] points = File.ReadAllLines(@path + "\\AIPoints.txt");
            string[,] PArray = new string[10, 10];
            
            int[] maxPoints = new int[] {-10000, -10000, -10000, -10000, -10000};
            int tempPoints;
            int tempX;
            int tempY;
            int X = 0;
            int Y = 0;
            int[,] maxCoords = new int[5, 2] { {0, 0}, {0, 1}, {0, 2}, {0, 3}, {0, 4} };
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    string[] PointList = points[i].Split(',');
                    PArray[i, j] = PointList[j];
                    if (HitArray[i, j] != "hit"){
                        if (Int32.Parse(PArray[i, j]) > maxPoints[4])
                        {
                            tempPoints = maxPoints[4];
                            tempX = maxCoords[4, 0];
                            tempY = maxCoords[4, 1];
                            maxPoints[4] = Int32.Parse(PArray[i, j]);
                            maxCoords[4, 0] = i;
                            maxCoords[4, 1] = j;
                        }
                        else if (Int32.Parse(PArray[i, j]) > maxPoints[3])
                        {
                            tempPoints = maxPoints[3];
                            tempX = maxCoords[3, 0];
                            tempY = maxCoords[3, 1];
                            maxPoints[3] = Int32.Parse(PArray[i, j]);
                            maxCoords[3, 0] = i;
                            maxCoords[3, 1] = j;
                        }
                        else if (Int32.Parse(PArray[i, j]) > maxPoints[2])
                        {
                            tempPoints = maxPoints[2];
                            tempX = maxCoords[2, 0];
                            tempY = maxCoords[2, 1];
                            maxPoints[2] = Int32.Parse(PArray[i, j]);
                            maxCoords[2, 0] = i;
                            maxCoords[2, 1] = j;
                        }
                        else if (Int32.Parse(PArray[i, j]) > maxPoints[1])
                        {
                            tempPoints = maxPoints[1];
                            tempX = maxCoords[1, 0];
                            tempY = maxCoords[1, 1];
                            maxPoints[1] = Int32.Parse(PArray[i, j]);
                            maxCoords[1, 0] = i;
                            maxCoords[1, 1] = j;
                        }
                        else if (Int32.Parse(PArray[i, j]) > maxPoints[0])
                        {
                            maxPoints[0] = Int32.Parse(PArray[i, j]);
                            maxCoords[0, 0] = i;
                            maxCoords[0, 1] = j;
                        }
                    }
                    
                }
            }

            int randNum = rand.Next(0, 4);
            if (randNum == 0)
            {
                X = maxCoords[4, 0];
                Y = maxCoords[4, 1];
            }
            else if (randNum == 1)
            {
                X = maxCoords[3, 0];
                Y = maxCoords[3, 1];
            }
            else if (randNum == 2)
            {
                X = maxCoords[2, 0];
                Y = maxCoords[2, 1];
            }
            else if (randNum == 3)
            {
                X = maxCoords[1, 0];
                Y = maxCoords[1, 1];
            }
            else
            {
                X = maxCoords[0, 0];
                Y = maxCoords[0, 1];
            }

            HitArray[X, Y] = "hit";
            string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            if (playerGrid[X, Y] == "0")
            {
                PointsChange(X, Y, 5, PArray);
                Console.WriteLine("The AI guessed at: " + letters[X] + " " + Y);
                Console.WriteLine("It Hit");
            }
            else
            {
                PointsChange(X, Y, -1, PArray);
                Console.WriteLine("The AI guessed at: " + letters[X] + " " + Y);
                Console.WriteLine("It Missed");
            }
            return HitArray;
        }

        static void PointsChange(int CoordX, int CoordY, int Value, string[,] PointsArray)
        {
            string[] OldPoints = File.ReadAllLines(@path + "\\AIPoints.txt");
            string[] NewPoints = new string[10];

            //Console.WriteLine(OldPoints[CoordX]);
            int Points = Int32.Parse(PointsArray[CoordX, CoordY]);
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

            System.IO.File.WriteAllLines(@path + "\\AIPoints.txt", NewPoints);
        }
    }
}
