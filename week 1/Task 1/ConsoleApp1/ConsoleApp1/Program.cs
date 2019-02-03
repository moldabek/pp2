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
                if (n % i != 0) {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ar = new int[n];

        }
    }
}
