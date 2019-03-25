using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;

namespace AIbattleships
{
    class AiGuess
    {
        public string[][] grid;

        public AiGuess()
        {

            string[] lines = File.ReadAllLines(@"C:\Users\Student\Documents\GitHub\AI-Group-Project\Battleships AI\Battleships AI\AIPoints.txt");
            int n = 0;
            foreach (string line in lines)
            {
                grid[n] = (line.Split(' '));
                n += 1;
            }
            Console.WriteLine(grid);





            Console.ReadLine();

        }


    }
}
