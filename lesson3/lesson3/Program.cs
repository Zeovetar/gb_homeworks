using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("----------------------------------------------------------------------Задача1");
            var rand = new Random();
            int[,] my_array = new int[5, 5];
            for (int i = 0; i < my_array.GetLength(0); i++)
            {
                for (int j = 0; j < my_array.GetLength(1); j++)
                {
                    my_array[i, j] = rand.Next(100);
                    Console.Write($"{my_array[i,j]} ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < my_array.GetLength(0); i++)
            {
                int j = i;
                Console.Write($"{my_array[i, j]} ");
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------------------------------Задача2");
            string[,] contacts = new string[5, 2];
            Console.WriteLine("Создаем телефонный справочник!");
            for (int i = 0; i < contacts.GetLength(0); i++)
            {
                    Console.WriteLine("Введите имя контакта!");
                    contacts[i, 0] = Console.ReadLine();
                    Console.WriteLine("Введите телефон контакта!");
                    contacts[i, 1] = Console.ReadLine();
                if (i == contacts.GetLength(0) - 1)
                {
                    Console.WriteLine("Справочник заполнен!");
                }
            }
            for (int i = 0; i < contacts.GetLength(0); i++)
            {
                for (int j = 0; j < contacts.GetLength(1); j++)
                {
                    Console.Write($"{contacts[i, j]}: ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------------------------------Задача3");
            Console.WriteLine("Введите строку, которая будет отображена в обратном порядке:");
            string rev_string = Console.ReadLine();
            int half = rev_string.Length / 2;
            char temp_ch;
            char[] str_to_char = rev_string.ToCharArray();
            for (int i = 0; i < half; i++)
            {
                temp_ch = str_to_char[i];
                str_to_char[i] = str_to_char[str_to_char.GetLength(0) - 1 - i];
                str_to_char[str_to_char.GetLength(0) - 1 - i] = temp_ch;
            }
            Console.Write($"Инвертированная строка: ");
            foreach (char i in str_to_char)
            {
                Console.Write(i);
            }
        }
    }
}
