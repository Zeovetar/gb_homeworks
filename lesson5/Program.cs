using System;
using System.IO;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------Задача1");
            Console.WriteLine("Напишите что нибудь, я запишу это в файл!");
            string inputData = Console.ReadLine();
            string filename = "E:\\test.txt";
            File.WriteAllText(filename, inputData);
            Console.WriteLine($"Теперь наш файл не пустой! {filename}");
        }
    }
}
