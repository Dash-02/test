using System;
using System.Collections.Generic;


namespace Tasks
{
    class Program
    { 
        static void Main(string[] args)
        {
            //List();
            //Dictionary();
        }
        
        static void List()
        {
            var intlist = new List<int>() { 1, 2, 3, 4, 5, 6, 7 }; // по умолчанию внутри себя List выделяет память
                                                                   // под массив размером 4 эл-та, и двукратно возрастает при заполнении
                                                                   // лист оборачиват массив
                                                                   // List используется, когда нужен типизированный динамически расширяемый массив
            intlist.Add(7); //не возвращает новый лист, а модифицирует исходный

            int[] intArr = { 1, 2, 3 };
            intlist.AddRange(intArr);

            if (intlist.Remove(1)) // Remove return boolean. if эл-т со значением 1 сущ. - удаляет первый совпавший эл-т и возвращает true
            {
                Console.WriteLine("True");
            }
            else 
            {
                Console.WriteLine("False");
            }

            intlist.RemoveAt(0); // удаление по индексу эл-та

            intlist.Reverse(); // реверсирует эл-ты

            bool contains = intlist.Contains(5); // проверяет содержится ли определенный эл-т в листе

            int min = intlist.Min();
            int max = intlist.Max();

            Console.WriteLine($"Min = {min}, Max = {max}");

            int indexof = intlist.IndexOf(3); // находит индекс первого эл-та со знач-м 2
            int lastindexof = intlist.LastIndexOf(3); // находит индекс последнего эл-та со знач-м 2

            Console.WriteLine($"indexof = {indexof}, lastindexof = {lastindexof}");

            for (int i = 0; i < intlist.Count;  i++) // List - индексируемый тип, имеет св-во Count вместо Lenght
            {
                Console.WriteLine($"list[{i}] = {intlist[i]}, ");
            }

            Console.WriteLine();

            foreach (int item in intlist)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
        static void Dictionary()
        {
            // Dictionary используется, если нужен ассоциативный массив, где знач-я ассоциируюся с ключами

            var people = new Dictionary<int, string>(); // указывается 2 типа, 1й - тип ключа
                                                        // ключ всегда уникальный
            people.Add(1, "Jude");
            people.Add(2, "Giorno");
            people.Add(3, "Joe");

            people = new Dictionary<int, string>() //2й вариант добавления данных
            {
                { 1, "Jude" },
                { 2, "Giorno" },
                { 3, "Joe" },
            };

            // вытаскиваем значение по ключу

            string name = people[1]; // доступ по ключу (не по индексу)
            Console.WriteLine(name);

            Console.WriteLine("Iterating over keys:");

            // 2 способа указать тип данных
            var keys = people.Keys;
            Dictionary<int, string>.KeyCollection keys1 = people.Keys;

            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Iterating over values:");
            Dictionary<int, string>.ValueCollection values = people.Values; //возвращает значения коллекции

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Iterating over key-value pairs:");
            foreach (KeyValuePair<int, string> pair in people)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }
            Console.WriteLine();

            Console.WriteLine($"Count = {people.Count}"); //кол-во эл-тов в Dictionary

            //спросить содержит ли Dictionary какой-либо ключ:

            bool containsKey = people.ContainsKey(3); // search key
            bool containsValue = people.ContainsValue("Jude");

            Console.WriteLine($"Contains Key = {containsKey}, Contains Value = {containsValue}");

            people.Remove(1); // находит эл-м, удаляет, выводит true

            // булевый метод добавления эл-та, вернет false, т.к. ключ 2 имеет знач-е
            if (people.TryAdd(2, "Robert")) 
            {
                Console.WriteLine("Добавление успешно завершено");
            }
            else 
            {
                Console.WriteLine($"Ошибка: Ключу 2 уже присвоено значение");    
            }
            // булевый метод, пытается вытащить знач-е, используя ключ, нет знач-я - false
            if (people.TryGetValue(2, out string val))
            {
                Console.WriteLine($"Key 2 val = {val}");
            }
            else {
                Console.WriteLine();
            }

            people.Clear(); // удаляет все пары ключ-значение
        }
    }
}
