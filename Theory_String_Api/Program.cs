using System;
using System.Collections.Generic;
using System.Globalization;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            StringApi();
        }
       
        static void StringApi()
        {
            string name = "abcdac";

            bool containsB = name.Contains('b');
            bool containsF = name.Contains('f');

            Console.WriteLine($"Name contains 'b'? - {containsB}, and Name contains 'f'? - {containsF}");

            bool endsWithBc = name.EndsWith("ac");
            Console.WriteLine(endsWithBc);

            bool startsWithB = name.StartsWith('b');
            Console.WriteLine(startsWithB);

            int indexOfA = name.IndexOf('a', 2); //находит индекс первого эл-та со знач-м "а"
            Console.WriteLine($"Index of a = {indexOfA}");

            int lastIndexOfC = name.LastIndexOf('c'); //находит индекс последнего эл-та со знач-м "с"
            Console.WriteLine($"Last index of c = {lastIndexOfC}");

            Console.WriteLine(name.Length);

            //взятие подстроки
            string substr = name.Substring(4); //начиная с индекса 5 и заканчивая последним будет взята подстрока
            string subsctFromTo = name.Substring(0, 4);

            Console.WriteLine($"{substr} and {subsctFromTo}");
        }
    }
}