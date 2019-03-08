using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_Interface
{
    public class AIGuess
    {
        public static void AI()
        {
            //var path = Path.Combine(Directory.GetCurrentDirectory(), "\\AttackScores.txt");

            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Student\Documents\GitHub\AI-Group-Project\Battleships AI\Battleships AI\AttackScores.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }

    }
}
