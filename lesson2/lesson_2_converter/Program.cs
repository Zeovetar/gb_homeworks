using System;

namespace lesson_2_converter
{
    class Program
    {
        [Flags]
        public enum numbers 
        { 
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000,
        }

        public enum weigth
        {
            I = 0b_0000001,
            V = 0b_0000011,
            X = 0b_0000111,
            L = 0b_0001111,
            C = 0b_0011111,
            D = 0b_0111111,
            M = 0b_1111111,
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Римско-арабский конвертер чисел.");
            Console.ResetColor();
/*            int counter = 5;
            while (counter > 3)
            {
                counter = 0;*/
                Console.WriteLine("Введите римское число! К вводу возможны латинские буквы: I, V, X, L, C, D, M");
                string rome_range = Console.ReadLine();
                rome_range = rome_range.ToUpper();
                char[] rome_string = rome_range.ToCharArray();
            for (int i = rome_string.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(rome_string[i]);
            }
                //Console.WriteLine((int)weigth.M/(int)weigth.D); //если результат деления 2. и больше\меньшее = 10 то можно вычитать из большего меньшее
                //Console.WriteLine(weigth.M - weigth.C);
                /*foreach (char i in rome_range)
                {
                    if (i == 'V' | i == 'L' | i == 'D')
                    {
                        counter++;
                    }
                    Console.WriteLine(counter);
                }
                if (counter > 3) { Console.WriteLine("Буквы V,L,D не могут повторяться! Попробуйте еще раз!"); }*/
            //}
            //Console.WriteLine(rome_range.Split("V"));
/*            if (rome_range.Contains("V"))
            {
                
            }*/
        }
    }
}
