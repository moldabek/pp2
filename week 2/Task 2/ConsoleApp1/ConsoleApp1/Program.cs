using System;
using System.IO;

namespace Task2
{
    class Program
    {
        public static bool PrimeCheck(int n)
        {
            if (n == 1)
                return false ;
            for(int i = 2; i < n; i++)
            {
                if (n % i != 0)
                    return true;
            }
            return false;
        }


        public static void prime()
        {
            StreamReader sr = new StreamReader("C:\\input.txt");
            String s = sr.ReadToEnd();
            String[] arr = s.Split();
            int[] ar = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                if (PrimeCheck(int.Parse(arr[i])))
                {
                    ar[i] = arr[i];
                }
            }
            sr.Close();

            StreamWriter sw = new StreamWriter("C:\\output.txt");
            for(int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i]+" ");
            }
            sw.Close();
        }

        static void Main(string[] args)
        {
            prime();
        }
    }
}
