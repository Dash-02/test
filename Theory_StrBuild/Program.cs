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
            StrBuild();
        }
        
        static void StrBuild() 
        { 
            StringBuilder sb = new StringBuilder();
            // для наполнения можно вызвать экземплярные методы
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("Joe ");

            sb.AppendLine(".");
            sb.AppendLine("Hi!");

            string str = sb.ToString();
            Console.WriteLine(str);
        }
    }
}