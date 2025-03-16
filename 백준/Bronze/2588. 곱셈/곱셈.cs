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
            string b = Console.ReadLine();


            Console.WriteLine(a * int.Parse(b[2].ToString()));
            Console.WriteLine(a * int.Parse(b[1].ToString()));
            Console.WriteLine(a * int.Parse(b[0].ToString()));
            Console.WriteLine(a * int.Parse(b));

        }
    }
}