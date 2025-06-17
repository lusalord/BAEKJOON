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
            int a = int.Parse(Console.ReadLine());

            string[] w = new string[a];
            for(int i = 0; i < a; i++)
            {
                w[i] = Console.ReadLine();
            }

            w = w.Distinct().OrderBy(x => x.Length).ThenBy(x => x).ToArray();

            foreach(string ws in w)
            {
                Console.WriteLine(ws);
            }
        }
    }
}