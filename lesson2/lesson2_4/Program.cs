using System;

namespace lesson2_4
{
    class Program
    {

        static void Main(string[] args)
        {
            //Проблемы с виндой, с локалью, не решил еще. Винда английская, без указания юникода вопросики вместо русских букв
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            
            string kkm = "00039382";
            string inn = "007125458777 #2756";
            DateTime bill_datetime = DateTime.Now;
            var bill_date = Convert.ToDateTime(bill_datetime).ToShortDateString();
            var bill_time = Convert.ToDateTime(bill_datetime).ToShortTimeString();
            string operator_name = "Сист. Администратор";
            int sell_number = 2504;
            int kol = 2;
            int price = 890;
            int discount_persent = 5;
            int str_number = 1;
            string eklz = "ЭКЛЗ 0632558792";
            Console.WriteLine("=================================================");
            Console.WriteLine("ООО \"Империя\" \nДобро пожаловать!\n");
            Console.WriteLine($"ККМ {kkm}               ИНН {inn}");
            Console.WriteLine($"{bill_date} {bill_time}              {operator_name}");
            Console.WriteLine($"Продажа:                                     {sell_number}");
            Console.WriteLine($"{str_number}                                         {kol} х {price}");
            Console.WriteLine($"Скидка:                                        {price*kol*discount_persent*0.01}");
            Console.WriteLine("=================================================");
            Console.WriteLine($"В т.ч. Налог:                               {price * kol * 0.18}");
            Console.WriteLine($"ИТОГ:                                       \u2261{kol*price-kol*price*discount_persent*0.01}");
            Console.WriteLine(eklz);
            Console.WriteLine("=================================================");
        }
    }
}
