using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo048
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("《春江花月夜》");
            string poetry = "江天一色无纤尘，皎皎空中孤月轮。江畔何人初见月，江月何年初照人。";
            Console.WriteLine(poetry);
            string[] inputs = poetry.Split(new char[] { '，', '?', '。' },StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("《春江花月夜》");
            foreach (string item in inputs)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
