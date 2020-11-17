using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo045
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("《清明》");
            string[] poetry = new string[] { "清明时节雨纷纷,", "路上行人欲断魂。", "借问酒家何处有，", "牧童遥指杏花村。" };
            foreach (string sentence in poetry)
            {
                Console.WriteLine(sentence);
            }
            Console.Write("请输入需要提取的词语所在句子：");
            int line = int.Parse(Console.ReadLine()) - 1;
            Console.Write("请输入需要提取的词语起始位置：");
            int start = int.Parse(Console.ReadLine())-1;
            Console.Write("请输入需要提取的词语长度：");
            int length = int.Parse(Console.ReadLine());
            Console.Write(poetry[line].Substring(start, length));
            Console.ReadLine();
        }
    }
}
