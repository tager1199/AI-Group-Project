using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIAttackNeighbours
{
    class Program
    {
        int x = 0;
        int y = 0;
        int NewX = 0;
        int NewY = 0;
        bool LastShotHit = false;
        char Last_Direction_Hit = 'U';
        bool hit = false;

        
        public void AttackRight()
        {
            if (LastShotHit == true)
            {
                NewX = x + 1;
                while (NewX == 'A' || NewX == 'B' || NewX == 'C' || NewX == 'D' || NewX == 'S')
                {
                    Last_Direction_Hit = 'R';
                    hit = true;
                    NewX = x + 1;
                }

            }

            else if(NewX == '0')
            {
                LastShotHit = false;
                Console.WriteLine("The AI missed, trying new direction");
            }

            else
            {
                LastShotHit = false;
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
                Console.WriteLine("The AI missed, trying new direction");
            }

            else
            {
                LastShotHit = false;
                
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
                Console.WriteLine("The AI missed, trying new direction");
            }

            else
            {
                LastShotHit = false;
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
                Console.WriteLine("The AI missed, trying new direction");
            }

            else
            {
                LastShotHit = false;
            }
        }
    }
}
