using AiBattleshipGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiBattleShipGame
{
    class AITakeShot
    {

        string[,] grid = new string[10, 10] {{ "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                            { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                            { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                            { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                            { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                            { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                            { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                            { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                            { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                                            { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" }};

        int x = 0;
        int y = 0;
        int NewX = 0; //New x of the AIshot
        int NewY = 0; //New Y of the Aishot
        bool LastShotHit = false;
        char Last_Direction_Hit = 'U'; //To store the last correct hit of a shot? (U - UP, D - Down, R - Right, L - Left)
        bool hit = false;
        bool shipSunk = false;
        bool aiTurn = false;
        
        


        public void TakeShotAI()
        {
            
            if( aiTurn == true && hit == true)
            {
                AttackUp();
                if(Last_Direction_Hit == 'U')
                {
                    AttackUp();
                }
                else if(LastShotHit == false)
                {
                    AttackDown();
                }
                
                                                            //Needs testing and there is currently no way to test as program isnt complete. May require aditional code/changes making.
                
            }
            if (aiTurn == true && hit == true)
            {
                AttackRight();
                if (Last_Direction_Hit == 'R')
                {
                    AttackRight();
                }
                else if(LastShotHit == false)
                {
                    AttackLeft();
                }
            }



        }

   


        //Need to merge code from Toms section to this to determine if a shot has hit, if it has then proceed, if missed take another random shot?


        public void AttackRight()
        {
            if (LastShotHit == true)
            {
                NewX = x + 1;
                while (NewX == 'A' || NewX == 'B' || NewX == 'C' || NewX == 'D' || NewX == 'S')
                {
                    Last_Direction_Hit = 'R';
                    LastShotHit = true;
                    hit = true;
                    NewX = x + 1;
                }

            }

            else if (NewX == '0')
            {
                LastShotHit = false;
                hit = false;
                Console.WriteLine("The AI missed, trying new direction next shot");
                //AttackLeft();
            }

           
        }

        public void AttackLeft()
        {
            if (LastShotHit == true)
            {
                NewX = x - 1;
                while (NewX == 'A' || NewX == 'B' || NewX == 'C' || NewX == 'D' || NewX == 'S')
                {
                    Last_Direction_Hit = 'L';
                    hit = true;
                    NewX = x - 1;
                }

            }
            else if (NewX == '0')
            {
                LastShotHit = false;
                Console.WriteLine("The AI missed, trying new direction next shot");
                //AttackRight();
            }

         
        }

        public void AttackUp()
        {
            if (LastShotHit == true)
            {
                NewY = y + 1;
                while (NewX == 'A' || NewX == 'B' || NewX == 'C' || NewX == 'D' || NewX == 'S')
                {
                    Last_Direction_Hit = 'U';
                    hit = true;
                    NewX = y + 1;
                }

            }
            else if (NewY == '0')
            {
                LastShotHit = false;
                Console.WriteLine("The AI missed, trying new direction next shot");
                //AttackDown();
            }

           
        }

        public void AttackDown()
        {
            if (LastShotHit == true)
            {
                NewY = y - 1;
                while (NewX == 'A' || NewX == 'B' || NewX == 'C' || NewX == 'D' || NewX == 'S')
                {
                    Last_Direction_Hit = 'D';
                    hit = true;
                    NewY = y - 1;
                }

            }
            else if (NewY == '0')
            {
                LastShotHit = false;
                Console.WriteLine("The AI missed, trying new direction next shot");
                //AttackUp();
            }

           
        }

    }
}
