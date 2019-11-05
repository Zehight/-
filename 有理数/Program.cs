using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 有理数
{
    class Program
    {
        static void Main(string[] args)
        {
            youLiShu a = new youLiShu(3, 2);//第一个数
            youLiShu b = new youLiShu(4, 5);//第二个数
            youLiShu c = new youLiShu();//用于接收结果
            youLiShu.jieguo(c.Add(a,b));//输出
        }
    }
    class youLiShu
    {
        public double fenmu;
        public double fenzi;

        public static void jieguo(youLiShu c)
        {
            Console.WriteLine(c.fenzi + "/" + c.fenmu);
        }
        public youLiShu(double fenzi = 1, double fenmu = 1)
        {
            this.fenzi = fenzi;
            this.fenmu = fenmu;

        }


        public youLiShu Add(youLiShu a, youLiShu b)
        {
            youLiShu c = new youLiShu(1, 1);
            c.fenzi = a.fenzi * b.fenmu + a.fenmu * b.fenzi;
            c.fenmu = b.fenmu * a.fenmu;
            //Console.WriteLine("hello11");
            return c;

        }
        public youLiShu Sub(youLiShu a, youLiShu b)
        {
            youLiShu c = new youLiShu(1, 1);
            c.fenzi = a.fenzi * b.fenmu - a.fenmu * b.fenzi;
            c.fenmu = b.fenmu * c.fenmu;
            return c;
        }
        public youLiShu Cheng(youLiShu a, youLiShu b)
        {
            youLiShu c = new youLiShu(1, 1);
            c.fenzi = a.fenzi * b.fenzi;
            c.fenmu = b.fenmu * b.fenmu;
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