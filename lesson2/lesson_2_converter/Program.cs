using System;
using System.Collections.Generic;

namespace lesson_2_converter
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<char, int> rome_symbols = new Dictionary<char, int>(7);
            rome_symbols.Add('I', 1);
            rome_symbols.Add('V', 5);
            rome_symbols.Add('X', 10);
            rome_symbols.Add('L', 50);
            rome_symbols.Add('C', 100);
            rome_symbols.Add('D', 500);
            rome_symbols.Add('M', 1000);

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Римско-арабский конвертер чисел.");
            Console.ResetColor();
            Console.WriteLine("Введите римское число! К вводу возможны латинские буквы: I, V, X, L, C, D, M");
            string rome_range = Console.ReadLine();
            rome_range = rome_range.ToUpper();
            char[] rome_string = rome_range.ToCharArray();
            int arabic = 0;
            for (int i = rome_string.Length - 1; i > 0; i--)
            {
                int result = (rome_symbols[rome_string[i - 1]] / 10);
                string check = result.ToString();
                if (i == rome_string.Length - 1)
                {
                    arabic = rome_symbols[rome_string[i]];
                }
                if ((arabic > rome_symbols[rome_string[i - 1]]) && (arabic/rome_symbols[rome_string[i - 1]] == 10) && 
                    (((check[check.Length - 1] == '0') || ((check[check.Length - 1] == '1'))) || (rome_symbols[rome_string[i - 1]] == 1)))
                {
                    arabic = arabic - rome_symbols[rome_string[i - 1]];
                }
                else
                {
                    arabic = arabic + rome_symbols[rome_string[i - 1]];
                }
            }
            Console.WriteLine($"Римское: {rome_range} = Арабское: {arabic}");
        }
    }
}
