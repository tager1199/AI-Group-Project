using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiBattleShipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetWindowSize(width, height); max width is 320, max height is 86
            Console.SetWindowSize(120, 36);



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
            Console.WriteLine("\t-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");




            string[,] battleship_matrix = new string[10, 10] {{ "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" }};  //creates a matrix 10x10 (rows then columns) of 0's aka nothing placed there

            string[,] battleship_matrix_test = new string[10, 10] {{ "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                                        { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" }};





            string aircraft_carrier = "A";
            string shipA = "Aircraft Carrier";
            int sizeA = 5;
            bool deployingA = true;

            string battleship = "B";
            string shipB = "Battleship";
            int sizeB = 4;
            bool deployingB = false;

            string cruiser = "C";
            string shipC = "Cruiser";
            int sizeC = 3;
            bool deployingC = false;

            string submarine = "S";
            string shipS = "Submarine";
            int sizeS = 3;
            bool deployingS = false;

            string destroyer = "D";
            string shipD = "Destroyer";
            int sizeD = 2;
            bool deployingD = false;


            string current_ship = "test";
            string current_ship_name = "test";
            int ship_size = 99;




            int start_posX = 111;
            string str_start_posX = "1";
            string char_start_posY = "1";
            string new_char_start_posY = "1";
            int start_posY = 111;
            string direction = "test";
            string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };



            while (deployingA == true || deployingB == true || deployingC == true || deployingS == true || deployingD)
            {
                if (deployingA == true)
                {

                    current_ship = aircraft_carrier; //current ship deploying goes here
                    current_ship_name = shipA;
                    ship_size = sizeA;
                }
                else if (deployingB == true)
                {
                    current_ship = battleship; //current ship deploying goes here
                    current_ship_name = shipB;
                    ship_size = sizeB;
                }
                else if (deployingC == true)
                {

                    current_ship = cruiser; //current ship deploying goes here
                    current_ship_name = shipC;
                    ship_size = sizeC;
                }
                else if (deployingS == true)
                {

                    current_ship = submarine; //current ship deploying goes here
                    current_ship_name = shipS;
                    ship_size = sizeS;
                }
                else if (deployingD == true)
                {

                    current_ship = destroyer; //current ship deploying goes here
                    current_ship_name = shipD;
                    ship_size = sizeD;
                }
                else
                {
                    Console.WriteLine("\n\t FINISHED DEPLOYMENT OF ALL SHIPS...");
                }


                ///CODE TO DEPLOY SHIP
                bool no_valid_direction = true;
                int collision_error_count = 0;

                while (no_valid_direction == true)
                {
                    no_valid_direction = false;
                    collision_error_count = 0;


                    bool error = true;
                    while (error == true)
                    {
                        error = false;

                        Console.WriteLine("\n\nYou are now deploying the {0}, size {1}", current_ship_name, ship_size);
                        Console.WriteLine("\nChoose your starting position on the 'y' axis for the ship (A-J):");
                        char_start_posY = Console.ReadLine();
                        char_start_posY = char_start_posY.ToUpper();

                        switch (char_start_posY)
                        {
                            case "A":
                                //Console.WriteLine("A choosen");
                                start_posY = 1;
                                break;
                            case "B":
                                //Console.WriteLine("B choosen");
                                start_posY = 2;
                                break;
                            case "C":
                                //Console.WriteLine("C choosen");
                                start_posY = 3;
                                break;
                            case "D":
                                //Console.WriteLine("D choosen");
                                start_posY = 4;
                                break;
                            case "E":
                                //Console.WriteLine("E choosen");
                                start_posY = 5;
                                break;
                            case "F":
                                //Console.WriteLine("F choosen");
                                start_posY = 6;
                                break;
                            case "G":
                                //Console.WriteLine("G choosen");
                                start_posY = 7;
                                break;
                            case "H":
                                //Console.WriteLine("H choosen");
                                start_posY = 8;
                                break;
                            case "I":
                                //Console.WriteLine("I choosen");
                                start_posY = 9;
                                break;
                            case "J":
                                //Console.WriteLine("J choosen");
                                start_posY = 10;
                                break;
                            default:
                                //Console.WriteLine("\tPlease enter only 1 valid letter from A-J.\n");
                                error = true;
                                break;
                        }

                    }

                    error = true;
                    bool check_int;
                    while (error == true)
                    {
                        error = false;

                        Console.WriteLine("\nChoose your starting position on the 'x' axis for the ship (1-10):");

                        str_start_posX = Console.ReadLine();  //player enters A1 as starting pos for their ships deployment - NEED TO CHANGE LETTER INT NUMBER
                        check_int = Int32.TryParse(str_start_posX, out start_posX);

                        if (check_int == false || start_posX >= 11 || start_posX <= 0)
                        {
                            //failed conversion to int aka was not a valid input
                            Console.WriteLine("\tPlease enter a valid number between 1-10.\n");
                            error = true;
                        }


                    }

                    int count = 0;
                    bool successful_deployment = true;
                    int ship_size_temp = ship_size;




                    error = true;
                    while (error == true || successful_deployment == false)
                    {
                        error = false;
                        successful_deployment = true;

                        Console.WriteLine("\nWhat direction will the ship be deployed in from the starting position? (left, right, up, down)");
                        direction = Console.ReadLine();
                        ////////////////before direction is set, limit the users guesses depending on their starting pos. eg/starting at A1 means they cannot deploy up or left because they is not space for the current ship size
                        switch (direction)
                        {
                            case "left":
                                Console.WriteLine("Left choosen");

                                successful_deployment = false;
                                if (successful_deployment == false)
                                {
                                    successful_deployment = true;

                                    if (start_posX - ship_size >= 0)
                                    {
                                        successful_deployment = true;

                                        while (ship_size_temp != count && successful_deployment == true)
                                        {
                                            if (battleship_matrix_test[start_posY - 1, start_posX - ship_size_temp] == "0")  //if the space is empty before placement, then you can change position
                                            {
                                                successful_deployment = true;

                                                ship_size_temp--;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\n\n\tERROR! SHIP PLACEMENT WOULD COLLIDE WITH ANOTHER SHIP!\n\n\t--Please Choose a new direction to place ship--");
                                                successful_deployment = false;  //space attempting to deploy in was not empty beforehand
                                                                                //if this is trigured at anytime, it should loop back to choosing a new direction (or maybe instead choosing new X and Y coords?)
                                                collision_error_count++;
                                            }


                                        }
                                        ship_size_temp = ship_size; //reset ship_size or count to what it should be for future runs
                                    }
                                    else
                                    {
                                        successful_deployment = false;
                                    }
                                }


                                if (successful_deployment == true)
                                {
                                    while (ship_size_temp != count)
                                    {
                                        battleship_matrix[start_posY - 1, start_posX - ship_size_temp] = current_ship;
                                        battleship_matrix_test[start_posY - 1, start_posX - ship_size_temp] = current_ship;
                                        Console.WriteLine("Deployment: {0}{1}", char_start_posY, start_posX - ship_size_temp + 1);
                                        ship_size_temp--;
                                    }
                                    ship_size_temp = ship_size;
                                }

                                break;

                            case "right":
                                Console.WriteLine("Right choosen");


                                successful_deployment = false;
                                if (successful_deployment == false) //error check to preemtively check if ship deployment in direction would collide with another ship already placed
                                {                                   ///HAVE NOT ADDED FIX IF USER CANNOT PLACE A SHIP IN ANY DIRECTION WITHOUT COLLIDING OR GOING OUT OF BOUNDS
                                                                    ///FIX IN THIS SCENARIO WOULD BE TO FORCE USER TO CHOOSE A NEW STARTING LOCATION
                                    successful_deployment = true;   ///

                                    if (start_posX + ship_size <= 11)
                                    {
                                        successful_deployment = true;

                                        while (count != ship_size && successful_deployment == true)
                                        {

                                            if (battleship_matrix_test[start_posY - 1, start_posX + count - 1] == "0")  //if the space is empty before placement, then you can change position
                                            {
                                                successful_deployment = true;

                                                count++;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\n\n\tERROR! SHIP PLACEMENT WOULD COLLIDE WITH ANOTHER SHIP!\n\n\t--Please Choose a new direction to place ship--");
                                                successful_deployment = false;  //space attempting to deploy in was not empty beforehand
                                                                                //if this is trigured at anytime, it should loop back to choosing a new direction (or maybe instead choosing new X and Y coords?)
                                                collision_error_count++;

                                            }

                                        }

                                        count = 0;
                                    }
                                    else
                                    {
                                        successful_deployment = false;
                                    }
                                }



                                if (successful_deployment == true)
                                {
                                    while (count != ship_size)
                                    {
                                        battleship_matrix[start_posY - 1, start_posX + count - 1] = current_ship;
                                        battleship_matrix_test[start_posY - 1, start_posX + count - 1] = current_ship;
                                        Console.WriteLine("Deployment: {0}{1}", char_start_posY, start_posX + count);
                                        count++;
                                    }
                                    count = 0;
                                }

                                break;

                            case "up":
                                Console.WriteLine("Up choosen");

                                successful_deployment = false;
                                if (successful_deployment == false)
                                {
                                    successful_deployment = true;

                                    if (start_posY - ship_size >= 0)
                                    {
                                        successful_deployment = true;

                                        while (ship_size_temp != count && successful_deployment == true)
                                        {

                                            if (battleship_matrix_test[start_posY - ship_size_temp, start_posX - 1] == "0")  //if the space is empty before placement, then you can change position
                                            {
                                                successful_deployment = true;

                                                ship_size_temp--;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\n\n\tERROR! SHIP PLACEMENT WOULD COLLIDE WITH ANOTHER SHIP!\n\n\t--Please Choose a new direction to place ship--");
                                                successful_deployment = false;  //space attempting to deploy in was not empty beforehand
                                                                                //if this is trigured at anytime, it should loop back to choosing a new direction (or maybe instead choosing new X and Y coords?)
                                                collision_error_count++;

                                            }

                                        }
                                        ship_size_temp = ship_size;

                                    }
                                    else
                                    {
                                        successful_deployment = false;
                                    }
                                }



                                if (successful_deployment == true)
                                {
                                    while (ship_size_temp != count)
                                    {
                                        battleship_matrix[start_posY - ship_size_temp, start_posX - 1] = current_ship;
                                        battleship_matrix_test[start_posY - ship_size_temp, start_posX - 1] = current_ship;

                                        new_char_start_posY = letters[(start_posY - ship_size_temp)];  //would have -1 cause array but already had +1 cause of loop style
                                        Console.WriteLine("Deployment: {0}{1}", new_char_start_posY, start_posX);
                                        ship_size_temp--;
                                    }
                                    ship_size_temp = ship_size;

                                }


                                break;

                            case "down":
                                Console.WriteLine("Down choosen");

                                successful_deployment = false;
                                if (successful_deployment == false)
                                {
                                    successful_deployment = true;

                                    if (start_posY + ship_size <= 11)
                                    {
                                        successful_deployment = true;

                                        while (count != ship_size && successful_deployment == true)
                                        {

                                            if (battleship_matrix_test[start_posY + count - 1, start_posX - 1] == "0")  //if the space is empty before placement, then you can change position
                                            {
                                                successful_deployment = true;

                                                count++;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\n\n\tERROR! SHIP PLACEMENT WOULD COLLIDE WITH ANOTHER SHIP!\n\n\t--Please Choose a new direction to place ship--");
                                                successful_deployment = false;  //space attempting to deploy in was not empty beforehand
                                                                                //if this is trigured at anytime, it should loop back to choosing a new direction (or maybe instead choosing new X and Y coords?)
                                                collision_error_count++;

                                            }

                                        }

                                        count = 0;
                                    }
                                    else
                                    {
                                        successful_deployment = false;
                                    }
                                }


                                if (successful_deployment == true)
                                {
                                    while (count != ship_size)
                                    {
                                        battleship_matrix[start_posY + count - 1, start_posX - 1] = current_ship;
                                        battleship_matrix_test[start_posY + count - 1, start_posX - 1] = current_ship;
                                        new_char_start_posY = letters[(start_posY + count - 1)];  //-1 cause array
                                        Console.WriteLine("Deployment: {0}{1}", new_char_start_posY, start_posX);
                                        count++;
                                    }

                                    count = 0;

                                }

                                break;
                            default:
                                Console.WriteLine("\tPlease enter 'left', 'right', 'up' or 'down' for your deployment direction.\n");
                                error = true;
                                break;
                        }

                        if (successful_deployment == false)
                        {
                            if (collision_error_count >= 2)
                            {
                                Console.WriteLine("\t\nERROR!! NO VALID DIRECTION FOR CURRENT DEPLOYMENT.\n\t--Please choose a new starting position--\n");
                                no_valid_direction = true;

                                //these are set to escape the main while loop and go back 
                                error = false;
                                successful_deployment = true;
                            }
                            else
                            {
                                Console.WriteLine("\tPlease choose a direction with enough space for deployment of:\n\t\tShip '{0}'\n\t\tSize '{1}'.\n", current_ship_name, ship_size);

                            }
                        }
                    }
                }

                ///CODE TO DEPLOY CURRENT SHIP

                if (deployingA == true)
                {
                    deployingA = false;
                    deployingB = true;
                }
                else if (deployingB == true)
                {
                    deployingB = false;
                    deployingC = true;
                }
                else if (deployingC == true)
                {
                    deployingC = false;
                    deployingS = true;
                }
                else if (deployingS == true)
                {
                    deployingS = false;
                    deployingD = true;
                }
                else if (deployingD == true)
                {
                    deployingD = false;
                }
                else
                {
                    Console.WriteLine("\n\tALL SHIPS SET TO FALSE  AKA  ALL SHIPS DEPLOYED");
                }

            }

            Console.WriteLine("\n\n\n\tPreparing to create player deployment...\n");
            Console.WriteLine("\t________________________________________________________________________________________");
            Console.WriteLine("\t|       |       |       |       |       |       |       |       |       |       |       |");
            Console.WriteLine("\t|       |   1   |   2   |   3   |   4   |   5   |   6   |   7   |   8   |   9   |   10  |");
            Console.WriteLine("\t|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|");

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("\t|       |       |       |       |       |       |       |       |       |       |       |");
                Console.Write("\t|  {0}    ", letters[j]);

                for (int k = 0; k < 10; k++)
                {

                    if (battleship_matrix[j, k] == "0") //hides all the "0"'s that represent the empty spaces to the player
                    {
                        //Console.Write("|       ");
                        Console.Write("|");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("   ~   ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("|   ");
                        //Console.Write("|   {0}   ", battleship_matrix[j, k]);

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("{0}   ", battleship_matrix[j, k]);
                        Console.ResetColor();

                    }

                    if (k == 9)
                    {
                        Console.Write("|");
                    }
                }
                Console.Write("\n");
                Console.WriteLine("\t|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|_______|");
            }

            //check to make sure after running variables have returned/ maintained to the original state
            //Console.WriteLine("\nYour starting position for {0}, will be: {1}{2}", ship, char_start_posY, start_posX);

            Console.ReadLine();
        }
    }
}
