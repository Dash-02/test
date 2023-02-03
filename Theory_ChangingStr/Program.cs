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
            ChangingStr();
        }
       
        static void ChangingStr() 
        {
            //объединение строк
            string nameConcat = string.Concat("My ", "name ", "is ", "Joe");
            Console.WriteLine(nameConcat);

            nameConcat = string.Join("_", "My", "name", "is", "Guorno");

            // nameConcat = "My " + "name " + "is " + "Joe";

            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Insert(0, "Hello, ");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Insert(24, ".");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Remove(0, 7);
            Console.WriteLine(nameConcat);

            string replaced = nameConcat.Replace("_", " ");
            Console.WriteLine(replaced);

            string data = "12;34;23;56;11;23;57;32";
            string[] splitData = data.Split(';'); //Split разделил данные 
            string first = splitData[0];
            Console.WriteLine(first);

            // преобразование строки в массив
            char[] chars = nameConcat.ToCharArray(); // метод вернет массив из char
            Console.WriteLine(chars[0]); //индексный доступ к отдельным символам
            Console.WriteLine(nameConcat[0]);

            //регистр строки
            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            //убирает пробелы
            string name = " My name... ";
            Console.WriteLine(name.Trim());
        }
    }
}