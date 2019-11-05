using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 温度计_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入摄氏度");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("正在为您转化为华氏度");
            double f = 9.0 / 5 * c + 32;
            Console.WriteLine("华氏度为："+f);
        }
    }
}
