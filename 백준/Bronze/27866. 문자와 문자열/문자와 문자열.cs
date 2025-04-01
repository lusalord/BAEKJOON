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
            string text = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(text[a - 1]);
        }
    }
}