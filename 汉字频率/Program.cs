using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 汉字频率
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("in_1.txt");
            string text = sr.ReadToEnd();
            sr.Close();
            string[] ay = text.ToCharArray().Select(s => s.ToString()).ToArray();
            StreamWriter sw = new StreamWriter("out_1.txt");
            Dictionary<string, int> wn = new Dictionary<string, int>();
            foreach (string word in ay)
            {
                if (wn.ContainsKey(word))
                    wn[word] += 1;
                else
                    wn[word] = 1;
            }
            for (int j = 0; j < wn.Count; j++)
            {
                for (int i = 0; i < wn.Count; i++)
                {
                    int d = wn.Values.Max();
                    int zhao = wn.ElementAt(i).Value;
                    if (zhao == d)
                    {
                        Console.WriteLine(wn.ElementAt(i));
                        sw.WriteLine(wn.ElementAt(i));
                        wn.Remove(wn.ElementAt(i).Key);
                    }
                }
            }
            sw.Close();
        }
    }
}
