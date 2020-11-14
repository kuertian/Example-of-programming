using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo029
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入字符串：");
            string String = Console.ReadLine();

            foreach (Char c in String)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
