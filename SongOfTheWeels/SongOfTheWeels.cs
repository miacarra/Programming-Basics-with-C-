using System;

namespace SongOfTheWeels
{
    class Program
    {
        static void Main(string[] args)
        {
            byte controlNumber =byte.Parse(Console.ReadLine());
            int sum = 0;
            bool isPassword = false;
            int counter = 0;
            string message=string.Empty;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b<=9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            
                            if (a < b && c > d)
                            {
                                sum = (a * b) + (c * d);
                                if (sum == controlNumber && 4<controlNumber && controlNumber<=144)

                                {
                                    counter++;
                                    Console.Write($"{a}{b}{c}{d} ");
                                    if (counter == 4)
                                        {
                                        isPassword = true;
                                        message= $"Password: {a}{b}{c}{d}";
                                    }
                                }

                             }

                        }
                    }
                }
            }
            if (isPassword == false)
            {
                Console.WriteLine();
                Console.WriteLine($"No!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(message);
            }
        }
    }
}
