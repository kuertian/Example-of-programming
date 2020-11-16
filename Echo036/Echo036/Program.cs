using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo036
{
    class Program
    {
        //学生信息
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
            ArrayList students = new ArrayList();
            students.Add(new Student("张三", 20, "男", 2020001));
            students.Add(new Student("李四", 19, "女", 2020002));
            students.Add(new Student("旺旺", 20, "男", 2020003));

            foreach (Student s in students)
            {
                Console.WriteLine("{0}\t{1}岁\t{2}生\t{3}号",s.Name,s.Age,s.Sex,s.ID);
            }
            Console.ReadLine();
        }        
    }
}
