using System;

namespace EvenOdd
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double evenSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;
            double oddSum = 0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;
            double current = 0;
            for (int i = 1; i <= number; i++)
            {
                current = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += current;
                    if (current < evenMin)
                    {
                        evenMin = current;
                    }
                    if (current > evenMax)
                    {
                        evenMax = current;
                    }
                }
                else
                {
                    oddSum += current;
                    if (current < evenMin)
                    {
                        oddMin = current;
                    }
                    if (current > oddMax)
                    {
                        oddMax = current;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddSum == 0)
            {
                Console.WriteLine($" OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},") ;
                Console.WriteLine($"OddMax={oddMax:f2},") ;
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
           
            if (evenSum==0)
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
                

                }            
        }
    }
}