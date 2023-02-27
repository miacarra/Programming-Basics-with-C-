using System;

namespace Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            int cakeWidth =int.Parse(Console.ReadLine());
            int cakelength =int.Parse(Console.ReadLine());
            int maxPieces = (cakeWidth * cakelength);
            int pieces;
            string input;
            do
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out pieces))
                {

                    maxPieces -= pieces;
                }
                else if (input == "STOP")
                {
                    break;
                }
            } while (maxPieces > 0);
            if (input == "STOP")
            {
                Console.WriteLine($"{maxPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(maxPieces)} pieces more.");
            }

        }
    }
}
