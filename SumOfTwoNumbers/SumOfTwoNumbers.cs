using System;

namespace SumOfTwoNumbers


{
    class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int start =int.Parse(Console.ReadLine());
            int end =int.Parse(Console.ReadLine());
            bool magicSum=false;
            int magicNumber =int.Parse(Console.ReadLine());
            int combination =0;

            for (int number = start; number <= end; number++)
            {
                for (int number2 = start; number2 <= end; number2++)
                {
                    combination++;
                    if ((number + number2) == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combination} ({number} + { number2} = {magicNumber})");
                        magicSum = true;
                        break;
                    }
                
                }
                if (magicSum)
                {
                    break;
                }
            }
            if (magicSum==false)
            { 
            Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
        }
    }
}
