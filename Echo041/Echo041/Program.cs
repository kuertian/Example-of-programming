using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo041
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入带括号的表达式：");
            string expression = Console.ReadLine();
            if (expression == string.Empty)
                return;
            Stack<char> brackets = new Stack<char>();
            foreach (char bracket in expression)
            {
                if (bracket.ToString() == "(" || bracket.ToString() == "[" || bracket.ToString() == "{")
                {
                    //括号入栈
                    brackets.Push(bracket);
                }               
                else if (bracket.ToString() == ")" && brackets.Count != 0 && brackets.Pop().ToString() != "("
                    || bracket.ToString() == "]" && brackets.Count != 0 && brackets.Pop().ToString() != "["
                    || bracket.ToString() == "}" && brackets.Count != 0 && brackets.Pop().ToString() != "{")
                {
                    Console.WriteLine("表达式括号格式错误！");
                    continue;
                }
            }
            if (brackets.Count == 0)
            {
                Console.WriteLine("表达式括号格式正确！");
            }
            else
            {
                Console.WriteLine("表达式括号格式错误！");
            }
            Console.ReadLine();
        }
    }
}
