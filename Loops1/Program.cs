using System;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter your mark ");
            num = Convert.ToInt32(Console.WriteLine());

              for(int num = 0; num <= 100; num++)
              {
                  
                if (num > 100)
                {
                  Console.WriteLine(" ! Wrong data ");
                }
                else if(num >= 80)
                {
                  Console.WriteLine(" You got A grade");
                }
                else if(num >= 60)
                {
                  Console.WriteLine(" You got B grade");
                }
                else if(num >= 40)
                {
                  Console.WriteLine(" You got C grade");
                }
                else if(num < 40)
                {
                  Console.WriteLine(" You Failed in this exam");
                }
                return 0;

              }

            
        }
    }
}
