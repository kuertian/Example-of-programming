using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo037
{
    class Program
    {
        struct Student
        {
            public string Name;
            public byte Age;
            public string Sex;
            public int ID;
            public Student(string name, byte age, string sex, int id)
            {
                Name = name;
                Age = age;
                Sex = sex;
                ID = id;
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("张三", 20, "男", 2020001));
            students.Add(new Student("李四", 21, "女", 2020002));
            students.Add(new Student("王五", 19, "男", 2020003));
            Console.WriteLine("遍历学生信息表，输出学生信息：");
            foreach (Student s in students)
            {
                Console.WriteLine("{0}\t{1}岁\t{2}生\t{3}号",s.Name,s.Age,s.Sex,s.ID);
            }
            Console.WriteLine("删除学生 “李四”的信息");
            students.RemoveAt(1);
            Console.WriteLine("在表头插入学生“孙七”的信息");
            students.Insert(0, new Student("孙七", 20, "男", 2020004));
            Console.WriteLine("在表尾插入学生 “周八”信息");
            students.Insert(students.Count, new Student("周八", 21, "男", 2020005));
            Console.WriteLine("重新遍历学生信息表，输出学生信息：");

            foreach (Student s in students)
            {
                Console.WriteLine("{0}\t{1}岁\t{2}生\t{3}号",s.Name,s.Age,s.Sex,s.ID);
            }
            Console.ReadLine();
        }
    }
}
