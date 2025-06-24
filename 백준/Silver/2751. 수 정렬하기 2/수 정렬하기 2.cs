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
            int[] arr = new int[a];
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                arr[i] = b;
            }

            Array.Sort(arr);

            for(int i = 0; i < arr.Length; i++)
            {
                sb.AppendLine(arr[i].ToString());
            }
            Console.WriteLine(sb);
        }
    }
}