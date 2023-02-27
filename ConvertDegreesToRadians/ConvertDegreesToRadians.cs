using System;

namespace ConvertDegreesToRadians
{
    class ConvertDegreesToRadians
    {
        public static double GetData()
        {
            string input = Console.ReadLine();
            double radiance = double.Parse(input);
            return radiance;
        }
        public static double ConvertGegrees(double radians)
        {
            double degrees = (radians * 180) / Math.PI;
            return degrees;
        
        }
        static void Main(string[] args)
        {
            double radians = GetData();
            double degrees = ConvertGegrees(radians);
            PrintResult(degrees);

        }
        public static void PrintResult(double degrees)
        {
            Console.WriteLine(degrees);
        }
       
    }
}
