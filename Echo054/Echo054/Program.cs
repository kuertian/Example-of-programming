using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo054
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("《鸟鸣涧》");
            string poetry = "人闲桂花落，夜静春山空。月出惊山鸟，时鸣春涧中。";
            Console.WriteLine(poetry);
            //将古诗转换成字节数组
            byte[] bytePoetry = Encoding.Default.GetBytes(poetry);
            //将字节数组进行Base64编码
            string base64Poetry = Convert.ToBase64String(bytePoetry);
            Console.WriteLine("古诗的Base64编码为：");
            Console.WriteLine(base64Poetry);
            //将Base64编码转换成字节码
            bytePoetry = Convert.FromBase64String(base64Poetry);
            //将字节码转换成古诗
            string str = Encoding.Default.GetString(bytePoetry);
            Console.WriteLine("Base编码古诗还原为：");
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
