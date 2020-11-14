using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo031
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[6] { "张三", "李四", "王五", "赵六", "孙七", "周八" };
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i] + "\t");            

            }

            Console.WriteLine("\n将 {0} 改名为 {1}", "周八", "吴九");
            students[5] = "吴九";

            foreach (string name in students)
            {
                Console.Write(name + "\t");
            }
            Console.ReadLine();
        }
    }
}
