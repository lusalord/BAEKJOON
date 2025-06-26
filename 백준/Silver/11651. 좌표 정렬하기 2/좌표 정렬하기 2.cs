using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int a = int.Parse(Console.ReadLine());
            List<int[]> b = new List<int[]>();

            for(int i = 0; i < a; i++)
            {
                int[] v = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                b.Add(v);
            }

            var so = b.OrderBy(x => x[1]).ThenBy(x => x[0]);

            foreach(int[] v in so)
            {
                sb.AppendLine($"{v[0]} {v[1]}");
            }
            Console.WriteLine(sb);
        }
        
    }
}