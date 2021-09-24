using System;

namespace lesson1_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int i = 0;
            Console.WriteLine("Первые 100 чисел FizzBuzz (Числа делящиеся и на 3 и на 5 без остатка)");
            while (i < 100)
            {
                switch(i)
                {
                    case (> 0) when i % 3 == 0 && i % 5 != 0:
                        Console.Write("Fizz ");
                        break;
                    case (> 0) when i % 5 == 0 && i % 3 != 0:
                        Console.Write("Buzz ");
                        break;
                    case (> 0) when i % 15 == 0:
                        Console.Write("FizzBuzz ");
                        break;
                    default:
                        Console.Write($"{i} ");
                        break;
                }
                i++;
            }
        }
    }
}
