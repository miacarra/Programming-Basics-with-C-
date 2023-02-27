using System;

namespace SecretDoorsLock
{
    class SecretDoorsLock
    {
        static void Main(string[] args)
        {

            int hundreds =int.Parse(Console.ReadLine());
            
            int tens =int.Parse(Console.ReadLine());
            int singles =int.Parse(Console.ReadLine());
            for (int i = 2; i <= hundreds; i++)
            {
                for (int j = 2; j <= tens; j++)
                {
                    for (int k = 2; k <=singles ; k++)
                    {
                        if((i%2==0) && (k%2)==0)
                        {
                         if (j==2||j==3||j==5||j==7)
                          {

                                Console.WriteLine($"{i} {j} {k}");
                          }
                        }
                    }
                }
            }
        
        }
    }
}
