using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo056
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
    public class StudentNode
    {
        public Student Student { get; set; }
        public StudentNode Next { get; set; }
        public StudentNode(Student student, StudentNode next)
        {
            this.Student = student;
            this.Next = next;
        }
    }
    public class StudentLinkList
    {
        //链表头节点
        public StudentNode Head { get; set; }
        public StudentLinkList(int count)
        {
            Head = new StudentNode(new Student(2020001 + count), null);
            //头插法建表
            for (int i = count - 1; i > 0; i--)
            {
                //创建新节点，将原头节点作为新节点的下一节点，将新节点作为头节点
                Head = new StudentNode(new Student(2020001 + i), Head);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //创建含有5个元素的学生信息链表
            StudentLinkList list1 = new StudentLinkList(5);
            //学生信息表1的头节点设为当前节点
            StudentNode node1 = list1.Head;
            Console.WriteLine("输出学习信息表1：");
            while (node1 != null)
            {
                Console.Write(node1.Student.Name + "\t");
                node1 = node1.Next;
            }
           
            Console.WriteLine("\n\n输出学生信息表2：");
            StudentLinkList list2 = new StudentLinkList(5);
            StudentNode node2 = list2.Head;
            while (node2 != null)
            {
                Console.Write(node2.Student.Name + "\t");
                //将下一节点设置为当前节点
                node2 = node2.Next;
            }
            node1 = list1.Head;
            node2 = list2.Head;
            //将学生信息表2合并到学生信息表1中
            while (node1 != null && node2 != null)
            {
                //将表2当前节点从表2删除
                list2.Head = node2.Next;
                //将表1当前节点的后续节点拼接到表2当前节点
                node2.Next = node1.Next;
                //将表2当前节点作为表1当前节点的下一节点
                node1.Next = node2;
                //表1当前节点指向表2当前节点的下一节点
                node1 = node2.Next;
                //表2当前节点指向表2的头节点
                node2 = list2.Head;
            }
            Console.WriteLine("\n\n输出合并后的学生信息表1：");
            node1 = list1.Head;
            while (node1 != null)
            {
                Console.Write(node1.Student.Name + "\t");
                node1 = node1.Next;
            }
            Console.ReadLine();
        }
    }
}
