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
            int a = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 9; i++)
            {
                Console.WriteLine(a + " * " + i + " = " + (a * i));
            }
        }
    }
}