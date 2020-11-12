using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo012
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数：");
            int Number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数：");
            int Number2 = int.Parse(Console.ReadLine());

            if (Number1 == Number2)
            {
                Console.WriteLine("{0} 等于 {1}", Number1, Number2);
            }
            else if (Number1 > Number2)
            {
                Console.WriteLine("{0} 大于 {1}", Number1, Number2);
            }
            else if (Number1 < Number2)
            {
                Console.WriteLine("{0} 小于 {1}", Number1, Number2);
            }
            Console.ReadLine();
        }
    }
}
