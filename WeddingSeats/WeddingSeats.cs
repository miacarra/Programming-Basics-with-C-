using System;

namespace WeddingSeats
{
    class WeddingSeats
    {
        static void Main(string[] args)
        {
            int endSector = (int)char.Parse(Console.ReadLine());
            int rows =int.Parse(Console.ReadLine());
            int placesOddRows =int.Parse(Console.ReadLine());
            int seat;
            int combination = 0;
            for (int sector= (int)'A';sector<=endSector;sector++)
            {
                
                for (int row = 1; row <= rows; row ++)
                {

                    if (row % 2 == 0)
                    {
                        seat = (int)'a';
                        for (int j = 1; j <= placesOddRows+2; j++)
                        {  
                            Console.WriteLine($"{(char)sector}{row}{(char)seat}");
                            seat++;
                            combination++;
                        }


                    }
                    else
                    {
                        seat = (int)'a';
                        for (int k = 1; k <= placesOddRows; k++)
                        {
                            Console.WriteLine($"{(char)sector}{row}{(char)seat}");
                            seat++;
                            combination++;
                        }
                    }
                }
             
                rows++;
            }
            Console.WriteLine(combination);

        }
    }
}
