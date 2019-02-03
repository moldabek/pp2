using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Ввод n определяющего количество рядов и количесто столбцов в последнем ряду
            string s = "[*]";
            string item = "[*]";

            for (int i = 1; i <= n; i++) // Цикл складывающий строку, с переходом на следующий ряд
            {
                Console.WriteLine(s);
                s += item;
            }
            Console.ReadLine(); // Костыль для того, чтобы окно терминала не закрывалось после завершения работы
        }
    }
}
