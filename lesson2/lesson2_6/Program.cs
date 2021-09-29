using System;

namespace lesson2_6
{
    class Program
    {
        [Flags]
        public enum officesScedule
        {
            Office1 = 0b_1101011,
            Office2 = 0b_0011111,
            Office3 = 0b_1101100,
            Office4 = 0b_1000000,
            Office5 = 0b_0010101,
            Office6 = 0b_0100000,
        }
        [Flags]
        public enum day_of_week
        {
            Monday = 0b_0000001,
            Tuesday = 0b_0000010,
            Wednesday = 0b_000100,
            Thursday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000,
        }
        static void Main(string[] args)
        {
            //day_of_week office1 = day_of_week.Monday | day_of_week.Tuesday | day_of_week.Wednesday | day_of_week.Thursday | day_of_week.Friday;
            //day_of_week office2 = day_of_week.Saturday | day_of_week.Sunday;
            //day_of_week office3 = day_of_week.Monday | day_of_week.Tuesday | day_of_week.Wednesday | day_of_week.Thursday;
            //day_of_week short_week = (day_of_week)0b_0001111;
            //bool is_worked = short_week == office3;
            //Console.WriteLine(is_worked);
            officesScedule ff = (officesScedule)day_of_week.Monday;
            officesScedule test = officesScedule.Office1 & ff;
            Console.WriteLine("Расписание работы окон: ");
            foreach (officesScedule i in Enum.GetValues(typeof(officesScedule)))
            {
                foreach (day_of_week j in Enum.GetValues(typeof(day_of_week)))
                {
                    officesScedule k = (officesScedule)j;
                    k = i & k;
                    int f = (int)k;
                    if (f == 1)
                    {
                        Console.Write(i);
                    }
                }
            }
            Console.WriteLine();
            //officesScedule monday = (officesScedule)0b_0000001;
            //bool workedAtMonday = officesScedule.Office1 == (officesScedule)day_of_week.Monday;
            //officesScedule allDays = (officesScedule)0b_1111111;
            //officesScedule doesItWorks = officesScedule.Office1 & allDays;
            //day_of_week days = (officesScedule)doesItWorks;
            //Console.WriteLine(doesItWorks);
        }
    }
}
