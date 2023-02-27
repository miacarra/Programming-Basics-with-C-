using System;

namespace Clock
{
    class Clock
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 23; i++)
            {
                for (int j = 0; j <= 59; j++)
                {
                    Console.WriteLine($"{i}:{j}");
                }
            }



            //While option

            //int hours = 0;
            //int minutes = 0;

            //while (hours <= 10)
            //{
            //    do
            //    {

            //        Console.WriteLine($"{hours}:{minutes:d2}");
            //        minutes++;
            //    } while (minutes <= 10);
            //    hours++;
            //    minutes = 0;
            //}
        }
    }
}
