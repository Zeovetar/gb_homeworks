using System;

namespace lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            UserDialog();
        }

        static void UserDialog()
        {
            do
            {
                Console.WriteLine("Введите строку состоящую из чисел, разделенных пробелом\nНапример: 10 12 3 21");
                Console.WriteLine($"Сумма числе строки = {CountResult(Console.ReadLine())}");
                Console.WriteLine("Будете вводить еще раз? Д\\Н");
            } while (Console.ReadLine().ToUpper() != "Н");
        }

        private static int CountResult(string InputStr)
        {
            int result = 0;
            string[] subs = InputStr.Split(' ');
            foreach (string i in subs)
            {
                result += Convert.ToInt32(i);
            }
            return result;
        }
    }
}
