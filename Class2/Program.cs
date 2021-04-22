using System;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, x, y, z;

            Console.WriteLine("Enter number of matrices A and B in row and column");
            w = Convert.ToInt32(Console.ReadLine());
            
            x = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[10];

            Console.Write("\nEnter first matrix:");

            for(int y = 0; y < w; y++)
            {
                for(z = 0; z < x; z++)
                {
                    A[y, z] = Convert.ToInt32(Console.ReadLine());
                } 
            }
            int[] B = new int[10, 10];

            Console.Write("Enter second matrix");

            for(y = 0; y < w; y++)
            {
              for(z = 0; z < x; z++)
              {
                Console.Write(B[i, j] + "\t" );
              }
              Console.WriteLine();
            }
            int[] C = new int[10, 10];

            for(y = 0; y < w; y++)
            {
                for (z = 0; z < x; z++)
                {
                    C[y, z] = A[y, z] - B[y, z];
                }
            }
            Console.Write("\nMatrix Differences");

            for(y = 0; y < w; y++)
            {
                for(z = 0; z < x; z++)
                {
                    Console.WriteLine(C[y,z] + "\t");
                }
                Console.WriteLine();
            }
            Console.Read();       
        }
    }
}
