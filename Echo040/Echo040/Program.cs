using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo040
{
    class Program
    {
        static void Main(string[] args)
        {
            //进入舞厅的男士列表
            string[] gentlemen = new string[] { "郑义", "张三", "王五", "周奇", "钱九" };
            //进入舞厅的女士列表
            string[] ladies = new string[] { "胡二", "李四", "赵六" };
            //男士等待队列
            Queue<string> waitingGentlemen = new Queue<string>();
            //女士等待队列
            Queue<string> waitingLadies = new Queue<string>();
            //男士跳舞队列
            Queue<string> dancingGentlemen = new Queue<string>();
            //女士跳舞队列
            Queue<string> dancingLadies = new Queue<string>();
            //男士进入等待队列
            foreach (string gentleman in gentlemen)
            {
                waitingGentlemen.Enqueue(gentleman);
            }
            //女士进入等待队列
            foreach (string lady in ladies)
            {
                waitingLadies.Enqueue(lady);
            }
            //舞曲场次
            int turns = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("第 {0} 场舞曲开始：", turns++);
                while (waitingGentlemen.Count > 0 && waitingLadies.Count > 0)
                {
                    //从男士等待队列头部出来一位男士
                    string gentleman = waitingGentlemen.Dequeue();
                    //从女士等待队列头部出来一位女士
                    string lady = waitingLadies.Dequeue();
                    Console.WriteLine("{0} 先生与{1} 女士配成舞伴开始跳舞！", gentleman, lady);
                    //男士进入跳舞队列
                    dancingGentlemen.Enqueue(gentleman);
                    //女士进入跳舞队列
                    dancingLadies.Enqueue(lady);

                }
                //输出剩下没有舞伴的先生和女士
                foreach (var gentleman in waitingGentlemen)
                    Console.WriteLine("{0} 先生等待舞伴！", gentleman);
                foreach (var lady in waitingLadies)
                    Console.WriteLine("{0} 女士等待舞伴！", lady);
                Console.WriteLine("舞曲停止：");
                while (dancingGentlemen.Count > 0 && dancingLadies.Count > 0)
                {
                    //从男士跳舞队列中出来一位男士
                    string gentleman = dancingGentlemen.Dequeue();
                    //从女士跳舞队列中出来一位女士
                    string lady = dancingLadies.Dequeue();
                    Console.WriteLine("{0} 先生进入等待队列！", gentleman);
                    Console.WriteLine("{0} 女士进入等待队列！", lady);
                    //男士进入等待队列末尾
                    waitingGentlemen.Enqueue(gentleman);
                    //女士进入等待队列末尾
                    waitingLadies.Enqueue(lady);
                }
            } while (Console.ReadLine() != "exit");
            Console.ReadLine();
        }
    }
}
