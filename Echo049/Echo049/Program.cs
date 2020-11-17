using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo049
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("将李白的《静夜思》填写完整：");
            string[] poetry = new string[] { "明月光", "疑是霜", "举头望", "低头思" };
            foreach (string item in poetry)
                Console.WriteLine(item);
            Console.Write("请填补第1句");
            Console.WriteLine(poetry[0].Insert(0, Console.ReadLine()));
            Console.Write("请填补第2句");
            Console.WriteLine(poetry[1].Insert(2, Console.ReadLine()));
            Console.Write("请填补第3句");
            Console.WriteLine(poetry[2].Insert(3, Console.ReadLine()));
            Console.Write("请填补第4句");
            Console.WriteLine(poetry[3].Insert(3, Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
