using System;

namespace LettersCombinations
{
    class LettersCombinations
    {
        static void Main(string[] args)
        {

            int start = (int)char.Parse(Console.ReadLine()); 
            int end = (int)char.Parse(Console.ReadLine()); 
            int exception = (int)char.Parse(Console.ReadLine());
            int numberCombinations = 0; ;

            for (int num1=start;num1<=end;num1++)
            {
                for (int num2 = start; num2 <= end; num2++)
                {

                    for (int num3 = start; num3 <= end; num3++)
                    {
                        if ((char)num1 == exception || (char)num2 == exception || (char)num3 == exception)
                        {
                            continue;
                        }
                        else
                        {
                            numberCombinations++;
                            Console.Write($"{(char)num1}{(char)num2}{(char)num3} ");
                            


                        }
                    }
                }
                   
            
            }
            Console.Write(numberCombinations);

        }
    }
}
