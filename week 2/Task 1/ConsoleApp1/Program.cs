using System;

namespace ConsoleApp1
{
    
    class Program
    {
        public static  bool Palindrom(string s)// создаем метод которая проверяет на палиндромность  
        {
           for(int i=0;i<s.Length; i++)//пробегаемся фориком чтобы проверить
            {
                if (s[i] != s[s.Length - i - 1])// сама проверка
                {
                    return false; 
                }
            }
            return true;
        }

        static void Main()
        {
            
            string s = Console.ReadLine();//считивние строк с консоли
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
