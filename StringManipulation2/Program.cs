using System;

namespace StringManipulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, count = 0; 

            Console.Write("Enter  the string : ");
            int  s =Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter character to be searched: ");
            int c =Convert.ToInt32(Console.ReadLine());
            
            for(i=0; s == i; i++)  
            {
                if(s == i)
                {
                    count++;
                }

                Console.WriteLine("character '%c' occurs %d times \n ",c,count);                   
            }
            
            
        }
    }
}
