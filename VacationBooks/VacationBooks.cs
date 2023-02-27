using System;

namespace VacationBooks
{
    class VacationBooks
    {
        static void Main(string[] args)
        {
            int bookPages =int.Parse(Console.ReadLine());
            int pagesPerHour =int.Parse(Console.ReadLine());
            int days =int.Parse(Console.ReadLine());

            int daysNeeded = CalculateReadingTime(bookPages,pagesPerHour,days);
            Console.WriteLine(daysNeeded);

        }
        public static int CalculateReadingTime(int bookPages, int pagesPerHour, int days)
        { 
        int totalTime =  bookPages / pagesPerHour;
        int daysNeeded = totalTime / days;
        return daysNeeded;
        }
               
    }
}
