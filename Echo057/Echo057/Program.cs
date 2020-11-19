using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo057
{
    class NumberNode
    {
        public int Number { get; set; }
        public NumberNode Next { get; set; }
        public NumberNode(int number, NumberNode next)
        {
            this.Number = number;
            this.Next = next;
        }
    }
    class NumberStack
    {
        private NumberNode top;
        public void Push(int number)
        {
            if (top == null)
                top = new NumberNode(number, null);
            else
                top = new NumberNode(number, top);

        }
        public int? Pop()
        {
            if (this.top == null)
                return null;
            else
            {
                int number = top.Number;
                top = top.Next;
                return number;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个十进制正整数：");
            int number = int.Parse(Console.ReadLine());
            //创建数字链栈
            NumberStack stack = new NumberStack();
            while (number > 0)
            {
                //八进制低位先进栈
                stack.Push(number % 8);
                number /= 8;
            }
            //八进制高位先出栈
            int? bit = stack.Pop();
            while (bit != null)
            {
                Console.Write(bit);
                //八进制高位先出栈
                bit = stack.Pop();
            }
            Console.ReadLine();
        }
    }
}
