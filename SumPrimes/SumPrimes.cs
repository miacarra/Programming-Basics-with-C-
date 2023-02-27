using System;

namespace SumPrimes
{
    class Program
    {
        static void Main(string[] args)

        {
            int firstStart = int.Parse(Console.ReadLine());
            int secondtStart = int.Parse(Console.ReadLine());
            int firstStop = firstStart + (int.Parse(Console.ReadLine()));
            int secondStop = secondtStart + (int.Parse(Console.ReadLine()));
            // int firstNumber = 0;
            //int secondNumber = 0;
            bool isFirstSimple = true;
            bool isSecondSimple = true;
            for (int first = firstStart; first <= firstStop; first++)
            {
                for (int second = secondtStart; second <= secondStop; second++)
                {
                    for (int i = 2; i < first; i++)
                    {

                        if (first % i == 0)
                        {
                            isFirstSimple = false;

                            break;

                        }
                        isFirstSimple = true;
                    }
                    for (int j = 2; j < second; j++)
                    {


                            if (second % j == 0)
                            {
                                isSecondSimple = false;

                                break;
                            }
                            isSecondSimple = true;
                    }

                    if (isFirstSimple && isSecondSimple)
                    {
                        Console.WriteLine($"{first}{second}");
                    }
                }
            }
               

            

        }

    }

}
            //Console.WriteLine(first);
            //for (int second = secondtStart; second <= secondStop; second++)
            //{

//    for (int j = 2; j < second; j++)
//    {
//        if (second % j == 0)
//        {
//            isSecondSimple = false;

//        }
//    }
//    secondNumber = second;





//        if (isFirstSimple == true && isSecondSimple == true)
//        {
//            Console.WriteLine($"{firstNumber}{secondNumber}");
//            isFirstSimple = false;
//            isSecondSimple = false;

//        }
//    }

//for (int first = firstStart; first <= firstStop; first++)
//{


//    for (int i = 2; i < first; i++)
//    {

//        if (first % i == 0)
//        {
//            isFirstSimple = false;




//        }

//    }

//    for (int second = secondtStart; second <= secondStop; second++)
//    {

//        for (int j = 2; j < second; j++)
//        {
//            if (second % j == 0)
//            {
//                isSecondSimple = false;

//            }
//        }
//        secondNumber = second;





//        if (isFirstSimple == true && isSecondSimple == true)
//        {
//            Console.WriteLine($"{firstNumber}{secondNumber}");
//            isFirstSimple = false;
//            isSecondSimple = false;

//        }
//    }
//}
