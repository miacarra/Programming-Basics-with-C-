using System;

namespace CinemaTickets
{
    class CinemaTickets
    {
        static void Main(string[] args)
        {
            string input= Console.ReadLine(); 
            string movieName;
            int freeCapacity;
            double soldMovieTickets;
            string customerType;
            int kidTickets=0;
            int studentTickets=0;
            int standardTickets=0;
            string input2;
            double totalTickets=0;

            while (input != "Finish")
            {
                movieName = input;
                freeCapacity = int.Parse(Console.ReadLine());
                soldMovieTickets = 0;
                do
                {
                    input2 = Console.ReadLine();
                    if (input2 == "End"|| input2=="Finish")
                    {
                        break;
                    }
                    else
                    {
                        customerType = input2;
                        //soldTickets = int.Parse(Console.ReadLine());

                        if (customerType == "student")
                        {
                            studentTickets ++;
                            //freeCapacity--;
                            soldMovieTickets++;
                        }
                        else if (customerType == "standard")
                        {
                            standardTickets ++;
                            soldMovieTickets ++;
                            //freeCapacity--;
                        }
                        else if (customerType == "kid")
                        {
                            kidTickets ++;
                           soldMovieTickets ++;
                            //freeCapacity--;
                        }
                      //  input2 = Console.ReadLine();

                    }
                } while (freeCapacity>soldMovieTickets);
               
                    totalTickets += soldMovieTickets;
                    Console.WriteLine($"{movieName} - {((soldMovieTickets / freeCapacity) * 100):f2}% full.");

                if (input2 == "Finish")
                {
                    break;
                }

                else
                {
                    input = Console.ReadLine();
                }
            }
            if (input == "Finish" )
            {
                Console.WriteLine($"Total tickets: {totalTickets}");
                Console.WriteLine($"{((studentTickets / totalTickets) * 100):f2}% student tickets.");
                Console.WriteLine($"{((standardTickets / totalTickets) * 100):f2}% standard tickets.");
                Console.WriteLine($"{((kidTickets / totalTickets) * 100):f2}% kids tickets.");
                
            }




        }
    }
}
