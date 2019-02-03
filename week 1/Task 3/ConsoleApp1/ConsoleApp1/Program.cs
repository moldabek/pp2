using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//с консоли вводим длину для нашего массива
            int[] ar = new int[n];//создаем массив
            string[] s = Console.ReadLine().Split();//строка для нашего массива
            for(int i = 0; i < ar.Length; i++)//пробегаемся по массиву чтобы превратить все string-овые числа в int-овые
            {
                ar[i] = int.Parse(s[i]);
            }
            for(int i = 0; i < ar.Length; i++)//пробегаемся чтобы дублировать числа
            {
                Console.Write("{0} {0} ", ar[i]);//"{0} {0} " отвечает за дублирование
            }
           Console.ReadLine();
        }
    }
}
