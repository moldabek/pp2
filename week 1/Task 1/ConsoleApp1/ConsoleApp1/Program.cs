using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static bool Priime(int n){
            if (n == 1)
            {
                return false;
            }
           for(int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0) {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            int[] ar = new int[n];
            int[] arr = new int[n];
            string[] st = Console.ReadLine().Split();
            for(int i = 0; i < ar.Length; i++)
            {
                ar[i] = int.Parse(st[i]);
            }
            int j = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (Priime(ar[i]))
                {
                    ar[i] = arr[j];
                    cnt++;
                    j++;
                }
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < cnt; i++)
            {
                Console.Write(arr[i]+" ");
            }

            Console.ReadLine();
        }
    }
}
