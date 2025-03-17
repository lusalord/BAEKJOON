using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int count = 1;

            for(int i = 1; i <= N; i++)
            {
                count = count * i;
            }
            Console.WriteLine(count);
        }
    }
}