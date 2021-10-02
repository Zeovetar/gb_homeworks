using System;

namespace lesson2_6
{
    class Program
    {
        [Flags]
        public enum officesScedule
        {
            Офис_3200 = 0b_1101011,
            Доп_Офис_3219 = 0b_0011111,
            Доп_Офис_3211 = 0b_1101100,
            Офис_3001 = 0b_1000000,
            Доп_Офис_3009 = 0b_0010101,
            Доп_Офис_3019 = 0b_0100000,
        }
        [Flags]
        public enum day_of_week
        {
            Понедельник = 0b_0000001,
            Вторник = 0b_0000010,
            Среда = 0b_000100,
            Четверг = 0b_0001000,
            Пятница = 0b_0010000,
            Суббота = 0b_0100000,
            Воскресенье = 0b_1000000,
        }
        static void Main(string[] args)
        {
            //Проблемы с виндой, с локалью, не решил еще. Винда английская, без указания юникода вопросики вместо русских букв
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Расписание работы офисов: ");
            Console.ResetColor();
            foreach (day_of_week day in Enum.GetValues(typeof(day_of_week)))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{day}: ");
                Console.ResetColor();
                foreach (officesScedule office in Enum.GetValues(typeof(officesScedule)))
                {
                    day_of_week result = day & (day_of_week)office;
                    if (result != 0)
                    {
                        Console.Write($" {office} |");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("================================= Вариант2 ==============================================================\n");
            foreach (officesScedule office1 in Enum.GetValues(typeof(officesScedule)))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{office1}: ");
                Console.ResetColor();
                foreach (day_of_week day1 in Enum.GetValues(typeof(day_of_week)))
                {
                    officesScedule result = (officesScedule)day1 & office1;
                    if (result != 0)
                    {
                        Console.Write($" {day1} |");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
