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
            BigInteger[] a = Array.ConvertAll(Console.ReadLine().Split(), BigInteger.Parse);

            Console.WriteLine(a[0] + a[1]);
        }
    }
}