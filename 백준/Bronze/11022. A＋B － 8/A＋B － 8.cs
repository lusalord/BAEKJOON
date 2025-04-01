using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int b = 0;
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < T; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                b = arr[0] + arr[1];
                sb.AppendLine("Case #"+ (i + 1) + ": " + arr[0] + " + " + arr[1] + " = " +b.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}