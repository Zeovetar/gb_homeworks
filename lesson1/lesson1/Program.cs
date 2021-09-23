using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Привет друг! Как тебя зовут? Напиши свое имя ниже!");
            string username = Console.ReadLine();
            Console.WriteLine($"Привет, {username}, сегодня {DateTime.Now.ToShortDateString()}");
        }
    }
}
