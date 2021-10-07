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
            Console.WriteLine(GetSeason(10));
        }

        static string GetSeason(int iter)
        {
            char[] CharToFlag = new char[12];
            for (int i = 0; i < 12; i++)
            {
                CharToFlag[i] = i != iter-1 ? '0' : '1';
            }
            Array.Reverse(CharToFlag);
            string mask = new string(CharToFlag);
            string set_season = "";
            int result_mask = Int32.Parse(mask);
            foreach (Season seek in (Season[])Enum.GetValues(typeof(Season)))
            {
                if (((int)seek & result_mask) != 0) { set_season = seek.ToString(); }
            }
            return set_season;
        }
    }
}
