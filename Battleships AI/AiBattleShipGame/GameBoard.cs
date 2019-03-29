using AiBattleshipGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiBattleShipGame
{
    class GameBoard
    {
        public struct hitCount
        {
            public char shipType;
            public int x;
            public int y;

            public hitCount(char s, int x, int y)
            {
                this.shipType = s;
                this.x = x;
                this.y = y;
            }
        }
        static Dictionary<char, int> shipSizes = new Dictionary<char, int>
        {
            {'A', 5},
            {'B', 4},
            {'S', 3},
            {'C', 3},
            {'D', 2 }
        };

        static void Main(string[] args)
        {
            Grid gameGrid = new Grid();
            var hits = new List<hitCount>();
            AiDeployment aiDeployment = new AiDeployment(gameGrid);
            aiDeployment.runAI();
            int shipsSunk = 0;

            printTitle();

            //Can check value by:
            while(shipsSunk < 5)
            {
                userPlay(gameGrid, hits, ref shipsSunk);
            }
            Console.WriteLine("All ships sunk");
            Console.ReadLine();
        }

        public static void userPlay(Grid grid, List<hitCount> hits, ref int shipsSunk)
        {
            Console.WriteLine("Enter X value:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y value:");
            int y = int.Parse(Console.ReadLine());

            if (hits.Any(c => (c.x == x && c.y == y)))
            {
                Console.WriteLine("You have already hit this location.");
            }
            else if (grid.values[x,y] == ' ')
            {
                Console.WriteLine("Miss!");
            }
            else if (grid.values[x, y] != ' ')
            {
                Console.WriteLine("Hit!");

                hits.Add(new hitCount(grid.values[x, y], x, y));

                if (hits.Where(h => h.shipType == grid.values[x, y]).Count() == shipSizes[grid.values[x, y]])
                {
                    string ship;
                    switch (grid.values[x, y])
                    {
                        case 'A':
                            ship = "aircraft carrier";
                            break;
                        case 'B':
                            ship = "battleship";
                            break;
                        case 'C':
                            ship = "cruiser";
                            break;
                        case 'D':
                            ship = "destroyer";
                            break;
                         default:
                            ship = "submarine";
                            break;
                    }
                    Console.WriteLine("You sunk my {0}!", ship);
                    shipsSunk++;
                }

            }
        }

        public static void printTitle()
        {
            Console.WriteLine("\t  ___  _____   ______       _   _   _           _     _       ");
            Console.WriteLine("\t / _ \\|_   _|  | ___ \\     | | | | | |         | |   (_)      ");
            Console.WriteLine("\t/ /_\\ \\ | |    | |_/ / __ _| |_| |_| | ___  ___| |__  _ _ __  ");
            Console.WriteLine("\t|  _  | | |    | ___ \\/ _` | __| __| |/ _ \\/ __| '_ \\| | '_ \\ ");
            Console.WriteLine("\t| | | |_| |_   | |_/ / (_| | |_| |_| |  __/\\__ \\ | | | | |_) |");
            Console.WriteLine("\t\\_| |_/\\___/   \\____/ \\__,_|\\__|\\__|_|\\___||___/_| |_|_| .__/ ");
            Console.WriteLine("\t                                                       | |    ");
            Console.WriteLine("\t                                                       |_|    ");
            Console.WriteLine("\t                                                              ");
            Console.WriteLine("\t-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine("\t-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

        }
    }
}