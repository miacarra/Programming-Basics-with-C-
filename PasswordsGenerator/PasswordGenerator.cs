using System;
//using System.Text;

namespace PasswordsGenerator
{
    class PasswordGenerator
    {
        static void Main(string[] args)
        {
           int input = int.Parse(Console.ReadLine());
            
            int input2 = int.Parse(Console.ReadLine());
            //int num1=0;
            // char sym2;

            //char sym;
            //int lastNum;


            for (int num = 1; num < input; num++)
            {
                for (int num2 = 1; num2 < input; num2++)
                {
                    for (int sym = (int)'a'; sym < (int)'a' + input2; sym++)
                    {
                        for (int sym2 = (int)'a'; sym2 < ((int)'a' + input2); sym2++)
                        {
                            //num1 = num + 1;
                            //sym2 = (char)((int)sym + 1);
                            for (int lastNum = (Math.Max(num, num2) + 1); lastNum <= input; lastNum++)
                            {
                                
                                Console.Write($"{num}{num2}{(char)sym}{(char)sym2}{lastNum} ");
                            }
                        }
                    }
                }
            }
        }
        
    }
}
