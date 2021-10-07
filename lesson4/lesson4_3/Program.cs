using System;

namespace lesson4_3
{
    [Flags]
    public enum Season
    {
        Spring = 0b000000011100,
        Summer = 0b000011100000,
        Autumn = 0b011100000000,
        Winter = 0b100000000011
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            while (true)
            {
                Console.WriteLine(GetSeason((Convert.ToInt32(Console.ReadLine()))));
            }
        }

        static string GetSeason(int iter)
        {
            int mask = rang(iter);
            string set_season = "";
            foreach (Season seek in (Season[])Enum.GetValues(typeof(Season)))
            {
                if (((int)seek & mask) != 0) { set_season = seek.ToString(); }
            }
            return set_season;
        }

        static int rang(int iter)
        {
            int step = 1;
            if (iter > 1)
            {
                for (int i = 0; i < iter-1; i++)
                {
                    step = step * 2;
                }
                return step;
            }
            else
            {
                return step;
            }

        }
    }
}
