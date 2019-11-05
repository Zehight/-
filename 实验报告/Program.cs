using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验报告
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一个数是分子，第二个数是分母
            youLiShu a = new youLiShu(4, 2);//第一个数
            youLiShu b = new youLiShu(4, 2);//第二个数
            youLiShu c = new youLiShu();//用于接收结果
            Console.WriteLine(c.Add(a, b).fenzi + "/" + c.Add(a, b).fenmu);
        }
    }
    class youLiShu
    {
        public double fenmu;
        public double fenzi;
        public youLiShu(double fenzi = 1, double fenmu = 1)
        {
            this.fenzi = fenzi;
            this.fenmu = fenmu;

        }
        public youLiShu zuiXiao(youLiShu a)
        {
            double x = a.fenzi;
            double y = a.fenmu;
            youLiShu c = new youLiShu(1, 1);
            double temp;
            while (a.fenzi != 0)
            {
                temp = x % y;
                x = y;
                y = temp;
            }
            c.fenzi = a.fenzi / x;
            c.fenmu = a.fenmu / x;
            //Console.WriteLine("hello");
            return c;

        }

        public youLiShu Add(youLiShu a, youLiShu b)
        {
            youLiShu c = new youLiShu(1, 1);
            c.fenzi = a.fenzi * b.fenmu + a.fenmu * b.fenzi;
            c.fenmu = b.fenmu * a.fenmu;
            c.zuiXiao;
            //Console.WriteLine("hello11");
            return c;

        }
        public youLiShu Sub(youLiShu a, youLiShu b)
        {
            youLiShu c = new youLiShu(1, 1);
            c.fenzi = a.fenzi * b.fenmu - a.fenmu * b.fenzi;
            c.fenmu = b.fenmu * a.fenmu;
            return c;
        }
        public youLiShu Cheng(youLiShu a, youLiShu b)
        {
            youLiShu c = new youLiShu(1, 1);
            c.fenzi = a.fenzi * b.fenzi;
            c.fenmu = b.fenmu * a.fenmu;
            return c;
        }
        public youLiShu Chu(youLiShu a, youLiShu b)
        {
            youLiShu c = new youLiShu(1, 1);
            c.fenzi = a.fenzi * b.fenmu;
            c.fenmu = a.fenmu * b.fenzi;
            return c;
        }
    }
}
