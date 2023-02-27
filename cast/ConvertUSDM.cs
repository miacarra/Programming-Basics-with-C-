
using System;

namespace cast
{
    class ConvertUSDM
    {

        public static void Main()
        {
            double input = double.Parse(Console.ReadLine());
            double result = ConvertUSD(input);
            PrintResult(result);
        }
       public static double ConvertUSD(double input)
        {
             double result = input * 1.79549;
            return result;
            
        }

        public static void PrintResult(double result)
        {
            Console.WriteLine(result);
        }
        
      }




            
}
