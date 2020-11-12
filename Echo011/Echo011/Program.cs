using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数：");
            int Number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入算术运算符：");
            String Operator = Console.ReadLine();
            Console.WriteLine("请输入第二个数：");
            int Number2 = int.Parse(Console.ReadLine());

            int result = 0;
            switch(Operator)
            {
                case "+":
                    result = Number1;
                    result += Number2;
                    break;
                case "-":
                    result = Number1 - Number2;
                    break;
                case "*":
                    result = Number1 * Number2;
                    break;
                case "/":
                    result = Number1 / Number2;
                    break;
                case "%":
                    result = Number1 % Number2;
                    break;
                default:
                    Console.WriteLine("运算符输入错误！");
                    return;
            }
            Console.WriteLine("{0} {1} {2} = {3}", Number1, Operator, Number2, result);
            Console.ReadLine();
        }
    }
}
