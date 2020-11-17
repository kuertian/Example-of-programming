using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo050
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("《暮江吟》");
            string poetryRight = "一道残阳铺水中，半江瑟瑟半江江。可怜九月初三夜，露似珍珠月似弓。";
            string poetryWrong = "一道阳光铺水中，半江瑟瑟半江江。可怜九月初三夜，露像珍珠月似弓。";
            do
            {
                Console.WriteLine(poetryWrong);
                Console.WriteLine("请输入功能：删除，替换");
                string function = Console.ReadLine();
                switch (function)
                {
                    case "删除":
                        Console.Write("请输入删除的字符串起始位置：");
                        int start = int.Parse(Console.ReadLine());
                        Console.Write("请输入字符串长度：");
                        int lenght = int.Parse(Console.ReadLine());
                        poetryWrong = poetryWrong.Remove(start, lenght);
                        break;
                    case "替换":
                        Console.Write("请输入需要替换的字符串：");
                        string oldValue = Console.ReadLine();
                        Console.Write("请输入替换后的字符串：");
                        string newValue = Console.ReadLine();
                        poetryWrong = poetryWrong.Replace(oldValue, newValue);
                        break;
                    default:
                        Console.Write("功能错误！");
                        break;
                }
            } while (poetryRight != poetryWrong);
            Console.WriteLine(poetryRight);
            Console.WriteLine("修改成功！");
            Console.ReadLine();
        }
    }
}
