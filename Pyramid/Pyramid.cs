using System;

namespace Pyramid
{
    class Pyramid
    {
        static void Main(string[] args)
        
        {
            int input =int.Parse(Console.ReadLine());
            int count = 1;

            for (int i = 1; i<=input; i++)
            {
                
                for (int j = 1; j<=i; j++)
                {
                    if (count > input)
                    {
                        break;
                    }
                    Console.Write($"{count} ");
                    count++;

                    

                }
                if (count > input)
                {
                    break;
                }
                Console.WriteLine();
                
            }
        }
    }
}
