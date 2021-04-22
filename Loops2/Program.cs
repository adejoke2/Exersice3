using System;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {  
		 Payment payment = new Payment();

		 Console.Write("Enter Loan Amount: ");
		 int loanAmount = Convert.ToInt32(Console.ReadLine());

		 Console.Write("Enter Number of Years: ");
		 int years = Convert.ToInt32(Console.ReadLine());

		 Console.WriteLine("Enter Annual Interest Rate: ");
		 double annualRate = Convert.ToInt32(Console.ReadLine());

		 double monthlyRate = annualRate / 1200;

		 double monthlyPayment = loanAmount * monthlyRate / (1 - 1 / Math.(1 + monthlyRate, years * 12));
		
		 Console.WriteLine("Monthly Payment: %.2f\n", monthlyPayment);

		 Console.WriteLine("Total Payment: %.2f\n", (monthlyPayment * 12) * years);

		
		 double balance = loanAmount,principal, interest;
			
		 Console.WriteLine("Payment#     Interest     Principal     Balance");

		 for (int i = 1; i <= years * 12; i++)
		 {
			interest = monthlyRate * balance;

			principal = monthlyPayment - interest;

			balance = balance - principal;

			Console.WriteLine( i, interest,principal, balance);
		 }
		        
        }
    }
}
