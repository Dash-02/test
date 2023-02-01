using System;
using System.Collections.Generic;


namespace Tasks
{
    class Program
    { 
        static void Main(string[] args)
        {
            Class_arr();
        }
        static void Class_arr()
        {
            double[] array = new double[5] { 1, 2, 3, 4, 0 };
            Console.WriteLine("Type array is {0}", array.GetType());

            Array myArr = new int[5];

            Array newArr = Array.CreateInstance(typeof(int), 5); // создание массива с помощью метода классса Array
            newArr.SetValue(12, 0); //передаем значение и индекс

            Console.WriteLine(newArr.GetValue(0)); // нет индексированного доступа, только метод GetValue

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = Array.BinarySearch(numbers, 7); // бинарный поиск работает только на упорядоченном массиве
            Console.WriteLine("Бинарный поиск индекса числа 7: " + index);

            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length); // numbers - массив из которого копируем,
                                                       // copy - массив,в который копируем,
                                                       // numbers.Length - сколько эл-тов нужно скопировать
            int[] another_copy = new int[10];
            copy.CopyTo(another_copy, 0); // копирование массива;
                                          // another_copy - массив, в который копируем;
                                          // 0 - с какого индкса насинаем копирвание
            Array.Reverse(copy); // реверс всех эл-ов массива, метод не возвращает новый массив,
                                 // модифицирует то, что ему передаем
            Console.WriteLine("Реверс массива: ");
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }

            Array.Sort(copy); // сортировка массива
            Console.WriteLine("Сортировка массива: ");
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }

            Array.Clear(copy, 0, copy.Length); // выставляет значения по умолчанию (в int будут нули),
                                               // нужно указать с какого индекса обнуляем эл-ты и какое кол-во
            Console.WriteLine("Значение по умолчанию (обнуление): ");
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }
        }
    }
}