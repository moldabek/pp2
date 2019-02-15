using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] strarr = Console.ReadLine().Split();
            int[] arr = new int[n];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(strarr[i]);
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} {0} ",arr[i]);
            }

            Console.ReadLine();
        }
    }
}