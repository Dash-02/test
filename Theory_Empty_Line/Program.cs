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
            string str = string.Empty; // выведет ""

            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " n";
            string nullStr = null; //null - отсутствие экземпляра

            Console.WriteLine("Is Null or Empty?");

            bool isNullOrEmpty = string.IsNullOrEmpty(nullStr);
            Console.WriteLine(isNullOrEmpty); //true

            isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced); 
            Console.WriteLine(isNullOrEmpty); //false

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty); 
            Console.WriteLine(isNullOrEmpty); //false

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty); //true

            Console.WriteLine("Is Null or WhiteSpace?");

            bool isNullOrWhitespace = string.IsNullOrWhiteSpace(nullStr); 
            Console.WriteLine(isNullOrWhitespace); //true

            isNullOrWhitespace = string.IsNullOrWhiteSpace(whiteSpaced); 
            Console.WriteLine(isNullOrWhitespace); //true

            isNullOrWhitespace = string.IsNullOrWhiteSpace(notEmpty); 
            Console.WriteLine(isNullOrWhitespace); //false

            isNullOrWhitespace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(isNullOrWhitespace); //true
        }
    }
}