using System;
using System.IO;


namespace Task3
{
    class Program
    {
        public static void PrintSpaces(int level)
        {
            for (int i = 0; i < level; i++)
                Console.Write("     ");
        }


            public static void Direct(DirectoryInfo path, int level)
        {
            foreach (FileInfo f in path.GetFiles())
            {
                PrintSpaces(level);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in path.GetDirectories())
            {
                PrintSpaces(level);
                Console.WriteLine(d.Name);
                Direct(d, level + 1);
            }
        }

        static void Main()
        {
            DirectoryInfo path = new DirectoryInfo("/Users/Бейбарыс/Desktop/флешка Дархана");
           Direct(path, 0);
            Console.ReadLine();
        }
    }
}
