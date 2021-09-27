using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проблемы с виндой, с локалью, не решил еще. Винда английская, без указания юникода вопросики вместо русских букв
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("--------------------------------------------------------------------------------Задача 1:");
            Console.Write("Введите минимальную температуру за день:");
            float day_tMin = float.Parse(Console.ReadLine());
            Console.Write("Введите максимальную температуру за день:");
            float day_tMax = float.Parse(Console.ReadLine());
            float average_tDay = (day_tMax + day_tMin) / 2;
            Console.WriteLine($"Среднедневная температура = {average_tDay}"); //задача 1
            int get_month;
            Console.WriteLine("--------------------------------------------------------------------------------Задача 2:");
            bool m_check;
            bool m_winter;
            do
            {
                Console.WriteLine("Введите порядковый номер месяца:");
                get_month = int.Parse(Console.ReadLine());
                m_check = true;
                m_winter = false;
                switch (get_month)
                {
                    case 0:
                        Console.Write("Друг, Январь 1-ый месяц, Декабрь 12-ый. 0-го нема. Попробуй еще раз!");
                        m_check = false;
                        break;
                    case 1:
                        Console.WriteLine("Январь");
                        m_winter = true;
                        break;
                    case 2:
                        Console.WriteLine("Февраль");
                        m_winter = true;
                        break;
                    case 3:
                        Console.WriteLine("Март");
                        break;
                    case 4:
                        Console.WriteLine("Апрель");
                        break;
                    case 5:
                        Console.WriteLine("Май");
                        break;
                    case 6:
                        Console.WriteLine("Июнь");
                        break;
                    case 7:
                        Console.WriteLine("Июль");
                        break;
                    case 8:
                        Console.WriteLine("Август");
                        break;
                    case 9:
                        Console.WriteLine("Сентябрь");
                        break;
                    case 10:
                        Console.WriteLine("Октябрь");
                        break;
                    case 11:
                        Console.WriteLine("Ноябрь");
                        break;
                    case 12:
                        Console.WriteLine("Декабрь");
                        m_winter = true;
                        break;
                    default:
                        Console.WriteLine("Друг, месяцев всего 12! Попробуй еще раз!");
                        m_check = false;
                        break;
                }
            } while (!m_check);
            Console.WriteLine("--------------------------------------------------------------------------------Задача 5:");
            if ((m_winter) && (average_tDay > 0))
            {
                Console.WriteLine("Дождливая зима");
            }
        }
    }
}
