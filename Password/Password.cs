using System;

namespace Password
{
    class Password
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != password)
            {

                if (input == password)
                {
                    break;
                }
                else
                {
                    input = Console.ReadLine();
                }
            }
            if (input == password)
            {
                Console.WriteLine($"Welcome {userName}!");
            }
        }

    }
}

