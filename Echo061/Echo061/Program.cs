using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo061
{
    public struct Student
    {
        static readonly string[] xing = new string[] { "赵", "钱", "孙", "李", "周", "吴", "郑", "王" };
        static readonly string[] ming = new string[] { "一", "二", "三", "四", "五", "六", "七", "八" };
        static readonly Random random = new Random();

        public readonly int num;
        public readonly string name;
        public readonly int grade;

        public Student(int number) {
            this.num = number;
            StringBuilder build = new StringBuilder();
            build.Append(xing[random.Next(xing.Length)]);
            build.Append(ming[random.Next(ming.Length)]);
            this.name = build.ToString();
            this.grade = random.Next(101);
        }
    }
    public class StudentList
    {
        private Student[] students;
        public Student this[int index]
        {
            get { return students[index]; }
            set { students[index] = value; }
        }
        public StudentList(int count)
        {
            students = new Student[count];
            for (int i = 0; i < count; i++)
            {
                students[i] = new Student(202001 + i);
            }
        }
        public int Length
        {
            get { return students.Length; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StudentList students = new StudentList(20);
            Console.WriteLine("排序前的学生信息表：");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}", students[i].num, students[i].name, students[i].grade);
            }
            for (int i = 1; i < students.Length - 10; i++)
            {
                if (students[i].grade > students[i - 1].grade)
                {
                    Student temp = students[i];
                    int j = i - 1;
                    for (; j >= 0 && temp.grade > students[j].grade; j--)
                    {
                        students[j + 1] = students[j];
                    }
                    students[j + 1] = temp;
                }                
            }
            Console.WriteLine("排序后的学生信息表：");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}", students[i].num, students[i].name, students[i].grade);
            }
            Console.ReadLine();
        }
    }
}
