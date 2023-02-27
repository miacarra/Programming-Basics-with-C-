using System;
//using System.Text;

namespace SafePasswordsGenerator
{
    class SafePasswordsGenerator
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int maxPasswords = int.Parse(Console.ReadLine());
            int symbol1 = 35;
            int symbol2 = 64;
            int combination = 0;

            for (int num1 = 1; num1 <= number; num1++)
            {
                for (int num2 = 1; num2 <= number2; num2++)
                {
                    Console.Write($"{(char)symbol1}{(char)symbol2}{num1}{num2}{(char)symbol2}{(char)symbol1}|");
                    combination++;
                    symbol1++;
                    symbol2++;

                    if (symbol1 > 55)
                    {
                        symbol1 = 35;
                    }
                    if (symbol2 > 96)
                    {
                        symbol2 = 64;
                    }
                    if (combination >= maxPasswords)
                    {
                        break;
                    }
                }
                if (combination >= maxPasswords)
                {
                    break;
                }


            } 
        
            //================================= using System.Text
                //    
             //{
            //int input1 = int.Parse(Console.ReadLine());
            //int input2 = int.Parse(Console.ReadLine());
            //int maxpasswords = int.Parse(Console.ReadLine());
            //char symbol1 = (char)35;
            //char symbol2 = (char)64;
            //int passwords = 0;
            //for (int symbol3 = 1; symbol3 <= input1; symbol3++)
            //{
            //    for (int symbol4 = 1; symbol4 <= input2; symbol4++)
            //    {
            //        Console.Write($"{symbol1}{symbol2}{symbol3}{symbol4}{symbol2}{symbol1}|");
            //        symbol1++;
            //        symbol2++;
            //        passwords++;
            //        if ((int)symbol1 > 55)
            //        {
            //            symbol1 = (char)35;
            //        }
            //        if ((int)symbol2 > 96)
            //        {
            //            symbol2 = (char)64;
            //        }
            //        if (passwords >= maxpasswords)
            //        {
            //            break;
            //        }
            //    }
            //    if (passwords >= maxpasswords)
            //    {
            //        break;
            //    }
            //}


        }
        
    }
}
