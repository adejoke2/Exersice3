using System;

namespace StringManipulation1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num, name=""; 

            Console.Write("Input any string: ");  
            num = Console.ReadLine();

            for (int i = num.Length-1; i >=0; i--) 
            {  
                name += num[i].ToString();  
            }  
            if (name == num)   
            {  
                Console.WriteLine("The String you entered is a Palindrome \n Entered String Was {0} and reverse string is {1}", num, name);  
            }  
            else  
            {  
                Console.WriteLine("The String you entered is not a Palindrome \n Entered String Was {0} and reverse string is {1}", num, name);  
            }    
        }
    }
}
