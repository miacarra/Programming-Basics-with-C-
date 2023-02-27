using System;

namespace UniquePINCodes
{
    class UniquePinCodes
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;
            //bool isUnique = false;

            for (int num1 = 1; num1 <= input1; num1++)
            {
                if (num1 % 2 == 0)
                {
                    number1 = num1;
                    for (int num2 = 2; num2 <= input2; num2++)
                    {
                        if (num2 ==2||num2==3||num2==5||num2==7)
                        {
                            number2 = num2;
                        
                       

                                for (int num3 = 1; num3 <= input3; num3++)
                                {
                                    if (num3 % 2 == 0)
                                    {
                                        number3 = num3;
                                        Console.WriteLine($"{number1} {number2} {number3}");

                                    }
                                    else
                                    {
                                        continue;
                                    }


                                }

                             
                        }

                        else 
                        {
                            continue;
                        }



                    }
                }
                else
                {
                    continue;
                }
            }


        }
    } 
}

           