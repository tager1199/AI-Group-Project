using AiBattleShipGame;
using System;
using System.Collections.Generic;
using System.Linq;
using 
using System.Text;
using System.Threading.Tasks;

namespace Battleship_Interface
{
    class GameBoard
    {
        static void Main(string[] args)
        {
            Grid gameGrid = new Grid();

            printTitle();

            //You'd probably have this all in seperate functions
            Console.WriteLine("Enter cell...\n");
            string userEntry = Console.ReadLine().ToUpper();

            int y = ((int)userEntry[0] - 65);
            int x = ((int)userEntry[1] - 48);

            //Can check value by:
            if (gameGrid.values[x, y] == ' ')
            {
                Console.WriteLine("Miss!");
            }
            //It's empty
            else if (gameGrid.values[x, y] == 'S')
            {
                Console.WriteLine("Hit!");
            }

            else if (gameGrid.values[x, y] == 'B')
            {
                Console.WriteLine("Hit!");
            }

            else if (gameGrid.values[x, y] == 'A')
            {
                Console.WriteLine("Hit!");
            }

            else if (gameGrid.values[x, y] == 'D')
            {
                Console.WriteLine("Hit!");
            }

            else if (gameGrid.values[x, y] == 'C')
            {
                Console.WriteLine("Hit!");
            }



            Console.WriteLine("\n\n\n");
            Console.WriteLine("The Ships are:\n(A) Aircraft carrier = 5, (B) Battleship = 4, (C) Cruiser = 3, (S) Submarine = 3, (D) Destroyer = 2\n");
            Console.WriteLine("Hit = X, Miss = 0/o/O, Empty = -/or blank\n");
            Console.WriteLine("\t________________________________________________________________________________________");
            Console.WriteLine("\t|       |       |       |       |       |       |       |       |       |       |       |");
            Console.WriteLine("\t|       |   1   |   2   |   3   |   4   |   5   |   6   |   7   |   8   |   9   |   10  |");
            Console.WriteLine("\t|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|");
            Console.WriteLine("\t|       |       |       |       |       |       |       |       |       |       |       |");
            Console.WriteLine("\t|  A    |       |       |       |       |       |   X   |   A   |   A   |   A   |   A   |");
            Console.WriteLine("\t|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|");
            Console.WriteLine("\t|       |       |       |       |       |       |       |       |       |       |       |");
            Console.WriteLine("\t|  B    |       |       |       |       |       |   0   |       |       |   D   |       |");
            Console.WriteLine("\t|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|");
            Console.WriteLine("\t|       |       |       |       |       |       |       |       |       |       |       |");
            Console.WriteLine("\t|  C    |   s   |       |       |       |   0   |       |       |       |   D   |       |");
            Console.WriteLine("\t|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|");
            Console.WriteLine("\t|       |       |       |       |       |       |       |       |       |       |       |");
            Console.WriteLine("\t|  D    |   s   |       |       |       |       |       |       |       |       |       |");
            Console.WriteLine("\t|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|");
            Console.WriteLine("\t|       |       |       |       |       |       |       |       |       |       |       |");
            Console.WriteLine("\t|  E    |   s   |       |       |       |       |   o   |   o   |       |       |       |");
            Console.WriteLine("\t|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|");
            Console.WriteLine("\t|       |       |       |       |       |       |       |       |       |       |       |");
            Console.WriteLine("\t|  F    |       |       |       |       |   B   |   X   |   X   |   B   |       |       |");
            Console.WriteLine("\t|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|");
            Console.WriteLine("\t|       |       |       |       |       |       |       |       |       |       |       |");
            Console.WriteLine("\t|  H    |       |       |       |       |       |       |       |   O   |       |       |");
            Console.WriteLine("\t|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|");
            Console.WriteLine("\t|       |       |       |       |       |       |       |       |       |       |       |");
            Console.WriteLine("\t|  I    |       |       |       |       |       |       |       |   O   |       |       |");
            Console.WriteLine("\t|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|");
            Console.WriteLine("\t|       |       |       |       |       |       |       |       |       |       |       |");
            Console.WriteLine("\t|  J    |       |       |       |   X   |   C   |   C   |   C   |       |       |       |");
            Console.WriteLine("\t|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|");
            Console.WriteLine("\t|       |       |       |       |       |       |       |       |       |       |       |");
            Console.WriteLine("\t|  K    |       |       |       |       |       |       |       |       |       |       |");
            Console.WriteLine("\t|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|");






            Console.ReadLine();


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