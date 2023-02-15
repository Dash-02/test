using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace Tasks_second
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci();
        }
        
        static void Fibonacci() 
        {
            int f = 0;
            int f1 = 1;
            
            Console.Write("Enter the number of fibonacci numbers: ");

            int n = Convert.ToInt32(Console.ReadLine());

            int[] F = new int[n];

            for (int i = 0; i < n; i++)
            {
                int fib = f + f1;
               
                F[i] = fib;

                f1 = f;
                f = fib;
                
                Console.Write($"{F[i]} ");
            }
        }
    }
}