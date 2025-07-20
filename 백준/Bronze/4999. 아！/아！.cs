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
            string b = Console.ReadLine();

            if(a.Length >= b.Length)
            {
                Console.WriteLine("go");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}