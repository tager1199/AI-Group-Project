using System;
using System.Collections.Generic;
using System.Text;

namespace AiBattleShipGame
{
    class PlayerDeployment
    {

        Grid grid;

        public PlayerDeployment(Grid grid)
        {
            this.grid = grid;
        }

        public void enterShips()
        {
            int shipsPlaced = 0;
            string[] shipNames = { "Aircraft Carrier", "Battleship", "Cruiser", "Submarine", "Destroyer" };
            int[] shipLengths = { 5, 4, 3, 3, 2 };

            while (shipsPlaced < 5)
            {
                int x, y;
                bool horizontal = false,
                     overlap = false;

                Console.WriteLine("Please enter the start x coordinate for {0}:", shipNames[shipsPlaced]);
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the start y coordinate:");
                y = int.Parse(Console.ReadLine());

                while (true)
                {
                    Console.WriteLine("Would you like to place this horizontally (h) or vertically (v)?");
                    string direction = Console.ReadLine().ToLower();
                    if (direction == "h" || direction == "v")
                    {
                        horizontal = (direction == "h");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter h or v.");
                    }
                }

                if ((horizontal && x + shipLengths[shipsPlaced] >= 10) || (!horizontal && y + shipLengths[shipsPlaced] >= 10))
                {
                    Console.WriteLine("Your ship goes off the grid! Try again!");
                    continue;
                }

                for (int i = 0; i < shipLengths[shipsPlaced]; i++)
                {
                    int tempX = horizontal ? (x + i) : x;
                    int tempY = horizontal ? y : (y + i);
                    overlap = (grid.values[tempX, tempY] != ' ');
                    if (overlap)
                        break;
                }

                if (overlap)
                {
                    Console.WriteLine("That space is occupied.\nPlease try again.");
                    continue;
                }

                for (int i = 0; i < shipLengths[shipsPlaced]; i++)
                {
                    int tempX = x,
                        tempY = y;
                    if (horizontal)
                        tempX += i;
                    else
                        tempY += i;

                    grid.values[tempX, tempY] = shipNames[shipsPlaced][0];
                    Console.WriteLine("Position X = {0} , Y = {1}", tempX, tempY);
                }

                shipsPlaced++;

            }
            Console.WriteLine("All ships have been entered. The player grid looks like this:\n");
            grid.display();
        }
    }
}