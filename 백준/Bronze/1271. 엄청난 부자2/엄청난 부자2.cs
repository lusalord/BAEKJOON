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
            BigInteger[] arr = Array.ConvertAll(Console.ReadLine().Split(), BigInteger.Parse);
            Console.WriteLine(arr[0] / arr[1]);
            Console.WriteLine(arr[0] % arr[1]);

        }
    }
}