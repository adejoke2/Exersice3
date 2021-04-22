using System;

namespace Class1
{
    public class Employee
    {
        public static void GetInfo()
        {
            Console.Write("Enter your salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of hours you work per day: ");
            int NoOfHoursPerDay = Convert.ToInt32(Console.ReadLine());

            AddSal(salary);

            AddWork(NoOfHoursPerDay, salary);

        }
        public static void AddSal(int salary)
        {
            if(salary < 500)
            {   
                salary += 10;
                Console.WriteLine($"You have been given an additional reward of $10, you have {salary} as your new salary");
            }
            else
            {
                Console.WriteLine($"You have {salary} salary remains");
            }

        }
        public static void AddWork(int NoOfHoursPerDay, int salary)
        {
            if(NoOfHoursPerDay > 6 && salary < 500)
            {
                Console.WriteLine($"You have been given an additional reward of $5, you have {salary + 5 + 10} as your new salary");
            }
            else if (NoOfHoursPerDay > 6 && salary >= 500)
            {
                Console.WriteLine($"You have been given an additional reward of $5, you have new {salary + 5} as your new salary");
            }
            else if(NoOfHoursPerDay < 6 && salary < 500)
            {
                Console.WriteLine($"Your salary is {salary + 10}");
            }
            else
            {
                Console.WriteLine($"You have {salary} salary remains");
            }
        }
        
    }
}