using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo017
{
    class Program
    {
        static decimal Factorial(decimal n)
        {
            if (n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数：");
            decimal number = decimal.Parse(Console.ReadLine());
            decimal fac = Factorial(number);
            Console.WriteLine("{0}的阶乘为{1}", number,fac);
            Console.ReadLine();
        }
    }
}
