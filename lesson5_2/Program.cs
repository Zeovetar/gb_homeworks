using System;
using System.IO;

namespace lesson5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------Задача2");
            string startFile = "E:\\startup.txt";
            Console.WriteLine($"Записал текущее время в файл {startFile}!");
            string startTime = Convert.ToString(DateTime.Now);
            File.AppendAllText(startFile, $"{startTime}\n");
        }
    }
}
