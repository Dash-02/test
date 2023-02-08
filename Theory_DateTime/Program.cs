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
            DataTime();
        }

        static void DataTime() 
        {
            //текущее время. now возващает экземпляр datetime, кот. показ. текущ. время
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            Console.WriteLine($"It's {now.Date}, {now.Hour}:{now.Minute}");

            //время по умолч. показ. 00:00
            DateTime dt = new DateTime(2023, 3, 15);
            //арифметика над датами
            DateTime newDt = dt.AddDays(1);

            Console.WriteLine(newDt);

            //в timespan будет записана разница между 2-мя экземплярами datetime
            TimeSpan ts = now - dt;
            //ts = now.Subtract(dt);

            Console.WriteLine(ts.Days);
        }
    }
}