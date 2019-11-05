using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序输出_小_大__console
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[5];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
        }
    }
}
