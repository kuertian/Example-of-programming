using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo025
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                if (++i % 2 != 0)
                    continue;
                Console.Write(i);
                if (i % 5 == 0)
                    Console.WriteLine();
                else
                    Console.Write("\t");
            } while (i < 20);

            Console.ReadLine();
        }
    }
}
