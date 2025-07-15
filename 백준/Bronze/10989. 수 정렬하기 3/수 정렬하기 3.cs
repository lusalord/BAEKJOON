using System;
using System.Collections.Generic;
using System.IO;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
             StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            
            int N = int.Parse(sr.ReadLine());
            int[] cnt = new int[10001];
            
            for (int i=0; i<N; i++)
            {
                int num = int.Parse(sr.ReadLine());
                cnt[num]++;
            }
            for (int i=0; i<cnt.Length; i++)
            {
                for (int j=0; j<cnt[i]; j++)
                {
                    sw.WriteLine(i);
                }
            }
            
            sr.Close();
            sw.Close();
        }
    }
}