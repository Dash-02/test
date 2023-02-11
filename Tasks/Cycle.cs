using System;
using System.Diagnostics.Metrics;

namespace Tasks_second
{
    class Program
    {
        static void Main(string[] args)
        {
            Cycle();
        }

        static void Cycle()
        {
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int item in number)
            {
                if (item % 2 != 0)
                    continue;

                Console.WriteLine(item);
            }

            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'};

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Number = {num[i]}");

                for (int j = 0; j < chars.Length; j++)
                {
                    if (num[i] == j)
                        break;
                    Console.Write($" {chars[j]} ");
                }
                Console.WriteLine();
            }
            

            Console.Write("\nВведите длинну массива: ");

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                numbers[i] = r.Next(-10, 11);
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }

            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                if (counter == 3)
                    break;

                for (int j = i + 1; j < n; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair: ({atI};{atJ}). Index ({i}; {j})");
                        counter++;
                    }
                    if (counter == 3)
                        break;
                }
            }
        }
    }
}