using System;
using System.Diagnostics.Metrics;

namespace Tasks_second
{
    class Program
    {
        static void Main(string[] args)
        {
            NestedLoop();
        }
       
        static void NestedLoop() 
        {
            Console.Write("Введите длинну массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                numbers[i] = r.Next(-10, 11);
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair: ({atI};{atJ}). Index ({i}; {j})");
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n - 1; k++)
                    {
                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];

                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"Triplets: ({atI};{atJ}; {atK}). Index ({i}; {j}; {k})");
                        }
                    }
                }
            }
        }
    }
}