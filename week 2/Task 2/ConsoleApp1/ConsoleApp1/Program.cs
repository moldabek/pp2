using System;
using System.IO;

namespace Task2
{
    class Program
    {
        public static void prime()
        {
            StreamReader sr = new StreamReader("input.txt");
            String s = sr.ReadToEnd();
            String[] arr = s.Split();
            int sum = 0;
            foreach (String a in arr)
            {
                sum += int.Parse(a);
            }
            sr.Close();

            StreamWriter sw = new StreamWriter("output.txt");
            sw.WriteLine(sum);
            sw.Close();
        }
    }
}
