using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace Tasks_second
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factorial();
            Factorial1();
        }

	static void Factorial()
        {
            Console.Write("Введите число, факториал которого необходимо вычислить: ");

            int f = Convert.ToInt32(Console.ReadLine());
            int f1 = f;
            int factorial = 1;

            if (f == 0 || f == 1)
            {
                Console.WriteLine($"{f}! = 1");
            }
            else 
            {
                if (f1 > 1)
                {
                    factorial = f;
                }

                while (f1 > 1)
                {
                    factorial *= (f1 - 1);
                    f1--;
                }
                Console.WriteLine($"{f}! = {factorial}");
            }
        }

 	static void Factorial1()
        {
            Console.Write("Введите число, факториал которого необходимо вычислить: ");

            int f = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;

            for (int i = 1; i <= f; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"{f}! = {factorial}");
        }
    }
}