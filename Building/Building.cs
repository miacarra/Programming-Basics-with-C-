using System;

namespace Building
{
    class Building
    {
        static void Main(string[] args)
        {
            int numberFloors =int.Parse(Console.ReadLine());
            int numberRooms =int.Parse(Console.ReadLine());

            for (int floor = numberFloors; floor >= 1; floor--)
            {
                for (int room = 0; room < numberRooms; room++)
                {
                    if (floor % 2 == 0 && floor != numberFloors)
                    {
                        Console.Write( $"O{floor}{room} ");
                       
                    }
                    if (floor % 2 == 1 && floor != numberFloors)
                    {
                        Console.Write($"A{floor}{room} ");
                        
                    }
                    if (floor == numberFloors )
                    {
                        Console.Write($"L{floor}{room} ");
                        
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }
}
