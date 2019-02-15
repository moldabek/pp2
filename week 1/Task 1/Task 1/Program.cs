using System;

namespace Task_1
{
    class Program
    {
        public static bool Prime(int n)
        {
            if (n == 1)
            {
                return false;
            }
            for(int i = 2; i <=Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split();
            int[] array = new int[n];
            int cnt = 0;
            int[] array2 = new int[n];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(str[i]);
            }
            int j = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (Prime(array[i]))
                {
                    array2[j] = array[i];
                    cnt++;
                    j++;
                }
            }
            Console.WriteLine(cnt);
            for(int i = 0; i < cnt; i++)
            {
                Console.Write(array2[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
