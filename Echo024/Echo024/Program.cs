using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo024
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (true)
            {
                Console.Write(i);
                if (i % 5 == 0)     //每5个数换行输出
                    Console.WriteLine();
                else
                    Console.Write("\t");
                if (++i > 20)       //当i大于20时跳出循环
                    break;
            }
            Console.ReadLine();
        }        
    }
}
