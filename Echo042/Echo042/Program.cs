using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo042
{
    class Program
    {
        static void Main(string[] args)
        {
            string poetry = "日照香炉生紫烟，遥看瀑布挂前川。飞流直下三千尺，疑是银河落九天。\n";
            Console.WriteLine(poetry);
            foreach (char item in poetry)
            {
                Console.Write(item);
                Console.Write("\t");
                if (Char.IsPunctuation(item))
                    Console.Write("\n\n");
            }
            Console.ReadLine();
        }
    }
}
