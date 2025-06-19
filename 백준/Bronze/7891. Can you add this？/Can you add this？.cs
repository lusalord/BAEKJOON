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
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < a; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                sb.AppendLine((arr[0] + arr[1]).ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}