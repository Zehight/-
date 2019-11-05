using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 储蓄存款计算器_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入存款金额：");
            double money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入存款年限：");
            double year = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入年利率：");
            double rate= Convert.ToDouble(Console.ReadLine())/100;
            double interest = money * rate * year;
            Console.WriteLine("利息总额为："+interest);
            double total = money + interest;
            Console.WriteLine("本息总和为："+total);
        }
    }
}
