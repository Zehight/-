using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JiebaNet.Analyser;
using JiebaNet.Segmenter;

namespace jieba分词
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr=new StreamReader("in_2.txt");
            string text = sr.ReadToEnd();
            sr.Close();
            var segmenter = new JiebaSegmenter();
            var segments = segmenter.Cut(text, cutAll: true);
            segments = segmenter.Cut(text);  // 默认为精确模式
            string ceshi = string.Join("/",segments);
            Dictionary<string, int> wn = new Dictionary<string, int>();
            StreamWriter sw = new StreamWriter("out_2.txt");
            foreach (string word in segments)
            {
                if (wn.ContainsKey(word))
                    wn[word] += 1;
                else
                    wn[word] = 1;
            }
            for (int j=0;j<wn.Count;j++)
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
            //Console.WriteLine(d);
            /*
            for (int i = 0; i < wn.Count; i++)
            {
                Console.WriteLine(wn.ElementAt(i));
            }
            */
        }
        /*
        for (int i = 0; i < wn.Count; i++)
        {
            Console.WriteLine(wn.Max());
            */
        
    }
}
