using AiBattle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiBattle
{

    class AiDeployment
    {

        Grid grid;
        Random rnd;

        public AiDeployment(Grid grid)
        {
            this.grid = grid;
            rnd = new Random();

            //(A) Aircraft carrier = 5 (B) Battleship = 4 (C) Cruiser = 3 (S) Submarine = 3  (D) Destroyer = 2 
            //Battleship AI Placement of Ships
            //By Sheldon McCall
        }

        public void runAI()
        {
            AircraftCarrierAI();      
            BattleshipAI();
            CruiserAI();
            SubmarineAI();
            DestroyerAI();
            Console.WriteLine("\n\n\tAll Opponent Ships Have Been Placed.\n\n");
        }

        private void AircraftCarrierAI()
        {
            int shipSize = 5;
            int maxCoord = grid.sizeX - shipSize;

            int xCoord = rnd.Next(0, 10);
            //Console.WriteLine("AircraftCarrier Start X co-Ordinate is " + xCoord);
            int yCoord = rnd.Next(0, 10);
            //Console.WriteLine("AircraftCarrier Start Y co-Ordinate is " + yCoord);

            int CoinFlipAircraftCarrier = rnd.Next(2);
            while (xCoord > maxCoord && yCoord > maxCoord)
            {
                xCoord = rnd.Next(0, 10);
                //  Console.WriteLine("AircraftCarrier new Start X co-Ordinate is " + xCoord);
                yCoord = rnd.Next(0, 10);
                //Console.WriteLine("AircraftCarrier new Start Y co-Ordinate is " + yCoord);
            }
            if (xCoord > maxCoord)
            {
                //Console.WriteLine("xCoord was Out of Bounds so Coin was flipped");
                CoinFlipAircraftCarrier = 0;
            }
            else if (yCoord > maxCoord)
            {
                //Console.WriteLine("yCoord was Out of Bounds so Coin was flipped");
                CoinFlipAircraftCarrier = 1;
            }
            //Console.WriteLine("Coin Flip Result = " + CoinFlipAircraftCarrier);

            bool overlap = false;
            for (int i = 0; i < shipSize; i++)
            {
                int x = (CoinFlipAircraftCarrier > 0) ? xCoord + i : xCoord;
                int y = (CoinFlipAircraftCarrier < 1) ? yCoord + i : yCoord;
                overlap = (grid.values[x, y] != ' ');
            }
            if (overlap)
            {
                //  Console.WriteLine("The Original Value Overlapped and Was Re-Done\n");
                AircraftCarrierAI();
                return;
            }
            for (int i = 0; i < shipSize; i++)
            {
                int x = (CoinFlipAircraftCarrier > 0) ? xCoord + i : xCoord;
                int y = (CoinFlipAircraftCarrier < 1) ? yCoord + i : yCoord;
                grid.values[x, y] = 'A';
                //Console.WriteLine("Arcraft Carrier Position X = {0} , Y = {1}", x, y);
            }
        }

        private void BattleshipAI()
        {
            int shipSize = 4;
            int maxCoord = grid.sizeX - shipSize;

            int xCoord = rnd.Next(0, 10);
            //Console.WriteLine("Battleship Start X co-Ordinate is " + xCoord);
            int yCoord = rnd.Next(0, 10);
            //Console.WriteLine("Battleship Start Y co-Ordinate is " + yCoord);

            int CoinFlipBattleship = rnd.Next(2);
            while (xCoord > maxCoord && yCoord > maxCoord)
            {
                xCoord = rnd.Next(0, 10);
                //Console.WriteLine("Battleship new Start X co-Ordinate is " + xCoord);
                yCoord = rnd.Next(0, 10);
                //Console.WriteLine("Battleship new Start Y co-Ordinate is " + yCoord);
            }
            if (xCoord > maxCoord)
            {
                //Console.WriteLine("xCoord was Out of Bounds so Coin was flipped");
                CoinFlipBattleship = 0;
            }
            else if (yCoord > maxCoord)
            {
                //Console.WriteLine("yCoord was Out of Bounds so Coin was flipped");
                CoinFlipBattleship = 1;
            }
            //Console.WriteLine("Coin Flip Result = " + CoinFlipBattleship);

            bool overlap = false;
            for (int i = 0; i < shipSize; i++)
            {
                int x = (CoinFlipBattleship > 0) ? xCoord + i : xCoord;
                int y = (CoinFlipBattleship < 1) ? yCoord + i : yCoord;
                overlap = (grid.values[x, y] != ' ');
            }
            if (overlap)
            {
                //Console.WriteLine("The Original Value Overlapped and Was Re-Done\n");
                BattleshipAI();
                return;
            }
            for (int i = 0; i < shipSize; i++)
            {
                int x = (CoinFlipBattleship > 0) ? xCoord + i : xCoord;
                int y = (CoinFlipBattleship < 1) ? yCoord + i : yCoord;
                grid.values[x, y] = 'B';
                //Console.WriteLine("Battleship Position X = {0} , Y = {1}", x, y);
            }
        }

        private void CruiserAI()
        {
            int shipSize = 3;
            int maxCoord = grid.sizeX - shipSize;

            int xCoord = rnd.Next(0, 10);
            //Console.WriteLine("Cruiser Start X co-Ordinate is " + xCoord);
            int yCoord = rnd.Next(0, 10);
            //Console.WriteLine("Cruiser Start Y co-Ordinate is " + yCoord);

            int CoinFlipCruiser = rnd.Next(2);
            while (xCoord > maxCoord && yCoord > maxCoord)
            {
                xCoord = rnd.Next(0, 10);
                //Console.WriteLine("Cruiser new Start X co-Ordinate is " + xCoord);
                yCoord = rnd.Next(0, 10);
                //Console.WriteLine("Cruiser new Start Y co-Ordinate is " + yCoord);
            }
            if (xCoord > maxCoord)
            {
                //Console.WriteLine("xCoord was Out of Bounds so Coin was flipped");
                CoinFlipCruiser = 0;
            }
            else if (yCoord > maxCoord)
            {
                //Console.WriteLine("yCoord was Out of Bounds so Coin was flipped");
                CoinFlipCruiser = 1;
            }
            //Console.WriteLine("Coin Flip Result = " + CoinFlipCruiser);

            bool overlap = false;
            for (int i = 0; i < shipSize; i++)
            {
                int x = (CoinFlipCruiser > 0) ? xCoord + i : xCoord;
                int y = (CoinFlipCruiser < 1) ? yCoord + i : yCoord;
                overlap = (grid.values[x, y] != ' ');
            }
            if (overlap)
            {
                //Console.WriteLine("The Original Value Overlapped and Was Re-Done\n");
                CruiserAI();
                return;
            }
            for (int i = 0; i < shipSize; i++)
            {
                int x = (CoinFlipCruiser > 0) ? xCoord + i : xCoord;
                int y = (CoinFlipCruiser < 1) ? yCoord + i : yCoord;
                grid.values[x, y] = 'C';
                //Console.WriteLine("Cruiser Position X = {0} , Y = {1}", x, y);
            }
        }

        private void SubmarineAI()
        {
            int shipSize = 3;
            int maxCoord = grid.sizeX - shipSize;

            int xCoord = rnd.Next(0, 10);
            //Console.WriteLine("Submarine Start X co-Ordinate is " + xCoord);
            int yCoord = rnd.Next(0, 10);
            //Console.WriteLine("Submarine Start Y co-Ordinate is " + yCoord);

            int CoinFlipSubmarine = rnd.Next(2);
            while (xCoord > maxCoord && yCoord > maxCoord)
            {
                xCoord = rnd.Next(0, 10);
                //Console.WriteLine("Submarine new Start X co-Ordinate is " + xCoord);
                yCoord = rnd.Next(0, 10);
                //Console.WriteLine("Submarine new Start Y co-Ordinate is " + yCoord);
            }
            if (xCoord > maxCoord)
            {
                //Console.WriteLine("xCoord was Out of Bounds so Coin was flipped");
                CoinFlipSubmarine = 0;
            }
            else if (yCoord > maxCoord)
            {
                //Console.WriteLine("yCoord was Out of Bounds so Coin was flipped");
                CoinFlipSubmarine = 1;
            }
            //Console.WriteLine("Coin Flip Result = " + CoinFlipSubmarine);

            bool overlap = false;
            for (int i = 0; i < shipSize; i++)
            {
                int x = (CoinFlipSubmarine > 0) ? xCoord + i : xCoord;
                int y = (CoinFlipSubmarine < 1) ? yCoord + i : yCoord;
                overlap = (grid.values[x, y] != ' ');
            }
            if (overlap)
            {
                //Console.WriteLine("The Original Value Overlapped and Was Re-Done\n");
                SubmarineAI();
                return;
            }
            for (int i = 0; i < shipSize; i++)
            {
                int x = (CoinFlipSubmarine > 0) ? xCoord + i : xCoord;
                int y = (CoinFlipSubmarine < 1) ? yCoord + i : yCoord;
                grid.values[x, y] = 'S';
                //Console.WriteLine("Submarine Position X = {0} , Y = {1}", x, y);
            }
        }

        private void DestroyerAI()
        {
            int shipSize = 2;
            int maxCoord = grid.sizeX - shipSize;

            int xCoord = rnd.Next(0, 10);
            //Console.WriteLine("Destroyer Start X co-Ordinate is " + xCoord);
            int yCoord = rnd.Next(0, 10);
            //Console.WriteLine("Destroyer Start Y co-Ordinate is " + yCoord);

            int CoinFlipDestroyer = rnd.Next(2);
            while (xCoord > maxCoord && yCoord > maxCoord)
            {
                xCoord = rnd.Next(0, 10);
                //Console.WriteLine("Destroyer new Start X co-Ordinate is " + xCoord);
                yCoord = rnd.Next(0, 10);
                //Console.WriteLine("Destroyer new Start Y co-Ordinate is " + yCoord);
            }
            if (xCoord > maxCoord)
            {
                //Console.WriteLine("xCoord was Out of Bounds so Coin was flipped");
                CoinFlipDestroyer = 0;
            }
            else if (yCoord > maxCoord)
            {
                //Console.WriteLine("yCoord was Out of Bounds so Coin was flipped");
                CoinFlipDestroyer = 1;
            }
            //Console.WriteLine("Coin Flip Result = " + CoinFlipDestroyer);

            bool overlap = false;
            for (int i = 0; i < shipSize; i++)
            {
                int x = (CoinFlipDestroyer > 0) ? xCoord + i : xCoord;
                int y = (CoinFlipDestroyer < 1) ? yCoord + i : yCoord;
                overlap = (grid.values[x, y] != ' ');
            }
            if (overlap)
            {
                //Console.WriteLine("The Original Value Overlapped and Was Re-Done\n");
                DestroyerAI();
                return;
            }
            for (int i = 0; i < shipSize; i++)
            {
                int x = (CoinFlipDestroyer > 0) ? xCoord + i : xCoord;
                int y = (CoinFlipDestroyer < 1) ? yCoord + i : yCoord;
                grid.values[x, y] = 'D';
                //Console.WriteLine("Destroyer Position X = {0} , Y = {1}", x, y);
            }
        }
    }
}