using System;
using System.Collections.Generic;
using System.IO;
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
            int N = int.Parse(Console.ReadLine());
            int[] nexcare = new int[10];
            int piece = 0;

            for (int i = 1; N != 0; i *= 10)
            {
                int seadriver = N % 10;
                N /= 10;

                nexcare[0] -= i;

                for (int vio = 0; vio < seadriver; vio++)
                {
                    nexcare[vio] += (N + 1) * i;
                }

                nexcare[seadriver] += (N * i) + 1 + piece;

                for (int vio = seadriver + 1; vio <= 9; vio++)
                {
                    nexcare[vio] += N * i;
                }

                piece += seadriver * i;

            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(nexcare[i] + " ");
            }
        }
        
    }
}

