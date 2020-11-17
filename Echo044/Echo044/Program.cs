using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo044
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("《早发白帝城》");
            string[] poetry = new string[] { "朝辞白帝彩云间", "千里江陵一日还", "两岸猿声啼不住", "轻舟已过万重山" };
            foreach (string sentence in poetry)
            {
                char[] chars = sentence.ToCharArray();
                foreach (char item in chars.Reverse())
                {
                    Console.Write(item);
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
