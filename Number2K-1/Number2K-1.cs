using System;

namespace Number2K_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number =int.Parse(Console.ReadLine());
            int modifier = 0;
            int result =1;
            while (result <= number)
            {
             
                Console.WriteLine(result);
                modifier = (result * 2) + 1;
                result = modifier;
            }
        }
    }
}
