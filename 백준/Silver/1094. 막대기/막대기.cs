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
            int count = 0;

            while (a > 0)
            {
                if(a % 2 == 1)
                {
                    count++;
                }
                a /= 2;
            }
            Console.WriteLine(count);
        }
    }
}