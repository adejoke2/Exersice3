using System;

namespace IfElse2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.Clear(); 

                Console.WriteLine("Player1:X and Player2:O");

                Console.WriteLine("\n");

                if (player % 2 == 0) 
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {

                    Console.WriteLine("Player 1 Chance");

                }
                Console.WriteLine("\n");

                choice = Convert.ToInt64(Console.ReadLine());  


                if (arr[choice] != 'X' && arr[choice] != 'O')
                {

                    if (player % 2 == 0)  
                    {

                        arr[choice] = 'O';

                        player++;

                    }
                    else
                    {

                        arr[choice] = 'X';

                        player++;

                    }

                }
                else
                {

                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);

                    Console.WriteLine("\n");

                    Console.WriteLine("Please wait 2 second board is loading again.....");

                    Thread.Sleep(2000);

                }
            }

        }
    }
}
