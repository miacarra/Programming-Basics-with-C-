using System;

namespace NumbersFrom1to100
{
    class NumbersFrom1to100
    {
        static void Main(string[] args)
        {
            int number =int.Parse(Console.ReadLine());
            int maxNumber=int.MinValue;
            int minNumber = int.MaxValue;
            int input;
            for (int i = 0; i < number;i++)
                {
               input =int.Parse(Console.ReadLine());
                if (input >= maxNumber)
                    {
                    maxNumber = input;
                    }
                if (input <= minNumber)
                {
                    minNumber = input;
                }
            }
            
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");


            //int num =  int.Parse( Console.ReadLine());
            //int result = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    int input = int.Parse(Console.ReadLine());
            //    result += input;
            //}

            //Console.WriteLine(result);

            //for (int i = 0; i < input.Length; i++)
            //{
            //    Console.Write(input[i] + " ");
            //    if (input[i] == 'a')
            //    {
            //        result += 1;
            //    }
            //    if (input[i] == 'e')
            //    {
            //        result += 2;
            //    }
            //    if (input[i] == 'i')
            //    {
            //        result += 3;
            //    }
            //    if (input[i] == 'o')
            //    {
            //        result += 4;
            //    }
            //    if (input[i] == 'u')
            //    {
            //        result += 5;
            //  
        }
    }
}
