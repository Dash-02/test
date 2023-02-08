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
            UserProfile();
        }
        
        static void UserProfile() 
        {
            Console.Write("Введите вашу фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Укажите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Ваш вес (в кг): ");
            double weight = Double.Parse(Console.ReadLine());

            Console.Write("Ваш рост (в м): ");
            double height = Double.Parse(Console.ReadLine());

            double bmi = weight  / (height * height);

            string profile =
                $"Your profile:{Environment.NewLine}"
                + $"Full Name: {surname} {name} {Environment.NewLine}"
                + $"Age: {age} {Environment.NewLine}"
                + $"Weight: {weight} {Environment.NewLine}"
                + $"Height: {height} {Environment.NewLine}"
                + $"Body Mass Index: {bmi} {Environment.NewLine}";

            Console.WriteLine(profile);

            //Console.WriteLine($"Your profile: \nFull Name: {surname} {name}"
            //+ $"\nAge: {age}\nWeight: {weight}\nHeight: {height}"
            //+ $"\nBody Mass Index: {bmi}");
        }
    }
}