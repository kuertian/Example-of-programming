using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Echo052
{
    class Program
    {
        static void Main(string[] args)
        {
            //正则表达式字符串
            string pattern = @"^((2[5][0-5]|2[0-4][0-9]|1\d{2}|[1-9]?\d)\.){3}(2[5][0-5]|2[0-4][0-9]|1\d{2}|[1-9]?\d)$";
            //创建正则表达式对象
            Regex regex = new Regex(pattern);
            Console.WriteLine("请输入IP地址：");
            //判定ip地址格式是否正确
            while (!regex.IsMatch(Console.ReadLine()))
            {
                Console.WriteLine("IP地址格式错误！");
                Console.WriteLine("请输入IP地址：");
            }
            Console.WriteLine("IP地址格式正确！");
            Console.ReadLine();
        }
    }
}
