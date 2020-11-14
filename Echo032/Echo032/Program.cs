using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo032
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[,] results = new byte[20, 4];
            Random random = new Random();
            Console.WriteLine("学号\t高数\tC语言\t英语");

            for (int id = 0; id < results.GetLength(0); id++)
            {
                Console.Write(id);
                for (int i = 1; i < results.GetLength(1); i++)
                {
                    results[id, i] = (byte)random.Next(101); //随机生成学生成绩
                    Console.Write("\t" + results[id, i]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
