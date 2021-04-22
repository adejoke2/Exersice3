using System;

namespace Method1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;

            Console.Write("Enter a prime number");z
            int number =Convert.ToInt32(Console.ReadLine()); 

            for(int y = 2; y <= 100; y++)
            {
                for(int z = 2; z <= 100; z++)
                {
                    if(y != z && y % z == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    if(isPrime)
                    {
                        Console.WriteLine("\t" + y);
                    }
                    isPrime = true;
                }
                Console.ReadKey();
            }         
        }
    }
}
