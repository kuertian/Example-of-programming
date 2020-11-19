using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo058
{
    class CharNode
    {
        public char Char { get; set; }
        public CharNode Next { get; set; }
        public CharNode(char Char, CharNode next)
        {
            this.Char = Char;
            this.Next = next;
        }
    }
    class CharQueue
    {
        //队头
        CharNode front;
        //队尾
        CharNode rear;
        public void In(char Char)
        {
            if (rear == null)
            {
                //创建队头节点
                rear = new CharNode(Char, null);
                front = rear;
            }
            else
            {
                rear.Next = new CharNode(Char, null);
                //创建队尾节点
                rear = rear.Next;
            }
        }
        public char? Out()
        {
            if (front == null)
                return null;
            char Char = front.Char;
            front = front.Next;
            if (front == null)
                rear = null;
            return Char;
        }
    }
    //字符链栈
    class CharStack
    {
        //栈顶
        CharNode top;
        //进栈
        public void Push(char Char)
        {
            if (top == null)
            {
                top = new CharNode(Char, null);
            }
            else
            {
                top = new CharNode(Char, top);
            }
        }
        //出栈
        public char? Pop()
        {
            if (this.top == null)
                return null;
            else
            {
                char Char = top.Char;
                top = top.Next;
                return Char;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入字符串：");
            string str = Console.ReadLine();
            //创建字符栈
            CharStack stack = new CharStack();
            //创建字符队列
            CharQueue queue = new CharQueue();
            foreach (var Char in str)
            {
                //字符串入栈
                stack.Push(Char);
                //字符串入队
                queue.In(Char);
            }
            char? charStack, charQueue;
            do
            {
                //字符串出栈
                charStack = stack.Pop();
                //字符串出队
                charQueue = queue.Out();
                if (charStack != charQueue)
                    break;
            } while (charStack != null && charQueue != null);
            if (charStack != null || charQueue != null)
            {
                Console.WriteLine("“{0}”不是回文", str);
            }
            else
            {
                Console.WriteLine("“{0}”是回文", str);
            }
            Console.ReadLine();
        }
    }
}
