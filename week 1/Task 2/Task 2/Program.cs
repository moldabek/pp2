using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        public string name;
        public string id;
        public string univer;
        public int year;

        public Student(string name, string id, string univer,int year)
        {
            this.name = name;
            this.id = id;
            this.univer = univer;
            this.year = year;
        }
         
        public void show()
        {
            Console.WriteLine("Имя: {0}",name);
            Console.WriteLine("ИД номер: {0}",id);
            Console.WriteLine("Ваш универ: {0}",univer);
            if (year == 4)
            {
                Console.WriteLine("Вы выпусник!");
            }
            else if (year < 4)
            {
                year++;
                Console.WriteLine("Вы будете учиться на {0} курсе в следущем году",year);
            }
        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя,ИД номер,университет,год обучение");
            Student stu = new Student(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
            stu.show();
            Console.ReadKey();
        }
    }
}
