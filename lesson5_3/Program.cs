using System;
using System.Collections.Generic;
using System.IO;

namespace lesson5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("---------------------------------------------------------------------Задача3");
            string binary_file = "E:\\Binary.bin";
            Console.WriteLine("Введите числа от 0 до 255. Для ввода используйте Enter. Чтобы окончить ввод введите 256!");
            string getMeSmth = "";
            do
            {
                getMeSmth = Console.ReadLine();
                if ((Convert.ToInt32(getMeSmth) >= 0 && Convert.ToInt32(getMeSmth) <= 255))
                {
                    numbers.Add(Convert.ToInt32(getMeSmth));
                }
                else
                {
                    Console.WriteLine("От 0 до 255!!! Чтобы окончить ввод введите 256!");
                }
            }
            while (getMeSmth != "256");
            byte[] array = new byte[numbers.Count];
            int j = 0;
            foreach (var i in numbers)
            {
                array[j] = Convert.ToByte(i);
                j++;
            }
            File.WriteAllBytes(binary_file, array);
            Console.WriteLine($"Данные записаны в: {binary_file}");
        }
    }
}
