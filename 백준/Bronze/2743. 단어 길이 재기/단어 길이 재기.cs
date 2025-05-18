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
            string a = Console.ReadLine();
            int b = 0;

            for(int i = 0; i < a.Length; i++)
            {
                b += 1;
            }
            Console.WriteLine(b);

        }
    }
}