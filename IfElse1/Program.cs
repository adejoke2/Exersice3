using System;

namespace IfElse1
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Enter your  guess: ");

          guess = (0,0,0,0);

          previousGuess= guess;

          ans=(6,1,3,5);

          checker = ans;
          for(int y = 0; y <= 4; y++ )
          {
            if(guess,ans == (0,0,0,0))
            {
              guess = MyGuess(guess,ans);
            }else if(guess == 1)
            {
            Console.WriteLine("You have guess one correctly");
            }  
            else if(guess,ans == 0,0);
            {
            Console.WriteLine("You have guessed two right,Keep on guessing");
            }
            else if(guess,ans = previousGuess)
            {
              Console.WriteLine("You have previously guess this colour");
            }
          }
        }
    }
}
