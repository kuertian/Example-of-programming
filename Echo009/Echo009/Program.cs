using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo009
{
    class Rectangle
    {
        public int Width, Height;//声明整型变量表示矩形的宽和高
        public int TryArea()    //计算矩形面积并检测数据溢出
        {
            checked {
                int area = Width * Height;
                return area;
            }
        }
        public int Area()
        {
            return Width * Height;  //计算矩形面积
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();   //创建矩形实例
            Console.WriteLine("请输入矩形宽度：");
            //从控制台输入数据给矩形的宽度赋值
            rect.Width = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入矩形高度：");
            //从控制台输入数据给矩形的高度赋值
            rect.Height = int.Parse(Console.ReadLine());
            Console.WriteLine("矩形面积为：\n{0}", rect.Area());
            //检测矩形面积是否发生数据溢出
            Console.WriteLine("矩形面积为：\n{0}", rect.TryArea());
            Console.ReadLine();
        }
    }
}
