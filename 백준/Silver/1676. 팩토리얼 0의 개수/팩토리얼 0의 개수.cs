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
            string b = Fact(a).ToString();
            int c = 0;
            for (int i = b.Length - 1; i >= 0; i--)
            {
                if (b[i] == '0')
                {
                    c++;
                }
                if (b[i] != '0')
                {
                    break;
                }
            }
            Console.WriteLine(c);
        }
        static public BigInteger Fact(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Fact(n - 1);
            }
        }
    }
}