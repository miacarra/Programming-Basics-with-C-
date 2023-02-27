using System;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
       {
            //int input =int.Parse(Console.ReadLine());        //////////using int.Parse(stringName)
            //string current;
            //int singleNumber;
            //bool isSpecial = false;
            //for (int i = 1111; i <= 9999; i++)
            //{
            //    current = i.ToString();
            //    for (int j = 0; j < current.Length; j++)
            //    {
            //        singleNumber =int.Parse(current[j].ToString());
            //        if (singleNumber == 0)
            //        {
            //            isSpecial = false;
            //            break;
            //        }
            //        else if ((input % singleNumber) == 0)
            //        {

            //            isSpecial = true;

            //        }
            //        else 
            //        {
            //            isSpecial = false;
            //            break;
            //        }

            //    }
            //    if (isSpecial)
            //    {
            //        Console.Write($"{i} ");
            //    }

            //}

            //// using modular division of integers

            int input = int.Parse(Console.ReadLine());
            bool isSpecial = false;
            int current;
            int singleNumber;

            for (int i = 1111; i <= 9999; i++)
            {

                current = i;
               // singleNumber = current % 10;

                do
                {
                    singleNumber = current % 10;
                    current = current / 10;
                    if (singleNumber == 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    else if ((input % singleNumber) == 0)
                    {
                        isSpecial = true;
                        
                    }
                    else
                    {
                        isSpecial = false;
                        break;
                    }
                } while (current > 0);

                if (isSpecial == true)
                {
                    Console.Write($"{i} ");
                    isSpecial = false;
                }
                else
                {

                    continue;
                }

              
            }



        }

    }
}
