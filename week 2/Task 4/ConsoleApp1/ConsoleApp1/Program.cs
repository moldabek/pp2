using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main()
        {
            string pathString = @"C:\Users\Бейбарыс\source\repos\papka\pop.txt";
            string fileName = "pop.txt";
            if (!File.Exists(pathString))
            {
                using (FileStream fs = File.Create(pathString))//сделать через стрим врайтер и копи делет через файл 
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", fileName);
                return;
            }
            string destFile = "C:/Users/Бейбарыс/source/repos/papka/pop.txt";
            string sourceFile = "C:/Users/Бейбарыс/source/repos/papka1/pop.txt";
            File.Copy(sourceFile, destFile, true);
            if (File.Exists("C:/Users/Бейбарыс/source/repos/papka/pop.txt"))
            {

                try
                {
                    File.Delete("C:/Users/Бейбарыс/source/repos/papka/pop.txt");
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

        }
    }
}