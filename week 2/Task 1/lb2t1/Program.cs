using System;
using System.IO;

namespace lb2t1
{
    class Program
    {
        public static bool Polincheck(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {

                if (s[i] != s[j])
                 return false;
            }
            return true;

        }
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Бейбарыс\source\repos\tochno\input.txt");
            if (Polincheck(text))
            {
                Console.WriteLine("Yes");
            } else
                Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}
