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
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());
            int b = 0;

            for(int i = 0; i < n; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

                b = arr[0] + arr[1];
                sb.AppendLine(b.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}