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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = 0;

            while (true)
            {
                if (b > 0 || c > 0)
                {
                    f++;
                    b -= d;
                    c -= e;
                    
                }
                else
                {
                    Console.WriteLine(a - f);
                    break;
                }
            }
        }
    }
}