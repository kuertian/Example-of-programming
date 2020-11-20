using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo059
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
    class StudentNode
    {
        //学生信息
        public readonly Student Student;
        //左孩子节点
        public StudentNode LeftChild { get; set; }
        //右孩子节点
        public StudentNode RightChild { get; set; }
        public StudentNode(Student student)
        {
            this.Student = student;
        }
    }
    class StudentTree
    {
        //树节点
        public readonly StudentNode Root;
        public static Random R = new Random();
        int count = 0;
        public StudentTree(int count)
        {
            this.count = count;
            this.Root = CreateNode(ref count);
        }
        //创建节点及其子节点
        StudentNode CreateNode(ref int index)
        {
            if (R.Next(count) > index)
                return null;
            if (--index == 0)
                return null;
            StudentNode node = new StudentNode(new Student(2020001 + index));
            //创建左孩子
            node.LeftChild = CreateNode(ref index);
            //创建右孩子
            node.RightChild = CreateNode(ref index);
            return node;
        }
        //先序遍历
        public void PreOrder(StudentNode node)
        {
            if (node == null)
                return;
            Console.Write(node.Student.Name + "\t");
            PreOrder(node.LeftChild);
            PreOrder(node.RightChild);
        }
        //中序遍历
        public void InOrder(StudentNode node)
        {
            if (node == null)
                return;
            InOrder(node.LeftChild);
            Console.Write(node.Student.Name + "\t");
            InOrder(node.RightChild);
        }
        //后续遍历
        public void PostOrder(StudentNode node)
        {
            if (node == null)
                return;
            PostOrder(node.LeftChild);
            PostOrder(node.RightChild);
            Console.Write(node.Student.Name + "\t");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //创建学生信息二叉树
            StudentTree tree = new StudentTree(8);
            Console.WriteLine("先序遍历：");
            tree.PreOrder(tree.Root);
            Console.WriteLine("\n中序遍历：");
            tree.InOrder(tree.Root);
            Console.WriteLine("\n后续遍历：");
            tree.PostOrder(tree.Root);
            Console.ReadLine();
        }
    }
}
