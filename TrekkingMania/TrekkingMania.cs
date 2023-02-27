using System;

namespace TrekkingMania
{
    class TrekkingMania
    {
        static void Main(string[] args)
        {
            int numberGroups = int.Parse(Console.ReadLine());
            int groupSize;
            int numberOfClimbers = 0;
            double climbersMusala = 0;
            double climbersMonBlan = 0;
            double climbersKilimanjaro = 0;
            double climbersK2 = 0;
            int climbersEverest = 0;
            double percentageMusala = 0;
            double percentageMonBlan = 0;
            double percentageKilimanjaro = 0;
            double percentageK2 = 0;
            double percentageEverest = 0;

            for (int i = 0; i < numberGroups; i++)
            {
                groupSize = int.Parse(Console.ReadLine());
                numberOfClimbers += groupSize;
                if (0 < groupSize && groupSize <= 5)
                {
                    climbersMusala += groupSize;
                }
                if (6 <= groupSize && groupSize <= 12)
                {
                    climbersMonBlan += groupSize;
                }

                if (13 <= groupSize && groupSize <= 25)
                {
                    climbersKilimanjaro += groupSize;
                }

                if (26 <= groupSize && groupSize <= 40)
                {
                    climbersK2 += groupSize;
                }
                if (41 <= groupSize)
                {
                    climbersEverest += groupSize;
                }

            }
            

            percentageMusala = CalculatePercentageOfClimbers(climbersMusala,numberOfClimbers);
            percentageMonBlan = CalculatePercentageOfClimbers(climbersMonBlan,numberOfClimbers);
            percentageKilimanjaro = CalculatePercentageOfClimbers(climbersKilimanjaro, numberOfClimbers);
            percentageK2 = CalculatePercentageOfClimbers(climbersK2, numberOfClimbers);
            percentageEverest = CalculatePercentageOfClimbers(climbersEverest, numberOfClimbers);
            
            Console.WriteLine($"{percentageMusala:f2}%");
            Console.WriteLine($"{percentageMonBlan:f2}%");
            Console.WriteLine($"{percentageKilimanjaro:f2}%");
            Console.WriteLine($"{percentageK2:f2}%");
            Console.WriteLine($"{percentageEverest:f2}%");
        }
    

        public static double CalculatePercentageOfClimbers( double input1, int input2)
            {
            
            double result = (input1/input2)*100;
              return result;
            }


    }
}
