using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Formatting();
        }
        
        static void Formatting()
        { 
            string str = "My \nName";
            Console.WriteLine(str);

            //метод, который будет корректно отображаться в любой ос
            string str1 = $"My {Environment.NewLine}Name";
            Console.WriteLine(str1);

            string str2 = @"C:\ghf\ghfg"; // "\" не нужно экранировать
            Console.WriteLine(str2);

            double answer = 76;
            string result = string.Format("{0:f}", answer);
            Console.WriteLine(result); //76

            string result2 = string.Format("{0:f4}", answer);
            Console.WriteLine(result2); //0076
            Console.WriteLine(answer.ToString("f2"));
            Console.WriteLine($"{answer:f2}");
        }
    }
}