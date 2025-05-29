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
            BigInteger a = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(a % 20000303);
        }
    }
}