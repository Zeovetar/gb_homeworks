using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Dictionary<int, string> serv = new Dictionary<int, string>();
            Dialog(serv);
        }

        static void ProcView(Dictionary<int, string> serv)
        {
            Process[] proc = Process.GetProcesses();
            foreach (var i in proc)
            {
                serv.Add(i.Id, i.ProcessName);
            }
            int j = 0;
            foreach (var i in serv)
            {
                string temp = $"{i.Key} : {i.Value}";
                int strLen = 50 - temp.Length;
                char[] ch = new char[strLen];
                for (int k = 0; k < strLen; k++)
                {
                    ch[k] = ' ';
                }
                Console.Write(temp);
                foreach (var k in ch) { Console.Write(k); }; Console.Write("|");
                int z = (j < 2) ? j++ : j = 0;
                if (z == 0) { Console.WriteLine(); }
            }
        }

        static void Dialog(Dictionary<int, string> serv)
        {
            Console.Clear();
            Console.WriteLine("!Task Manager! В системе запущены следующие процессы:");
            ProcView(serv);
            Console.WriteLine("\nКакой процесс хотите уничтожить? Введите PID или точное имя процесса:");
            string tempStr = Console.ReadLine();
            try
            {
                Process.GetProcessById(Convert.ToInt32(tempStr)).Kill();
            }
            catch
            {
                foreach (Process proc in Process.GetProcessesByName(tempStr))
                {
                    proc.Kill();
                }
            }
        }
    }
}