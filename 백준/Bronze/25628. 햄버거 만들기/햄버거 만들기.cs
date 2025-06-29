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
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = 0;

            while(true)
            {
                if (arr[0] >= 2 && arr[1] >= 1)
                {
                    arr[0] -= 2;
                    arr[1] -= 1;
                    a++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(a);
        }
        
    }
}