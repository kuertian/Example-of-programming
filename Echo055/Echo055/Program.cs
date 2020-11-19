using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo055
{
    public struct Student
    {
        static readonly string[] LaseNames = new string[] { "赵", "钱", "孙", "李", "周", "吴", "郑", "王" };
        static readonly string[] FirstNames = new string[] { "一", "二", "三", "四", "五", "六", "七", "八" };
        static readonly Random R = new Random();

        public readonly string Name;
        public readonly int Number;
        public readonly int Grade;
        public readonly int Result;

        public Student(int number)
        {
            this.Name = LaseNames[R.Next(LaseNames.Length)];
            this.Number = number;
            this.Grade = R.Next(1, 5);
            this.Result = R.Next(101);
        }
    }
    public class StudentList
    {
        private Student[] Students;
        public Student this[int index]
        {
            get { return Students[index]; }
            set { Students[index] = value; }
        }
        public StudentList(int count)
        {
            this.Students = new Student[count];
            for (int i = 0; i < count; i++)
            {
                this.Students[i] = new Student(2020001 + i);
            }
        }
        public int Length
        {
            get { return Students.Length; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StudentList students = new StudentList(10);
            Console.WriteLine("按顺序输出学生姓名：");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(students[i].Name + "\t");
            }
            //将学生信息表前的元素与后面的元素互换
            for (int i = 0; i < 5; i++)
            {
                Student temp = students[i];
                students[i] = students[9 - i];
                students[9 - i] = temp;
            }
            Console.WriteLine("输出学习信息表倒置后的学生姓名：");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(students[i].Name + "\t");
            }
            Console.ReadLine();
        }
    }
}
