using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo026
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 40;
            Console.WindowHeight = 40;

            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0) //如果是偶数
                {
                    sum -= i;   //减去偶数
                    if (i == 100)
                    {
                        Console.Write("{0} = {1}", i, sum);
                    }
                    else
                    {
                        Console.Write("{0} + ", i);//偶数后面为+
                    }
                }
                else
                {
                    sum += i;
                    Console.Write("{0} -", i);//奇数后面为-
                }
               
            }
            Console.ReadLine();
        }
    }
}
