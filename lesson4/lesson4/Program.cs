using System;
using System.Collections.Generic;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            //list, конечно, сам по себе ref, но че то использовал его, а потом решил понять как правильно по ref передавать, получилась тавтология )))
            List<string> SomePeople = new List<string>();
            UserDataDialog(ref SomePeople);
            foreach (string i in SomePeople)
            {
                Console.WriteLine(i);
            }
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string fio = ($"{lastName} {firstName} {patronymic}");

            return fio;
        }

        static void UserDataDialog(ref List<string>str)
        {
            Console.WriteLine("Здравствуйте! Пожалуйста, введите несколько ФИО!\nЕсли надоест вводить, откажитесь, когда программа предложит!");
            bool stop = true;
            do
            {
                MakeItPretty(ref str, GetNames());
                Console.WriteLine("Будем вводить следующего? Д\\Н");
                string ans = Console.ReadLine().ToUpper();
                if (ans == "Н") { stop = false; }
            } while (stop);
        }

        static string[] GetNames()
        {
            string[] fio = new string[3];
            Console.WriteLine("Введите имя человека:");
            fio[0] = Console.ReadLine();
            Console.WriteLine("Введите фамилию человека:");
            fio[1] = Console.ReadLine();
            Console.WriteLine("Введите отчество человека:");
            fio[2] = Console.ReadLine();
            return fio;
        }

        static void MakeItPretty(ref List<string>str1, string[]str2)
        {
            str1.Add(GetFullName(str2[0], str2[1], str2[2]));
        }
    }
}
