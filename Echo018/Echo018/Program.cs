using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo018
{
    class Program
    {
        public void GetMultResult(out int result, params int[] numbers)
        {
            result = 1;
            foreach (int number in numbers)
            {
                result *= number;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数：");
            int Number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数：");
            int Number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第三个数：");
            int Number3 = int.Parse(Console.ReadLine());

            Program p = new Program();
            int result;
            p.GetMultResult(out result, Number1, Number2, Number3);
            Console.WriteLine("{0}*{1}*{2}={3}", Number1, Number2, Number3, result);
            Console.ReadLine();
        }
    }
}
