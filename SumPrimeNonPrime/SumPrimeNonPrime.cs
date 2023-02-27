using System;

namespace SumPrimeNonPrime
{
    class SumPrimeNonPrime
    {
        static void Main(string[] args)
        {
            string input;
            int primeSum = 0;
            int nonPrimeSum = 0;
            int number;
            bool isPrime;
            do
            {
                input = Console.ReadLine();
                isPrime = true;
                if (input == "stop")
                {
                    break;
                }
                else if(int.TryParse(input, out number))
                {
                    if (number < 0)
                    {
                        Console.WriteLine($"Sum is Negative");
                        continue;
                    }
                    else if (number == 0 || number == 1)
                    {
                        nonPrimeSum += number;
                        isPrime = false;
                    }
                    else
                    {
                        for (int i = 2; i < number; i++)

                        {
                            if (number % i == 0)
                            {
                                isPrime = false;
                                break;
                            }

                        }
                        if (isPrime)
                        {

                            primeSum += number;
                        }
                        else
                        {
                            nonPrimeSum += number;
                        }
                    }
                }
                               
                 
                
                

            } while (input != "stop");

            
                Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
                Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
            
         } 
    }
}
