using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if(a == 60 &&  b == 60 && c == 60)
            {
                Console.WriteLine("Equilateral");
            }
            else if(a + b + c == 180 && (a == b || b == c || c == a))
            {
                Console.WriteLine("Isosceles");
            }
            else if (a + b + c == 180 && (a != b || b != c || c != a))
            {
                Console.WriteLine("Scalene");
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}