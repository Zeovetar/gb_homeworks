using System;
using System.Collections.Generic;

namespace lesson3_warships
{
    class Program
    {
        static void Main(string[] args)
        {
            //Не успеваю сделать по нормальному, пусть так. Все кроме однушек вбито, однушки можно вбить, проверок нет (ток буквы в Upper). 
            Dictionary<char, int> alpha = new Dictionary<char, int>(10);
            alpha.Add('А', 1);
            alpha.Add('Б', 2);
            alpha.Add('В', 3);
            alpha.Add('Г', 4);
            alpha.Add('Д', 5);
            alpha.Add('Е', 6);
            alpha.Add('Ж', 7);
            alpha.Add('З', 8);
            alpha.Add('И', 9);
            alpha.Add('К', 10);

            char[] ship;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string[,] battlefield = new string[10, 10];
            for (int i = 0; i < battlefield.GetLength(0); i++)
            {
                for (int j = 0; j < battlefield.GetLength(1); j++)
                {
                   
                    battlefield[i, j] = "O";
                }
            }
            battlefield[0, 0] = "X";
            battlefield[0, 1] = "X";
            battlefield[0, 2] = "X";
            battlefield[0, 3] = "X";
            battlefield[0, 9] = "X";
            battlefield[1, 9] = "X";
            battlefield[2, 9] = "X";
            battlefield[4, 7] = "X";
            battlefield[5, 7] = "X";
            battlefield[6, 7] = "X";
            battlefield[3, 0] = "X";
            battlefield[3, 1] = "X";
            battlefield[8, 2] = "X";
            battlefield[9, 2] = "X";
            Console.WriteLine("Игровое поле:");
            Console.WriteLine("   _А Б В Г Д Е Ж З И К");
            for (int i = 0; i < battlefield.GetLength(0); i++)
            {
                for (int j = 0; j < battlefield.GetLength(1); j++)
                {
                    if (j == 0 && i != 9)
                    {
                        Console.Write($" {i + 1}| ");
                    }
                    else if (j == 0 && i == 9)
                    {
                        Console.Write($"{i + 1}| ");
                    }
                    Console.Write($"{battlefield[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ведите координаты однопалубных кораблей в формате \"А1\"!");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{i + 1}-ый");
                string ans = Console.ReadLine().ToUpper();
                ship = ans.ToCharArray();
                if (ship.GetLength(0) == 3)
                {
                    string str = Char.ToString(ship[1]) + Char.ToString(ship[2]);
                    //Convert.ToInt32(str);
                    battlefield[Int32.Parse(str) - 1, alpha[ship[0]] - 1] = "X";
                }
                else
                {
                    battlefield[(int)Char.GetNumericValue(ship[1]) - 1, alpha[ship[0]] - 1] = "X";
                }
            }    
            //
            Console.WriteLine("Игровое поле:");
            Console.WriteLine("   _А Б В Г Д Е Ж З И К");
            for (int i = 0; i < battlefield.GetLength(0); i++)
            {
                for (int j = 0; j < battlefield.GetLength(1); j++)
                {
                    if (j == 0 && i != 9)
                    {
                        Console.Write($" {i + 1}| ");
                    }
                    else if (j == 0 && i == 9)
                    {
                        Console.Write($"{i + 1}| ");
                    }
                    Console.Write($"{battlefield[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
