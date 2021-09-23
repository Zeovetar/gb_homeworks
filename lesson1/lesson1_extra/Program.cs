using System;

namespace lesson1_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int i = 1;
            int j = 0;
            Console.WriteLine("Первые 100 чисел FizzBuzz (Числа делящиеся и на 3 и на 5 без остатка)");
            while (j < 100)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.Write($"{i}, ");
                    j++;
                }
                i++;
            }
        }
    }
}
