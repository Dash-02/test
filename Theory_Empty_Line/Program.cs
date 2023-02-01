using System;
using System.Collections.Generic;
using System.Globalization;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            EmptyLine();
        }
        
        static void EmptyLine()
        {
            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " n";
            string nullStr = null; //null - отсутствие экземпляра

            Console.WriteLine("Is Null or Empty?");

            bool isNullOrEmpty = string.IsNullOrEmpty(nullStr);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty);
        }
    }
}