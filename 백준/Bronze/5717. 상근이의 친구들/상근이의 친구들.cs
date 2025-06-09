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
            while (true)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                if (arr[0] == 0 && arr[1] == 0)
                {
                    break;
                }
                Console.WriteLine(arr[0] + arr[1]);

            }
        }
    }
}