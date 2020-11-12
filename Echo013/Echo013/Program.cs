using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo013
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数：");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}的十六进制形式为0x{1:X8}", Number, Number);
            int NumberHex = Number & 0x000000FF;
            //十六进制输出第1字节
            Console.WriteLine("第1个字节为：0x{0:X2}", NumberHex);
            //将数值右移8位与0xFF按位与运算
            NumberHex = Number >> 8 & 0x000000FF;
            //十六进制输出第2字节
            Console.WriteLine("第2个字节为：0x{0:X2}", NumberHex);
            //将数值右移16位与0xFF按位与运算
            NumberHex = Number >> 16 & 0x000000FF;
            //十六进制输出第3字节
            Console.WriteLine("第3个字节为：0x{0:X2}", NumberHex);
            //将数值右移24位与0xFF按位与运算
            NumberHex = Number >> 24 & 0x000000FF;
            //十六进制输出第4字节
            Console.WriteLine("第4个字节为：0x{0:X2}", NumberHex);
            Console.ReadLine();
        }
    }
}
