using System;
using System.Collections.Generic;
using System.Globalization;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods();
        }
        
        static void Methods()
        {
            string name = "Abc"; // экземпляр типа string

            // другой способ создания: 
            string name2 = new string("Abcd");

            bool containsB = name.Contains('b'); // проверяет, есть ли в name "b"
            bool containsF = name2.Contains('f'); // 'char', "string"
            Console.WriteLine($"Name contains 'b'? - {containsB}, and Name2 contains 'f'? - {containsF}");

            string abc = string.Concat("a", "b", "c"); // Concat (статический метод) вызывается на типе string,
                                                       // а возвращает экземпляр типа string, записываемый в abc
            Console.WriteLine(abc);

            Console.WriteLine(int.MinValue); // статический член, вызывается на прямую на типе

            int x = 1;
            string xStr = x.ToString();
            Console.WriteLine($"Number = {x}, String = {xStr}");
        }
    }
}