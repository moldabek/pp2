using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {
        public static  bool Palindrom(string s)// создаем функцию которая проверяет на полиндромность  
        {
           for(int i=0;i<s.Length / 2; i++)//пробегаемся фориком чтобы проверить
            {
                if (s[i] != s[s.Length - i - 1])// сама проверка
                {
                    return false; 
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            
            //string s = Console.ReadLine();//считивние строк с консоли
            if (!Palindrom(s))//проверка строки  через функцию     
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            Console.ReadLine();
        }
    }
}
