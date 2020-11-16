using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo038
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> provinces = new Dictionary<string, List<string>>();
            List<string> HeBei = new List<string>();
            provinces.Add("河北", HeBei);
            HeBei.Add("石家庄");
            HeBei.Add("唐山");
            List<string> ShanXi = new List<string>();
            provinces.Add("山西", ShanXi);
            ShanXi.Add("太原");
            ShanXi.Add("晋中");
            List<string> SiChuan = new List<string>();
            provinces.Add("四川", SiChuan);
            SiChuan.Add("成都");
            SiChuan.Add("达州");

            foreach(KeyValuePair<string,List<string>> province in provinces)
            {
                Console.WriteLine("{0}省：", province.Key);
                foreach (string city in province.Value)
                {
                    Console.WriteLine("\t{0}市", city);
                }
            }
            Console.WriteLine("请输入需要查询的省份：");
            string pro = Console.ReadLine();
            if (provinces.ContainsKey(pro))
            {
                foreach (string city in provinces[pro])
                {
                    Console.WriteLine("\t{0}市", city);
                }
            }
            else
            {
                Console.WriteLine("您需要查询的省份不存在！");
            }
            Console.ReadLine();
        }
    }
}
