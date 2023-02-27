using System;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int numbersInSequence =int.Parse(Console.ReadLine());
            int sum = 0;
            int sum2 = 0;
            int input;
            int maxNumber = int.MinValue;


            for (int i = 0; i < numbersInSequence; i++)
            {
                input =int.Parse(Console.ReadLine());
               
                
                if (input >= maxNumber)
                {

                    maxNumber = input;
                    

                }
                sum += input;
                sum2=sum - maxNumber;
               

            }

            if (maxNumber == (sum2))
            {
                sum2 = sum - maxNumber;
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum2}");
            }
            else 
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNumber-sum2)}");
            }
        }
    }
}
