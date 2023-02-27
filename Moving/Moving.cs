using System;

namespace Moving
{
    class Moving
    {
        static void Main(string[] args)
        {
            int roomWidth =int.Parse(Console.ReadLine()); 
            int roomLength =int.Parse(Console.ReadLine()); 
            int roomHeight =int.Parse(Console.ReadLine());

            int freeSpace = roomWidth * roomLength * roomHeight;
            int boxes;
            string input;

            do
            {`
                input = Console.ReadLine();
                if (int.TryParse(input, out boxes))
                {
                    freeSpace -= boxes;
                }
                else if (input == "Done")
                {
                    break;
                }
            } while (freeSpace >= 0);
            if (freeSpace > 0)
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
            }
        }
    }
}
