using System;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int numbersInsequence = int.Parse(Console.ReadLine());
            int input;
            int percentage1 = 0;
            int percentage2 = 0;
            int percentage3 = 0;
            int percentage4 = 0;
            int percentage5 = 0;
           
            for (int i = 0; i < numbersInsequence; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (input < 200)
                {
                    percentage1++;
                }

                if (200 <= input && input < 400)
                {
                    percentage2++;
                }
                if (400 <= input && input < 600)
                {
                    percentage3++;
                }
                if (600 <= input && input < 800)
                {
                    percentage4++;
                }
                if (800 <= input)
                {
                    percentage5++;
                }
            }
            double p1 = (percentage1 / (numbersInsequence * 1.0)) * 100;
            double p2 = (percentage2 / (numbersInsequence * 1.0)) * 100;
            double p3 = (percentage3 / (numbersInsequence * 1.0)) * 100;
            double p4 = (percentage4 / (numbersInsequence * 1.0)) * 100;
            double p5 = (percentage5 / (numbersInsequence * 1.0)) * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
