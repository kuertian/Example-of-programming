using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo030
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("请输入一个整数：");
                    number = int.Parse(Console.ReadLine());
                    if (number < 0 || number > 100)
                        throw new ArgumentOutOfRangeException("number", "数值应该在100以内");
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    number = 100;
                    continue;
                }
                finally {
                    Console.WriteLine("输入整数为{0}", number);
                }
                break;
            }
            Console.ReadLine();
        }
    }
}
