using System;

namespace BiggestNumber
{
    class BiggestNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = 0;
            int MaxNumber = int.MinValue;
            while (input != "Stop")
            {
                if (int.TryParse(input, out number))
                {
                    if (number > MaxNumber)
                    {
                        MaxNumber = number;
                    }
              
                }
                else
                {
                    if (input == "Stop")
                    {
                        break;
                    }
                }
                input =Console.ReadLine();
            }
            Console.WriteLine(MaxNumber);
        }
    }
}
