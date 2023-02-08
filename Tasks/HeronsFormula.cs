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
            HeronsFormula();
        }
        
        static void HeronsFormula() 
        {
            Console.Write("Введите стороны треугольника: ");

            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());

            double p = (a + b + c)/2;
            double HeronsFormula = Math.Sqrt(p*(p-a)*(p-b)*(p-c));

            Console.WriteLine($"Площадь треугольника равна: {HeronsFormula}");
        }
    }
}