using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void MyDirectoryTree(DirectoryInfo path, int lvl)
        {
            FileInfo[] files = path.GetFiles();
            DirectoryInfo[] directories =path.GetDirectories();

            foreach (DirectoryInfo direct in directories)
            {
                for (int i = 0; i < lvl; ++i)
                    Console.Write();
                Console.WriteLine(direct.Name);
                MyDirectoryTree(direct, lvl + 3);
            }
            foreach (FileInfo file in files)
            {
                for (int i = 0; i < lvl; ++i)
                    Console.Write();
                Console.WriteLine(file.Name);
            }

        }
        static void Main()
        {
            DirectoryInfo path = new DirectoryInfo("C:/Users/Бейбарыс/Desktop/PP2");
            MyDirectoryTree(path, 0);
            Console.ReadLine();
        }
    }
}