using System;

namespace CarNumber
{
    class CarNumber
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            for (int number1 = input1; number1 <= input2; number1++)
            {
                for (int number2 = input1; number2 <= input2; number2++)
                {
                    for (int number3 = input1; number3 <= input2; number3++)
                    {
                        for (int number4 = input1; number4 <= input2; number4++)
                        {
                            if (number1 % 2 == 1 && number4 % 2 == 0)
                            {
                                if (number1 > number4)
                                {
                                    if ((number2 + number3) % 2 == 0)
                                    {
                                        Console.Write($"{number1}{number2}{number3}{number4} ");
                                    }
                                }
                            }
                            if (number1 % 2 == 0 && number4 % 2 == 1)
                            {
                                if (number1 > number4)
                                {
                                    if ((number2 + number3) % 2 == 0)
                                    {
                                        Console.Write($"{number1}{number2}{number3}{number4} ");
                                    }
                                }
                            }      
                                    
                        }
                    } 
                }
         
            }
        
        }
    }
}
